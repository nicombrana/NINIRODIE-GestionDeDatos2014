using System;
using System.Collections.Generic;
using System.Text;

namespace FrbaCommerce.NINIRODIE
{
    class SqlHelper
    {
        
        #region Propiedades
        // Fields

        private string dataBase;
        private string pass;
        private string server;
        private string user;

        // Properties

        public string DataBase
        {
            get { return this.dataBase; }
            set { this.dataBase = value; }
        }

        public string Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }

        public string Server
        {
            get { return this.server; }
            set { this.server = value; }
        }

        public string User
        {
            get { return this.user; }
            set { this.user = value; }
        }
        #endregion

        public SqlHelper(string Server, string DataBase, string User, string Pass)
        {
            //Constructor para cargar los datos de la base
            this.SetConfig(Server, DataBase, User, Pass);
        }

        public void SetConfig(string Server, string DataBase, string User, string Pass)
        {
            this.server = Server;
            this.dataBase = DataBase;
            this.user = User;
            this.pass = Pass;
        }

        public string GetConnString()
        {
            //devuelve los datos de la base en un unico string, para usar con otras clases
            return ("data source=" + this.server + ";initial catalog=" + this.dataBase + ";password=" + this.pass + ";persist security info=True;user id=" + this.user);
        }

    }

    }
}
