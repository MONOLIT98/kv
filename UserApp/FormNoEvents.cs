using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kv;
using Newtonsoft.Json;

namespace UserApp
{
    public partial class FormNoEvents : Form
    {
        string path = Environment.CurrentDirectory + @"\..\..\..\kv\Documents\data.json";
        List<Data> data = new List<Data>();

        public FormNoEvents()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            

        }

        private List<Data> DeserializeJson(string path) //Десериализация
        {
            StreamReader sr = new StreamReader(path);
            string file = sr.ReadToEnd();
            sr.Close();
            data = JsonConvert.DeserializeObject<List<Data>>(file);
            return data;
        }

    }
}
