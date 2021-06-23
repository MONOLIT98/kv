using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq

    ;
namespace kv
{
    public partial class Form1 : Form
    {
        List<Data> data = new List<Data>();
        string path = Environment.CurrentDirectory + @"\..\..\Documents\data.json";

        public Form1()
        {
            InitializeComponent();
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void savelog_Click(object sender, EventArgs e)
        {
            Save_Events();
        }

        void Save_Events() //Сериализация
        {
            if(data == null)
                data = new List<Data>();
            else if(data.Count > 0)
                data.AddRange(DeserializeJson(path));
            data.AddRange(new Data[]
            {
                new Data(title.Text, time.Text, spon.Text, descript.Text, link.Text, direct.Text)
            });
            File.WriteAllText(path, string.Empty);
            File.AppendAllText(path, JsonConvert.SerializeObject(data));
        }

        private List<Data> DeserializeJson(string path) //Десериализация
        {
            StreamReader sr = new StreamReader(path);
            string file = sr.ReadToEnd();
            sr.Close();
            data = JsonConvert.DeserializeObject<List<Data>>(file);
            return data;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            AddToList();
            
            // listView1.Columns.Add("Aa", 100, HorizontalAlignment.Center);
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

        private void buttonDelete_Click(object sender, EventArgs e) //Удаление 
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                int selected = listView1.SelectedIndices[0];
                Data item = new Data(
                    listView1.Items[selected].SubItems[0].Text,
                    listView1.Items[selected].SubItems[1].Text,
                    listView2.Items[0].Text,
                    listView2.Items[1].Text,
                    listView2.Items[2].Text,
                    listView2.Items[3].Text);
                var list = new List<Data>();
                foreach (var el in data)
                {
                    if (el.tld != item.tld && el.time != item.time)
                        list.Add(el);
                }
                //data = data.Select(x => x).Where(x => x.tld != item.tld && x.time != item.time).ToList();
                File.WriteAllText(path, string.Empty);
                File.AppendAllText(path, JsonConvert.SerializeObject(list));
                data = list;
                listView1.Items[selected].Remove();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int selected = listView1.SelectedIndices[0];                
                FormEdit fe = new FormEdit(selected);
                fe.ShowDialog();
                listView1.Items.Clear();
                AddToList();
            }
        }
    }
}
