using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_JVH.Modelo
{
    internal class Paciente
    {
        private string dni;
        private string nombre;
        private string ape;
        private DateTime fechaNacimiento;
        private int telf;
        private string mail;
        private int cp;
        private string sexo;
        private string tabaquismo;
        private string consumoAlcohol;
        private string AntecedentesSalud;
        private string datosSaludGeneral;
        private DateTime fechaRegistro;

        public Paciente(string dni, string nombre, string ape, DateTime fechaNacimiento, int telf, string mail, int cp, string sexo, string tabaquismo, string consumoAlcohol, string antecedentesSalud, string datosSaludGeneral, DateTime fechaRegistro)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Ape = ape;
            this.FechaNacimiento = fechaNacimiento;
            this.Telf = telf;
            this.Mail = mail;
            this.Cp = cp;
            this.Sexo = sexo;
            this.Tabaquismo = tabaquismo;
            this.ConsumoAlcohol = consumoAlcohol;
            AntecedentesSalud1 = antecedentesSalud;
            this.DatosSaludGeneral = datosSaludGeneral;
            this.FechaRegistro = fechaRegistro;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ape { get => ape; set => ape = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Telf { get => telf; set => telf = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Cp { get => cp; set => cp = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Tabaquismo { get => tabaquismo; set => tabaquismo = value; }
        public string ConsumoAlcohol { get => consumoAlcohol; set => consumoAlcohol = value; }
        public string AntecedentesSalud1 { get => AntecedentesSalud; set => AntecedentesSalud = value; }
        public string DatosSaludGeneral { get => datosSaludGeneral; set => datosSaludGeneral = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
    }
}
