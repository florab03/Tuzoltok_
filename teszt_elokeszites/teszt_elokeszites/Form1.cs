using System;
using System.Windows.Forms;


namespace teszt_elokeszites
{
    public partial class Form1 : Form
    {

        public RaktarKeszlet raktarKeszlet;
        public Form1()
        {
            InitializeComponent();
            raktarKeszlet = new RaktarKeszlet();
            Frissít();



        }
        private void Frissít()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = raktarKeszlet.RaktarLekerdezes();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string megnevezes = textBoxMegnevezes.Text;
            string cikkszam = textBoxCikkszam.Text;
            int mennyiseg = Convert.ToInt32(textBoxMennyiseg.Text);
            decimal egysegar = Convert.ToDecimal(textBoxEgysegar.Text);

            raktarKeszlet.UjTetelHozzaadasa(megnevezes, cikkszam, mennyiseg, egysegar);

            Frissít();


        }

        public void buttonUrites_Click(object sender, EventArgs e)
        {
            textBoxMegnevezes.Clear();
            textBoxCikkszam.Clear();
            textBoxMennyiseg.Clear();
            textBoxEgysegar.Clear();
        }
    }
}