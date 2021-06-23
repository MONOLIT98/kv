using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace kv
{
    public partial class FormEdit : Form
    {
        int selected;
        string path = Environment.CurrentDirectory + @"\..\..\Documents\data.json";

        public FormEdit(int ind)
        {
            InitializeComponent();
            selected = ind;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Data item = new Data(titleEdit.Text, timeEdit.Text, sponEdit.Text, descriptEdit.Text, linkEdit.Text, directEdit.Text);
            StreamReader sr = new StreamReader(path);
            string file = sr.ReadToEnd();
            sr.Close();
            List<Data> data = JsonConvert.DeserializeObject<List<Data>>(file);
            data.Remove(data[selected]);
            data.Insert(selected, item);
            File.WriteAllText(path, string.Empty);
            File.AppendAllText(path, JsonConvert.SerializeObject(data));
            Close();
        }
    }
}
