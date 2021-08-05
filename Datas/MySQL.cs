using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data
{
    public class MySQL
    {

        private static MySqlConnection M_Connection = null;

        public static bool Initialize(bool bIsStartup = true)
        {
            // TODO_GITHUB: debes configurar las siguientes variables / variables de entorno en la información de conexión de tu base de datos de GAME
            string[] gameSettings = new string[] {
               "127.0.0.1",//0
               "restaurante",//1
               "root",//2
               "",//3
               "3306"//4
            };

            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                M_Connection = new MySqlConnection($"Server={gameSettings[0]}; database={gameSettings[1]}; UID={gameSettings[2]}; password={gameSettings[3]}; port={gameSettings[4]}; ConvertZeroDateTime=True; ConnectionTimeout=10");
                M_Connection.Open();
                //MessageBox.Show("MYSQL inicializado");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    // These are partially useless since MySQL tends to not throw these properly half the time
                    case 0:
                        MessageBox.Show("Falló la conexión de MySQL. No se puede conectar con el servidor.");
                        break;
                    case 1:
                        MessageBox.Show("Falló la conexión de MySQL. Usuario / contraseña invalida.");
                        break;
                    case 1042:
                       MessageBox.Show("Falló la conexión de MySQL. Tiempo de conexión agotado.");
                        break;
                }

                if (bIsStartup)
                {
                    Environment.Exit(1);
                }

                return false;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Falló la conexión de MySQL. Cadena de conexión potencialmente malformada.");
                Environment.Exit(1);
                return false;
            }
        }

        public static DataTable EjecutarConsultaConResultado(string consulta, Dictionary<string, object> parametros = null)
        {
            try
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, M_Connection))
                {
                    if (parametros != null)
                    {
                        foreach (KeyValuePair<string, object> entrada in parametros)
                        {
                            comando.Parameters.AddWithValue(entrada.Key, entrada.Value);
                        }
                    }

                    using (MySqlDataReader lectorDatos = comando.ExecuteReader())
                    {
                        DataTable resultado = new DataTable();
                        resultado.Load(lectorDatos);
                        lectorDatos.Close();
                        return resultado;
                    }
                }
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show($"{excepcion}", "MySqlException");

                return null;
            }
        }

        public static DataTable EjecutarConsultaConResultadoV2(string consulta, object[] parametros = null)
        {
            try
            {
                DataTable resultado = new DataTable();
                MySqlCommand command = new MySqlCommand(consulta, M_Connection);
                if (parametros != null)
                {
                    string[] listPara = consulta.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {

                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parametros[i]);
                            i++;
                        }
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(resultado);
                return resultado;
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show($"{excepcion}", "MySqlException");
                return null;
            }
        }

        public static long EjecutarConsulta(string consulta, Dictionary<string, object> parametros = null)
        {
            try
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, M_Connection))
                {
                    if (parametros != null)
                    {
                        foreach (KeyValuePair<string, object> entrada in parametros)
                        {
                            comando.Parameters.AddWithValue(entrada.Key, entrada.Value);
                        }
                    }
                    comando.ExecuteNonQuery();
                    return comando.LastInsertedId;
                }
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show("ERROR MYSQL " + "No se pudo ejecutar la consulta (" + consulta +
                ") porque no se pudo contactar con el servidor MySql.");
                MessageBox.Show("ERROR MYSQL " + excepcion.Message);
                return -1;
            }
        }

        public static long EjecutarConsultaV2(string consulta, Dictionary<string, object> parametros = null)
        {
            try
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, M_Connection))
                {
                    if (parametros != null)
                    {
                        foreach (KeyValuePair<string, object> entrada in parametros)
                        {
                            comando.Parameters.AddWithValue(entrada.Key, entrada.Value);
                        }
                    }
                    return comando.ExecuteNonQuery();
                }
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show("ERROR MYSQL " + "No se pudo ejecutar la consulta (" + consulta +
                ") porque no se pudo contactar con el servidor MySql.");
                MessageBox.Show("ERROR MYSQL " + excepcion.Message);
                return -1;
            }
        }

        public static int EjecutarConsultaV3(string query, object[] parameter = null)
        {
            int data = 0;

            MySqlCommand command = new MySqlCommand(query, M_Connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();            

            return data;
        }

        public static void EscribirString(string tabla, string campo, string campoClave, object datoClave, string dato)
        {
            try
            {

                string consulta = "UPDATE " + tabla + " SET " + campo + " = ?dato WHERE " + campoClave + " = ?datoclave";
                using (MySqlCommand comando = new MySqlCommand(consulta, M_Connection))
                {
                    comando.Parameters.AddWithValue("?dato", dato);
                    comando.Parameters.AddWithValue("?datoclave", datoClave);
                    comando.ExecuteNonQuery();
                }
            }
            catch (MySqlException excepcion)
            {
                MessageBox.Show("ERROR MYSQL" + "No se pudo ejecutar la consulta (" +
                "UPDATE " + tabla + " SET " + campo + " = '" + dato + "' WHERE " + campoClave + " = '" + datoClave + "')" +
                " porque no se pudo contactar con el servidor MySql.");
                MessageBox.Show("ERROR MYSQL " + excepcion.Message);
            }

        }

        public static int ExecuteScalar(string query, object[] parameter = null)
        {
            int data = 0;

                MySqlCommand command = new MySqlCommand(query, M_Connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                try
                {
                    data = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {

                }
                return data;
        }

    }
}
