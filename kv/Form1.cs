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
        
        public Form1()
        {
            InitializeComponent();
        }

        public class Data 
        {
            public string tld { get; set; }
            public string time { get; set; }
            public string spon { get; set; }
            public string desc{ get; set; }
            public string lnk { get; set; }
            public string dir { get; set; }

            public Data() { }

            public Data(string Tld, string Time, string Spon, string Desc, string Link, string Dir)
            {
                tld = Tld;
                time = Time;
                spon = Spon;
                desc = Desc;
                lnk = Link;
                dir = Dir;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void savelog_Click(object sender, EventArgs e)
        {
            Save_Events();
        }

        void Save_Events()
        {
            List<Data> data = new List<Data>();

            data.AddRange(new Data[]
            {
                new Data(title.Text, time.Text, spon.Text, descript.Text, link.Text, direct.Text)
            });
            File.WriteAllText("data.json", string.Empty);
            File.AppendAllText("data.json", JsonConvert.SerializeObject(data));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Data> data = new List<Data>();
            JsonTextReader reader = new JsonTextReader(new StreamReader("data.json"));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                Data d_t = serializer.Deserialize<Data>(reader);
                data.Add(d_t);
            }
            for (int i = 0; i < data.Count; i++)
                listView1.Columns.Add(data[i].tld, 100, HorizontalAlignment.Center);

            // listView1.Columns.Add("Aa", 100, HorizontalAlignment.Center);
        }
    }
}
