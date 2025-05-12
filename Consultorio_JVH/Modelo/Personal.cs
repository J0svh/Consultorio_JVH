using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_JVH.Modelo
{
    internal class Personal
    {
        private long numColegiado;
        private string nombre;
        private string ape;
        private int telf;
        private string usu;
        private string pass;
        private string tipo;

        public Personal(long numColegiado, string nombre, string ape, int telf, string usu, string pass, string tipo)
        {
            this.NumColegiado = numColegiado;
            this.Nombre = nombre;
            this.Ape = ape;
            this.Telf = telf;
            this.Usu = usu;
            this.Pass = pass;
            this.Tipo = tipo;
        }

        public long NumColegiado { get => numColegiado; set => numColegiado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ape { get => ape; set => ape = value; }
        public int Telf { get => telf; set => telf = value; }
        public string Usu { get => usu; set => usu = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Tipo { get => tipo; set => tipo = value; }


    }
}
