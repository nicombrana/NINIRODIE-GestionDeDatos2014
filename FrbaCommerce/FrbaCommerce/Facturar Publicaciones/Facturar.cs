﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.ClasesNINIRODIE.Repositorios;
using FrbaCommerce.ClasesNINIRODIE;
using FrbaCommerce.ClasesNINIRODIE.Dominio;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class Facturar : Form
    {
        Decimal codigoUsuario;
        TipoFactura tipoFacturacion;
        List<Facturable> Facturables = new List<Facturable>();
        Factura factura = new Factura();
        MediosPago medioPago = new MediosPago();

        public Facturar(Decimal codigoUser, TipoFactura tipoFacturacion)
        {
            InitializeComponent();
            codigoUsuario = codigoUser;
            this.tipoFacturacion = tipoFacturacion;

            this.PopularFormaPago();
            this.RenombrarComprarOfertar();
            this.compraOfertaGrilla.DataSource = new List<Facturable>();
            this.compraOfertaGrilla.Columns["codigoFacturable"].Visible = false;
            this.compraOfertaGrilla.Columns["facturaId"].Visible = false;
            this.compraOfertaGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MessageBox.Show("Debe ingresar una cantidad a Facturar", "Atención", MessageBoxButtons.OK);
        }

        private void RenombrarComprarOfertar()
        {
            if (tipoFacturacion == TipoFactura.FacturarPublicacion)
            {
                this.compraOfertaGruopBox.Text = "Publicaciones";
                this.busquedaGroupBox.Text = "Búsqueda Publicaciones";
            }
        }

        private void PopularGrilla()
        {
            if (tipoFacturacion == TipoFactura.FacturarCompraOferta)
                this.PopularGrillaComprasOfertas();
            else
                this.PopularGrillaPublicaciones();

            MessageBox.Show("Recuerde que facturará todas los" +
                "Items aquí presentes.\n Por lo que no podrá seleccionar ninguno de los mismos."
                , "Atención", MessageBoxButtons.OK);
        }

        private void PopularFormaPago()
        {
            this.formaPagoComboBox.DataSource = new List<String> 
                {"Efectivo", "Tarjeta de Débito", "Tarjeta de Crédito" };
            this.formaPagoComboBox.Refresh();
        }
        //Revisar
        private void PopularGrillaComprasOfertas()
        {
            var cantidad = int.Parse(this.cantidadTextBox.Text);
            var compras = RepositorioCompra.Instance.BuscarComprasHechasAlUsuario(codigoUsuario, cantidad);
            var ofertas = RepositorioOferta.Instance.BuscarOfertasHechasAlUsuario(codigoUsuario, cantidad);

            foreach (Compra compra in compras)
            {
                Publicacion publicacion = RepositorioPublicacion.Instance.BuscarPublicaciones(compra.id_publicacion);
                Decimal porcentaje = RepositorioVisibilidad.Instance.ObtenerMontoAPagarParaPublicacion(publicacion.visibilidad_codigo);

                var montoAFacturarPorCompra = porcentaje * publicacion.precio;

                Facturable facturable = new Facturable(compra.id_publicacion, this.codigoUsuario,
                    montoAFacturarPorCompra, compra.cantidad, FechaSistema.Instance.fecha);
                
                Facturables.Add(facturable);
            }

            foreach (Oferta oferta in ofertas)
            {
                Publicacion publicacion = RepositorioPublicacion.Instance.BuscarPublicaciones(oferta.subasta_id);
                Decimal porcentaje = RepositorioVisibilidad.Instance.ObtenerMontoAPagarParaPublicacion(publicacion.visibilidad_codigo);

                var montoAFacturarPorSubasta = porcentaje * oferta.monto;

                Facturable facturable = new Facturable(oferta.subasta_id, this.codigoUsuario, montoAFacturarPorSubasta,
                    1, FechaSistema.Instance.fecha);

                Facturables.Add(facturable);
            }
            if (Facturables.Count < cantidad)
                this.compraOfertaGrilla.DataSource = Facturables;
            else
            {
                Facturables = Facturables.GetRange(0, cantidad);
                this.compraOfertaGrilla.DataSource = Facturables;
            }
            this.compraOfertaGrilla.Refresh();
        }

        private void PopularGrillaPublicaciones()
        {
            var cantidad = int.Parse(this.cantidadTextBox.Text);
            Facturables = RepositorioPublicacion.Instance.BuscarPublicacionesParaFacturar(codigoUsuario, cantidad);

            this.compraOfertaGrilla.DataSource = Facturables;
            this.compraOfertaGrilla.Refresh();
        }

        private void salirBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void facturarBoton_Click(object sender, EventArgs e)
        {
            this.ObtenerDatosMediosPago();
            this.AlmacenarFacturables();

            MessageBox.Show("Se ha realizado la facturación correctamente.\n" +
                "Su número de factura es el " + factura.id_fatcura.ToString() + "."
                , "Informe", MessageBoxButtons.OK);

            this.Close();
        }

        private void ObtenerDatosMediosPago()
        {
            String formaPago = (String)this.formaPagoComboBox.SelectedItem;
            medioPago.descripcion = formaPago;
            if (formaPago != "Efectivo")
            {
                new FormaDePago(medioPago).ShowDialog(this);
            }
            else
                medioPago.pagoId = 1;
        }

        private void AlmacenarFacturables()
        {
            factura.id_fatcura = RepositorioFactura.Instance.ProximoCodigo();
            factura.comprador = this.codigoUsuario;
            factura.pagada = false;
            Decimal total = 0;
            
            if (medioPago.pagoId == 1)
                factura.medios_de_pago = 1;
            else
                RepositorioFactura.Instance.AlmacenarMedioPago(medioPago);

            factura.medios_de_pago = medioPago.pagoId;

            RepositorioFactura.Instance.AlmacenarFactura(factura);

            foreach (Facturable facturable in Facturables)
            {
                facturable.facturaId = factura.id_fatcura;
                ItemFactura item = new ItemFactura(facturable.cantidad, facturable.montoPorUnidad,
                    facturable.facturaId, facturable.publicacionId);

                RepositorioFactura.Instance.GuardarItem(item);

                total += (facturable.cantidad * facturable.montoPorUnidad);
            }

            factura.total = total;

            RepositorioFactura.Instance.ActualizarMontoFactura(factura);
        }

        private void buscarBoton_Click(object sender, EventArgs e)
        {
            if (this.cantidadTextBox.Text != "" && this.cantidadTextBox.Text != "0")
                PopularGrilla();
            else
                MessageBox.Show("Debe ingresar una cantidad a Facturar", "Atención", MessageBoxButtons.OK);

            if (Facturables.Count == 0)
            {
                MessageBox.Show("Usted no posee items para Facturar.", "Reporte", MessageBoxButtons.OK);
                this.facturarBoton.Visible = false;
            }
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.soloEscribeNumeros(e);
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                MessageBox.Show("Solo puede ingresar números.", "Atención", MessageBoxButtons.OK);
        }
    }
}
