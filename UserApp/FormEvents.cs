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
    public partial class FormEvents : Form
    {
        string path = Environment.CurrentDirectory + @"\..\..\..\kv\Documents\data.json";
        List<Data> data = new List<Data>();

        public FormEvents()
        {
            InitializeComponent();
        }

        private void FormEvents_Load(object sender, EventArgs e)
        {
            AddToList();
        }

        private void AddToList() //Добавление из json в ListView
        {
            data = DeserializeJson(path);
            if (data != null)
                for (int i = 0; i < data.Count; i++)
                {
                    var lv1 = new ListViewItem(new string[] { data[i].tld, data[i].time });
                    listView1.Items.Add(lv1);
                }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) // Показывает инфу про выбранный элемент
        {
            listView2.Items.Clear();
            if (listView1.SelectedIndices.Count > 0)
            {
                int selected = listView1.SelectedIndices[0];
                var list = listView1.Items[selected].SubItems;
                var sel = data.Select(x => x).Where(x => x.tld == list[0].Text && x.time == list[1].Text).ToList()[0];
                listView2.Items.AddRange(new ListViewItem[] {
                    new ListViewItem(sel.spon),
                    new ListViewItem(sel.desc),
                    new ListViewItem(sel.lnk),
                    new ListViewItem(sel.dir) });
            }
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
