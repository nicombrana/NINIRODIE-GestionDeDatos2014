using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FrbaCommerce.ClasesNINIRODIE
{
    class Validador
    {

        public static bool estaVacio(Control Box, Label Error, string nombre, ref bool todoBien)
        {
            if (Box.Text.Replace(" ", "") == "")
            {
                Error.Text += "El " + nombre + " no puede estar vacio";
                return !(todoBien = false);
            }
            return false;
        }
        public static bool estaVacio(string valor)
        {
            if (valor.Replace(" ", "") == "")
            {
                return true;
            }
            return false;
        }

        public static bool soloNumeros(Control Box, Label Error, string nombre, ref bool todoBien) 
        {
            int num;
            string valor = (Box.Text.Count(c => c == '.') == 1) ? Box.Text.Replace(".", "") : Box.Text;
            if (!int.TryParse(valor, out num) || Regex.IsMatch((valor.StartsWith("-")) ? valor.Substring(1) : valor, "\\D"))
            {
                Error.Text += "El " + nombre + " solo puede contener numeros";
                return (todoBien = false);
            }            
            return true;
        }
        public static bool soloNumeros(string val)
        {
            int num;
            string valor = (val.Count(c => c == '.') == 1) ? val.Replace(".", "") : val;
            if (!int.TryParse(valor, out num) || Regex.IsMatch((valor.StartsWith("-")) ? valor.Substring(1) : valor, "\\D"))
            {
                return false;
            }
            return true;
        }

        public static bool soloLetras(Control Box, Label Error, string nombre, ref bool todoBien)
        {
            if (Regex.IsMatch(Box.Text, "\\d") || Regex.IsMatch(Box.Text.Replace(" ",""),"\\W"))
            {
                Error.Text += "El " + nombre + " solo puede contener letras";
                return (todoBien = false);
            }
            return true;
        }
        public static bool soloLetras(string valor)
        {
            if (Regex.IsMatch(valor, "\\d") || Regex.IsMatch(valor.Replace(" ", ""), "\\W"))
            {
                return false;
            }
            return true;
        }

        public static bool tieneSeleccion(ComboBox Cbox, Label Error, string nombre, ref bool todoBien)
        {
            if (Cbox.SelectedIndex == -1)
            {
                Error.Text = "Debe seleccionar un item para " + nombre;
                return (todoBien = false);
            }
            return true;
        }

        public static bool telefonoValido(Control telBox, Label telError, ref bool todoBien)
        {
            if (!Validador.estaVacio(telBox, telError, "telefono", ref todoBien))
            {
                if (telBox.Text.Count(c => c == '-') > 1)
                {
                    telError.Text = "Solo puede usarse un guión medio";
                    return (todoBien = false);
                }
                else
                {
                    //Para no modificar el metodo solo numeros, hacemos un clon que remueva el -.
                    TextBox telClon = new TextBox();
                    telClon.Text = telBox.Text.Replace("-", "");
                    return Validador.soloNumeros(telClon, telError, "telefono", ref todoBien);
                }
            }
            else
            {
                return false;
            }
        }

        public static bool emailValido(Control emailBox, Label emailError, ref bool todoBien)
        {
            string email = emailBox.Text;

            if (email.Replace(" ", "") != "")
            {
                if (!email.Contains("@"))
                {
                    emailError.Text = "El mail no tiene @";
                    return (todoBien = false);
                }
                else if (!email.Contains("."))
                {
                    emailError.Text = "El mail no tiene .";
                    return (todoBien = false);
                }
                else
                {
                    string strTest = "";
                    foreach (var match in Regex.Matches(email, "\\W"))
                    {
                        strTest = match.ToString();
                        if (strTest != "." && strTest != "-" && strTest != "_" && strTest != " " && strTest != "@")
                        {
                            emailError.Text = "El mail posee caracteres no válidos";
                            return (todoBien = false);
                        }
                    }
                    if (email.Count(c => c == '@') > 1)
                    {
                        emailError.Text = "El mail posee caracteres no válidos";
                        return (todoBien = false);
                    }

                    int arroba = email.IndexOf('@'), punto = email.IndexOf('.');

                    if (email.Substring(arroba).Count(c => c == '.') != 1)
                    {
                        emailError.Text = "No se encuentra un proveedor de mail";
                        return (todoBien = false);
                    }
                    else
                    {
                        strTest = "";
                        for (int C = arroba + 1, len = email.Length; C < len; C++)
                        {
                            if (C == punto)
                            {
                                if (Regex.IsMatch(strTest, "\\W|\\d"))
                                {
                                    emailError.Text = "El nombre del proveedor de mail no es válido";
                                    return (todoBien = false);
                                }
                                else
                                {
                                    strTest = "";
                                    for (int i = C; i < len; i++)
                                    {
                                        strTest += email[i];
                                    }
                                    if (strTest != ".com" && strTest != ".gov" && strTest != ".net" && strTest != ".edu" && strTest != ".org" && strTest != ".com.ar")
                                    {
                                        emailError.Text = "No puede reconocerse dominio del mail";
                                        return (todoBien = false);
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                strTest += email[C];
                            }
                        }
                    }
                }
            }
            else
            {
                emailError.Text = "El mail no puede estar vacio";
                return (todoBien = false);
            }

            return true;
        }

        public static void soloEscribeLetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void soloEscribeNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void noEscribeNada(KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
    }

