namespace teszt_elokeszites
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxMegnevezes = new TextBox();
            textBoxCikkszam = new TextBox();
            textBoxMennyiseg = new TextBox();
            textBoxEgysegar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            raktarKeszletBindingSource2 = new BindingSource(components);
            raktarKeszletBindingSource = new BindingSource(components);
            buttonAdd = new Button();
            raktarKeszletBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raktarKeszletBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raktarKeszletBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)raktarKeszletBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBoxMegnevezes
            // 
            textBoxMegnevezes.Location = new Point(103, 130);
            textBoxMegnevezes.Name = "textBoxMegnevezes";
            textBoxMegnevezes.Size = new Size(258, 39);
            textBoxMegnevezes.TabIndex = 0;
            // 
            // textBoxCikkszam
            // 
            textBoxCikkszam.Location = new Point(411, 130);
            textBoxCikkszam.Name = "textBoxCikkszam";
            textBoxCikkszam.Size = new Size(221, 39);
            textBoxCikkszam.TabIndex = 1;
            // 
            // textBoxMennyiseg
            // 
            textBoxMennyiseg.Location = new Point(695, 130);
            textBoxMennyiseg.Name = "textBoxMennyiseg";
            textBoxMennyiseg.Size = new Size(242, 39);
            textBoxMennyiseg.TabIndex = 2;
            // 
            // textBoxEgysegar
            // 
            textBoxEgysegar.Location = new Point(1013, 130);
            textBoxEgysegar.Name = "textBoxEgysegar";
            textBoxEgysegar.Size = new Size(255, 39);
            textBoxEgysegar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 87);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 4;
            label1.Text = "Megnevezés:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 84);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 5;
            label2.Text = "Cikkszám:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(699, 92);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 6;
            label3.Text = "Mennyiség:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1013, 92);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 7;
            label4.Text = "Egységár (ár/db):";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.RosyBrown;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(105, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1301, 687);
            dataGridView1.TabIndex = 8;
            // 
            // raktarKeszletBindingSource2
            // 
            raktarKeszletBindingSource2.DataSource = typeof(RaktarKeszlet);
            // 
            // raktarKeszletBindingSource
            // 
            raktarKeszletBindingSource.DataSource = typeof(RaktarKeszlet);
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MediumSeaGreen;
            buttonAdd.Location = new Point(1330, 43);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(203, 191);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Hozzáadás";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // raktarKeszletBindingSource1
            // 
            raktarKeszletBindingSource1.DataSource = typeof(RaktarKeszlet);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1932, 1199);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEgysegar);
            Controls.Add(textBoxMennyiseg);
            Controls.Add(textBoxCikkszam);
            Controls.Add(textBoxMegnevezes);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)raktarKeszletBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)raktarKeszletBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)raktarKeszletBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMegnevezes;
        private TextBox textBoxCikkszam;
        private TextBox textBoxMennyiseg;
        private TextBox textBoxEgysegar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private BindingSource raktarKeszletBindingSource;
        private BindingSource raktarKeszletBindingSource2;
        private BindingSource raktarKeszletBindingSource1;
    }
}