using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_JVH.Modelo
{
    internal class Consulta
    {
        private string dniPaciente;
        private DateTime fechaConsulta;
        private string diagnostico;
        private string tratamiento;
        private string observaciones;
        private int codigoFacultativo;

        public Consulta(string dniPaciente, DateTime fechaConsulta, string diagnostico, string tratamiento, string observaciones, int codigoFacultativo)
        {
            this.DniPaciente = dniPaciente;
            this.FechaConsulta = fechaConsulta;
            this.Diagnostico = diagnostico;
            this.Tratamiento = tratamiento;
            this.Observaciones = observaciones;
            this.CodigoFacultativo = codigoFacultativo;
        }

        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public DateTime FechaConsulta { get => fechaConsulta; set => fechaConsulta = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int CodigoFacultativo { get => codigoFacultativo; set => codigoFacultativo = value; }


    }
}
