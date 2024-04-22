using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApiSample
{
    public partial class Form1 : Form
    {
        List<Bicok> termeklista = new List<Bicok>();
        public Form1()
        {
            InitializeComponent();

            var snaps = proxy.ProductsFindAll();

            for (int i = 0; i < snaps.Content.Count; i++)
            {
                var prodinv = proxy.ProductInventoryFindForProduct(snaps.Content[i].Bvin);
                listBoxRaktar.Items.Add(snaps.Content[i].ProductName);
                Bicok b = new Bicok();
                b.id = i + 1;
                b.nev = snaps.Content[i].ProductName;
                b.keszlet = prodinv.Content[0].QuantityOnHand;
                b.inventory_id = prodinv.Content[0].Bvin;

                termeklista.Add(b);
            }
        }

        static string url = "http://20.234.113.211:8105/";
        static string key = "1-1593e0a7-8ad3-467c-a062-78c2613dafc3";

        Api proxy = new Api(url, key);

        private void BicoSzures()
        {
            List<string> szures = new List<string>();
            for (int i = 0; i < termeklista.Count; i++)
            {
                if (termeklista[i].nev.ToLower().StartsWith(textBoxSzuro.Text.ToLower()))
                {
                    szures.Add(termeklista[i].nev);
                }
            }

            listBoxRaktar.DataSource = szures;
        }

        private void textBoxSzuro_TextChanged(object sender, EventArgs e)
        {
            BicoSzures();
        }

        private void buttonPlusz_Click(object sender, EventArgs e)
        {
            var c = int.Parse(textBoxSzerkeszt.Text);
            c = c + 1;
            textBoxSzerkeszt.Text = c.ToString();
        }
    }
}
