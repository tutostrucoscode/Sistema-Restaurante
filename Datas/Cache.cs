using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    public class Cache
    {
        public static int SQLIDUsuario { get; set; }

        public static string Usuario { get; set; }

        public static string Password { get; set; }

        public static string Nombre { get; set; }

        public static string Apellido { get; set; }

        public static string Email { get; set; }

        public static int idcargo { get; set; }

        public static int Telefono { get; set; }

        public Dictionary<string, object> TempData = new Dictionary<string, object>();

        public void SetTempData(string key, object value)
        {
            if (TempData.ContainsKey(key))
                TempData[key] = value;
            else TempData.Add(key, value);
        }

        public void ResTempData(string key)
        {
            if (TempData.ContainsKey(key))
                TempData.Remove(key);
            //else MessageBox.Show($"No existe en la memoria: [{key}]");
        }

        public object GetTempData(string key)
        {
            if (TempData.ContainsKey(key))
                return TempData[key];
            else return null;
        }


        public static Dictionary<int, object> DataMesa = new Dictionary<int, object>();

        public static int NumeroMesas { get; set; }

        public static int NumeroMesasOcupadas { get; set; }

        public static int NumeroMesasLibres { get; set; }
    }
}
