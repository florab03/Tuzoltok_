namespace gyak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlusz1_Click(object sender, EventArgs e)
        {
            UjForm1 ujForm1 = new UjForm1();
            ujForm1.Show();
        }

        private void buttonPlusz2_Click(object sender, EventArgs e)
        {
            UjForm2 ujForm2 = new UjForm2();    
            ujForm2.Show();
        }
    }
}