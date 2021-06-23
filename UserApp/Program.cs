using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using kv;
using Newtonsoft.Json;

namespace UserApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = Environment.CurrentDirectory + @"\..\..\..\kv\Documents\data.json";
            List<Data> data = new List<Data>();
            data = DeserializeJson(path);
            if (data == null || data.Count == 0)
                Application.Run(new FormNoEvents());
            else
                Application.Run(new FormEvents());
        }

        private static List<Data> DeserializeJson(string path) //Десериализация
        {
            StreamReader sr = new StreamReader(path);
            List<Data> data = new List<Data>();
            string file = sr.ReadToEnd();
            sr.Close();
            data = JsonConvert.DeserializeObject<List<Data>>(file);
            return data;
        }
    }
}
