using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module
{

    
    public partial class Tablebooking : Form
    {

        List<Customer> ListCustomer = new List<Customer>();
        public Tablebooking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Draw9Table();
        }

        private void Draw9Table()
        {
            int table = 1;
                for(int i = 0; i < pnTable.RowCount; i++)
            {
                for (int j = 0; j < pnTable.ColumnCount; j++)
                {
                    Label lbltable = new Label();

                    lbltable.Text = table + "";
                    lbltable.AutoSize = false;
                    lbltable.Dock = DockStyle.Fill;
                    lbltable.TextAlign = ContentAlignment.MiddleCenter;
                    lbltable.BackColor = Color.White;

                    pnTable.Controls.Add(lbltable, i, j);

                    table++;




                    lbltable.Click +=Lbltable_Click;
                }
            }
        }

        private void Lbltable_Click(object sender, EventArgs e)
        {
            Label lbltable = sender as Label;
            if (lbltable.BackColor == Color.White)
            {
                lbltable.BackColor = Color.SkyBlue;
            }
            else if (lbltable.BackColor == Color.SkyBlue)
            {
                lbltable.BackColor = Color.White;
            }

            else if (lbltable.BackColor == Color.YellowGreen)
            {
                MessageBox.Show("Az asztal" + lbltable.Text + " foglalt.");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Vasarlo frm = new Vasarlo();

            if(frm.ShowDialog() == DialogResult.OK)
            {
               Customer cus = new Customer();
                cus.NameCustomer = frm.txtName.Text;
                cus.PhoneCustomer = frm.txtxPhone.Text;

                for (int i = 0; i < pnTable.Controls.Count; i++)
                {
                    Label lbltable = pnTable.Controls[i] as Label;
                    if (lbltable.BackColor == Color.SkyBlue)
                    {
                        lbltable.BackColor = Color.YellowGreen;
                        int table = int.Parse(lbltable.Text);
                        cus.table.Add(table);
                    }
                }
                lblPrice.Text = cus.Price + "Ft";
                ListCustomer.Add(cus);


                DisplayTotalMoneySys();
                DisplayCustomerOnListBox();



            }
        }



        private void DisplayTotalMoneySys()
        {
            double sum = 0;
            foreach (Customer cus in ListCustomer)
            {
                sum += cus.Price;
                lblTotalPrice.Text = sum + "Ft";
            }
        }


        private void DisplayCustomerOnListBox()
        {
            listBox1.Items.Clear();
            foreach (Customer cus in ListCustomer)
            {
                listBox1.Items.Add(cus);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 1)
            {
                Customer cus = listBox1.SelectedItem as Customer;
                lblPrice.Text = cus.Price + "Ft";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Customer cus = listBox1.SelectedItem as Customer;
            if (listBox1.SelectedIndex != -1)
            {
                for (int i = 0; i < pnTable.Controls.Count; i++)
                {
                    Label lbltable = pnTable.Controls[i] as Label;
                    int codeChair = int.Parse(lbltable.Text);
                    int flag = 0;
                    while (cus.table.Count > 0 && flag < cus.table.Count)
                    {
                        int orderedTable = cus.table[0];
                        if (codeChair == orderedTable)
                        {
                            lbltable.BackColor = Color.White;
                            cus.table.Remove(orderedTable);
                        }
                        flag++;
                    }
                }

                ListCustomer.Remove(cus);
                DisplayCustomerOnListBox();
                DisplayTotalMoneySys();
            }


            else
            {
                MessageBox.Show("Ki kell választanod valakit");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Biztosan kiakarsz lépni?",
                "Kérdés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
