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
        public FormEdit(int ind)
        {
            InitializeComponent();
            selected = ind;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Data item = new Data(titleEdit.Text, timeEdit.Text, sponEdit.Text, descriptEdit.Text, linkEdit.Text, directEdit.Text);
            StreamReader sr = new StreamReader("data.json");
            string file = sr.ReadToEnd();
            sr.Close();
            List<Data> data = JsonConvert.DeserializeObject<List<Data>>(file);
            data.Remove(data[selected]);
            data.Insert(selected, item);
            File.WriteAllText("data.json", string.Empty);
            File.AppendAllText("data.json", JsonConvert.SerializeObject(data));
            Close();
        }
    }
}
