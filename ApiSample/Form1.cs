using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ApiSample
{
    public partial class Form1 : Form
    {
        List<Bicok> termeklista = new List<Bicok>();
        
        //static string url = "http://20.234.113.211:8105/";
        //static string key = "1-1593e0a7-8ad3-467c-a062-78c2613dafc3";


        public Form1()
        {
            InitializeComponent();
            //buttonOK.Click += buttonOK_Click;

            //proxy = new Api(url, key);
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

        public void buttonPlusz_Click(object sender, EventArgs e)
        {
            var c = int.Parse(textBoxSzerkeszt.Text);
            c = c + 1;
            textBoxSzerkeszt.Text = c.ToString();
        }

        private void buttonMinusz_Click(object sender, EventArgs e)
        {
            var c = int.Parse(textBoxSzerkeszt.Text);
            c = c - 1;
            textBoxSzerkeszt.Text = c.ToString();
        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            var index = listBoxRaktar.SelectedIndex + 1;
            var activeBico = termeklista[index];
            var inv = proxy.ProductInventoryFind(activeBico.inventory_id).Content;
            inv.QuantityOnHand = int.Parse(textBoxSzerkeszt.Text);
            var valasz = proxy.ProductInventoryUpdate(inv);

            if (valasz != null)
            {
                termeklista[index].keszlet = inv.QuantityOnHand;

                textBoxSzerkeszt.Text = inv.QuantityOnHand.ToString();
                textBoxJelenleg.Text = textBoxSzerkeszt.Text;
                textBoxSzerkeszt.Clear();
            };

            
        }

        private void buttonMégse_Click(object sender, EventArgs e)
        {
            textBoxSzerkeszt.Clear();
            //textBoxSzerkeszt.Text = termeklista[listBoxRaktar.SelectedIndex + 1].keszlet.ToString();
            DialogResult result = MessageBox.Show("Biztos ki akarsz lépni a szerkesztésből?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }       
        }

        private void listBoxRaktar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex + 1;
            textBoxJelenleg.Text = (termeklista[index].keszlet).ToString();
            textBoxSzerkeszt.Text = (termeklista[index].keszlet).ToString();
            this.Refresh();
        }

        public bool CheckSzam(string name)
        {
            Regex regex = new Regex("^\\d+$");
            return regex.IsMatch(name);
        }

        private bool CheckNull(string data)
        {
            return !string.IsNullOrEmpty(data);
        }


        private void textBoxSzerkeszt_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckSzam(textBoxSzerkeszt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSzerkeszt, "Töltsd ki helyesen a mezőt!");
            }

            if (!CheckNull(textBoxSzerkeszt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSzerkeszt, "Ne hagyd üresen a mezőt te butus!");
            }
        }

        private void textBoxSzerkeszt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxSzerkeszt, "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
