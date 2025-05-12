using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_JVH.Modelo
{
    internal class Cita
    {
        string dniPaciente;
        string nombrePaciente;
        DateTime dia;
        double hora;

        public Cita(string dniPaciente, string nombrePaciente, DateTime dia, double hora)
        {
            this.DniPaciente = dniPaciente;
            this.NombrePaciente = nombrePaciente;
            this.Dia = dia;
            this.Hora = hora;
        }

        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public double Hora { get => hora; set => hora = value; }


        public override string ToString()
        {
            return "<h2>----------Datos de la cita----------</h2><br/>" +
                "Dni del paciente: <b>" + this.dniPaciente + "</b><br/>" +
                "Nombre: <b>" + this.nombrePaciente + "</b><br/>" +
                "Día: <b>" + this.dia.ToString("dd-MMMM-yyyy") + "</b><br/>" +
                "Hora: <b>" + this.hora.ToString("F2") + "</b><br/>" +
                "<h2>------------------------------------</h2><br/>" +
                "<img src=http://reynaldomd.com/firmacorreo/firmacorreo.png>" +
                "<br/><br/><p>Has recibido este email porque has solicitado una cita en el centro medico. Por favor, no responda a este correo electronico. Ha sido generado automaticamente.</p>";



        }
    }
}
