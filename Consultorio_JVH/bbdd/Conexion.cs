using Consultorio_JVH.Modelo;
using Consultorio_JVH.Utilidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace Consultorio_JVH.bbdd
{
    internal class Conexion
    {
        private static readonly string url = "Server=145.14.151.1;" +
      "Database=u812167471_consultorio25;" +
      "User=u812167471_consultorio25;" +
      "port=3306;" +
      "password=2025-Consultorio;" +
      "Convert Zero Datetime=True";

        public static bool Acceder(string user, string pass)
        {
            string consulta = "select usuario, contrasenya from personal where usuario=?usuario and contrasenya=?contrasenya";
            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?usuario", user);
                command.Parameters.AddWithValue("?contrasenya", pass);

                using (MySqlDataReader resultados = command.ExecuteReader())
                {
                    return resultados.HasRows;
                }
            }
        }

        public static string[] RescataDatosUserLogado(string user)
        {
            string[] datos = new string[3];
            string consulta = "select concat(nombre, ' ', apellidos), numero_colegiado, tipo from personal where usuario=?usuario";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?usuario", user);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        datos[0] = reader.GetString(0);
                        datos[1] = reader.GetInt32(1).ToString();
                        datos[2] = reader.GetString(2);
                    }
                }
            }
            return datos;
        }

        public static DataTable CargarCitas()
        {
            DataTable dt = new DataTable();
            string consulta = "select nombre, dia, hora from citas where dia = ?dia";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?dia", DateTime.Today.ToString("yyyy-dd-MM"));

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);

                dt.Columns[0].ColumnName = "NOMBRE";
                dt.Columns[1].ColumnName = "DIA";
                dt.Columns[2].ColumnName = "HORA";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["NOMBRE"] = Encriptado.Desencriptar(dt.Rows[i]["NOMBRE"].ToString());
                }
            }
            return dt;
        }

        public static bool CompruebaDni(string dni)
        {
            string consulta = "select dni from paciente where dni=?dni";
            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?dni", dni);

                using (MySqlDataReader resultados = command.ExecuteReader())
                {
                    return resultados.HasRows;
                }
            }
        }

        public static string[] RescatarDatosPaciente(string dni)
        {
            string[] datos = new string[4];
            string consulta = "SELECT nombre, apellidos, telefono, email FROM paciente WHERE dni=?dni";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?dni", dni);

                using (MySqlDataReader resultados = command.ExecuteReader())
                {
                    if (resultados.Read())
                    {
                        datos[0] = resultados.GetString(0);
                        datos[1] = resultados.GetString(1);
                        datos[2] = resultados.GetInt32(2).ToString();
                        datos[3] = resultados.GetString(3);
                    }
                }
            }
            return datos;
        }

        public static void CargarCombo(ComboBox cb)
        {
            string consulta = "SELECT codigopostal from codigospostales";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                DataTable dt = new DataTable();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "codigopostal";
                cb.ValueMember = "codigopostal";
            }
        }

        public static DataTable VerHistorial(string dni)
        {
            DataTable dt = new DataTable();
            string consulta = "select fechaConsulta, diagnostico, tratamiento, observaciones, codigofacultativo from consultas where dniPaciente = ?dniPaciente";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?dniPaciente", dni);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);

                dt.Columns[0].ColumnName = "Fecha Consulta";
                dt.Columns[1].ColumnName = "Diagnostico";
                dt.Columns[2].ColumnName = "Tratamiento";
                dt.Columns[3].ColumnName = "Observaciones";
                dt.Columns[4].ColumnName = "Codigo Facultativo";
            }
            return dt;
        }

        public static DataTable VerHistorialEnfermeria(string dni)
        {
            DataTable dt = new DataTable();
            string consulta = "select fechaConsulta, tensionMax, tensionMin, glucosa, peso, codigofacultativo from enfermeria where dniPaciente = ?dniPaciente";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?dniPaciente", dni);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);

                dt.Columns[0].ColumnName = "Fecha Consulta";
                dt.Columns[1].ColumnName = "Tension Maxima";
                dt.Columns[2].ColumnName = "Tension Minima";
                dt.Columns[3].ColumnName = "Glucosa";
                dt.Columns[4].ColumnName = "Peso";
                dt.Columns[5].ColumnName = "Codigo Facultativo";
            }
            return dt;
        }

        public static bool RegistrarConsulta(Consulta c)
        {
            string registro = "Insert into consultas(dniPaciente, fechaConsulta, diagnostico, tratamiento, observaciones, codigofacultativo) " +
                "Values (?dniPaciente, ?fechaConsulta, ?diagnostico, ?tratamiento, ?observaciones, ?codigofacultativo)";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(registro, conn);

                command.Parameters.AddWithValue("?dniPaciente", Encriptado.Encriptar(c.DniPaciente));
                command.Parameters.AddWithValue("?fechaConsulta", c.FechaConsulta);
                command.Parameters.AddWithValue("?diagnostico", c.Diagnostico);
                command.Parameters.AddWithValue("?tratamiento", c.Tratamiento);
                command.Parameters.AddWithValue("?observaciones", c.Observaciones);
                command.Parameters.AddWithValue("?codigofacultativo", c.CodigoFacultativo);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool RegistrarPaciente(Paciente p)
        {
            string registro = "Insert into paciente(dni, nombre, apellidos, fechaNacimiento, telefono, email, cp, sexo, tabaquismo, consumoAlcohol, antecedentesSalud, datosSaludGeneral, fechaRegistro) " +
                "Values (?dni, ?nombre, ?apellidos, ?fechaNacimiento, ?telefono, ?email, ?cp, ?sexo, ?tabaquismo, ?consumoAlcohol, ?antecedentesSalud, ?datosSaludGeneral, ?fechaRegistro)";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(registro, conn);

                command.Parameters.AddWithValue("?dni", Encriptado.Encriptar(p.Dni));
                command.Parameters.AddWithValue("?nombre", Encriptado.Encriptar(p.Nombre));
                command.Parameters.AddWithValue("?apellidos", Encriptado.Encriptar(p.Ape));
                command.Parameters.AddWithValue("?fechaNacimiento", p.FechaNacimiento.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("?telefono", p.Telf);
                command.Parameters.AddWithValue("?email", p.Mail);
                command.Parameters.AddWithValue("?cp", p.Cp);
                command.Parameters.AddWithValue("?sexo", p.Sexo);
                command.Parameters.AddWithValue("?tabaquismo", p.Tabaquismo);
                command.Parameters.AddWithValue("?consumoAlcohol", p.ConsumoAlcohol);
                command.Parameters.AddWithValue("?antecedentesSalud", p.AntecedentesSalud1);
                command.Parameters.AddWithValue("?datosSaludGeneral", p.DatosSaludGeneral);
                command.Parameters.AddWithValue("?fechaRegistro", p.FechaRegistro.ToString("yyyy-MM-dd"));

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool RegistarCita(Cita c)
        {
            string registro = "Insert into citas(dniPaciente, nombre, dia, hora) Values (?dniPaciente, ?nombre, ?dia, ?hora)";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(registro, conn);

                command.Parameters.AddWithValue("?dniPaciente", Encriptado.Encriptar(c.DniPaciente));
                command.Parameters.AddWithValue("?nombre", Encriptado.Encriptar(c.NombrePaciente));
                command.Parameters.AddWithValue("?dia", c.Dia);
                command.Parameters.AddWithValue("?hora", c.Hora);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable ListadoPacientes()
        {
            DataTable dt = new DataTable();
            string consulta = "select dni, nombre, apellidos, telefono, cp from paciente";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);

                dt.Columns[0].ColumnName = "DNI";
                dt.Columns[1].ColumnName = "NOMBRE";
                dt.Columns[2].ColumnName = "APELLIDOS";
                dt.Columns[3].ColumnName = "TELEFONO";
                dt.Columns[4].ColumnName = "CP";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["DNI"] = Encriptado.Encriptar(dt.Rows[i]["DNI"].ToString());
                    dt.Rows[i]["NOMBRE"] = Encriptado.Encriptar(dt.Rows[i]["NOMBRE"].ToString());
                    dt.Rows[i]["APELLIDOS"] = Encriptado.Encriptar(dt.Rows[i]["APELLIDOS"].ToString());
                }
            }
            return dt;
        }

        public static bool RegistrarEnfermeria(Enfermeria e)
        {
            string registro = "Insert into enfermeria(fechaConsulta, dniPaciente, tensionMax, tensionMin, glucosa, peso, codigofacultativo) " +
                "Values (?fechaConsulta, ?dniPaciente, ?tensionMax, ?tensionMin, ?glucosa, ?peso, ?codigofacultativo)";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(registro, conn);

                command.Parameters.AddWithValue("?fechaConsulta", e.FechaConsulta);
                command.Parameters.AddWithValue("?dniPaciente", Encriptado.Encriptar(e.DniPaciente));
                command.Parameters.AddWithValue("?tensionMax", e.TensionMax);
                command.Parameters.AddWithValue("?tensionMin", e.TensionMin);
                command.Parameters.AddWithValue("?glucosa", e.Glucosa);
                command.Parameters.AddWithValue("?peso", e.Peso);
                command.Parameters.AddWithValue("?codigofacultativo", e.CodigoFacultativo);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool ActualizarPaciente(ArrayList datos)
        {
            string consulta = "UPDATE paciente SET nombre = ?nombre, apellidos = ?apellidos, telefono = ?telefono, cp = ?cp WHERE dni = ?dni";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);

                command.Parameters.AddWithValue("?dni", Encriptado.Encriptar(datos[0].ToString()));
                command.Parameters.AddWithValue("?nombre", Encriptado.Encriptar(datos[1].ToString()));
                command.Parameters.AddWithValue("?apellidos", Encriptado.Encriptar(datos[2].ToString()));
                command.Parameters.AddWithValue("?telefono", Convert.ToInt32(datos[3]));
                command.Parameters.AddWithValue("?cp", Convert.ToInt32(datos[4]));

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool RegistrarPersonal(Personal p)
        {
            string registro = "Insert into personal(numero_colegiado, nombre, apellidos, telefono, usuario, contrasenya, tipo) " +
                "Values (?numero_colegiado, ?nombre, ?apellidos, ?telefono, ?usuario, ?contrasenya, ?tipo)";

            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(registro, conn);

                command.Parameters.AddWithValue("?numero_colegiado", p.NumColegiado);
                command.Parameters.AddWithValue("?nombre", p.Nombre);
                command.Parameters.AddWithValue("?apellidos", p.Ape);
                command.Parameters.AddWithValue("?telefono", p.Telf);
                command.Parameters.AddWithValue("?usuario", p.Usu);
                command.Parameters.AddWithValue("?contrasenya", Encriptado.Encriptar(p.Pass));
                command.Parameters.AddWithValue("?tipo", p.Tipo);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool CompruebaUsuario(string user)
        {
            string consulta = "select usuario from personal where usuario=?usuario";
            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?usuario", user);

                using (MySqlDataReader resultados = command.ExecuteReader())
                {
                    return resultados.HasRows;
                }
            }
        }

        public static bool CompruebaNumeroColegiado(long num)
        {
            string consulta = "select numero_colegiado from personal where numero_colegiado=?numero_colegiado";
            using (MySqlConnection conn = new MySqlConnection(url))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(consulta, conn);
                command.Parameters.AddWithValue("?numero_colegiado", num);

                using (MySqlDataReader resultados = command.ExecuteReader())
                {
                    return resultados.HasRows;
                }
            }
        }
    }
}
