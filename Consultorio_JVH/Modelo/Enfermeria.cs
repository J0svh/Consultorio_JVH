using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_JVH.Modelo
{
    internal class Enfermeria
    {
        private string dniPaciente;
        private DateTime fechaConsulta;
        private double tensionMax, tensionMin, glucosa, peso;
        private int codigoFacultativo;

        public Enfermeria(string dniPaciente, DateTime fechaConsulta, double tensionMax, double tensionMin, double glucosa, double peso, int codigoFacultativo)
        {
            this.DniPaciente = dniPaciente;
            this.FechaConsulta = fechaConsulta;
            this.TensionMax = tensionMax;
            this.TensionMin = tensionMin;
            this.Glucosa = glucosa;
            this.Peso = peso;
            this.CodigoFacultativo = codigoFacultativo;


        }

        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public double TensionMax { get => tensionMax; set => tensionMax = value; }
        public double TensionMin { get => tensionMin; set => tensionMin = value; }
        public double Glucosa { get => glucosa; set => glucosa = value; }
        public double Peso { get => peso; set => peso = value; }
        public int CodigoFacultativo { get => codigoFacultativo; set => codigoFacultativo = value; }


    }
}
