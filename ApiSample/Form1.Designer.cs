namespace ApiSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxSzuro = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonMégse = new System.Windows.Forms.Button();
            this.buttonPlusz = new System.Windows.Forms.Button();
            this.buttonMinusz = new System.Windows.Forms.Button();
            this.textBoxJelenleg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSzerkeszt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxRaktar = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSzuro
            // 
            this.textBoxSzuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(171)))));
            this.textBoxSzuro.ForeColor = System.Drawing.Color.White;
            this.textBoxSzuro.Location = new System.Drawing.Point(18, 186);
            this.textBoxSzuro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSzuro.Name = "textBoxSzuro";
            this.textBoxSzuro.Size = new System.Drawing.Size(148, 40);
            this.textBoxSzuro.TabIndex = 1;
            this.textBoxSzuro.TextChanged += new System.EventHandler(this.textBoxSzuro_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(171)))));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(1031, 445);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(112, 34);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonMégse
            // 
            this.buttonMégse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(171)))));
            this.buttonMégse.ForeColor = System.Drawing.Color.White;
            this.buttonMégse.Location = new System.Drawing.Point(1151, 445);
            this.buttonMégse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMégse.Name = "buttonMégse";
            this.buttonMégse.Size = new System.Drawing.Size(112, 34);
            this.buttonMégse.TabIndex = 3;
            this.buttonMégse.Text = "Mégse";
            this.buttonMégse.UseVisualStyleBackColor = false;
            this.buttonMégse.Click += new System.EventHandler(this.buttonMégse_Click);
            // 
            // buttonPlusz
            // 
            this.buttonPlusz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(171)))));
            this.buttonPlusz.ForeColor = System.Drawing.Color.White;
            this.buttonPlusz.Location = new System.Drawing.Point(1209, 313);
            this.buttonPlusz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPlusz.Name = "buttonPlusz";
            this.buttonPlusz.Size = new System.Drawing.Size(54, 34);
            this.buttonPlusz.TabIndex = 4;
            this.buttonPlusz.Text = "+";
            this.buttonPlusz.UseVisualStyleBackColor = false;
            this.buttonPlusz.Click += new System.EventHandler(this.buttonPlusz_Click);
            // 
            // buttonMinusz
            // 
            this.buttonMinusz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(171)))));
            this.buttonMinusz.ForeColor = System.Drawing.Color.White;
            this.buttonMinusz.Location = new System.Drawing.Point(1147, 313);
            this.buttonMinusz.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinusz.Name = "buttonMinusz";
            this.buttonMinusz.Size = new System.Drawing.Size(54, 34);
            this.buttonMinusz.TabIndex = 5;
            this.buttonMinusz.Text = "-";
            this.buttonMinusz.UseVisualStyleBackColor = false;
            this.buttonMinusz.Click += new System.EventHandler(this.buttonMinusz_Click);
            // 
            // textBoxJelenleg
            // 
            this.textBoxJelenleg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(171)))));
            this.textBoxJelenleg.ForeColor = System.Drawing.Color.White;
            this.textBoxJelenleg.Location = new System.Drawing.Point(1190, 222);
            this.textBoxJelenleg.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJelenleg.Name = "textBoxJelenleg";
            this.textBoxJelenleg.Size = new System.Drawing.Size(73, 40);
            this.textBoxJelenleg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(911, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jelenleg ennyi termék van készletem:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(911, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Termékkészlet szerkesztése:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxSzerkeszt
            // 
            this.textBoxSzerkeszt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(171)))));
            this.textBoxSzerkeszt.ForeColor = System.Drawing.Color.White;
            this.textBoxSzerkeszt.Location = new System.Drawing.Point(1190, 265);
            this.textBoxSzerkeszt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSzerkeszt.Name = "textBoxSzerkeszt";
            this.textBoxSzerkeszt.Size = new System.Drawing.Size(73, 40);
            this.textBoxSzerkeszt.TabIndex = 9;
            this.textBoxSzerkeszt.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSzerkeszt_Validating);
            this.textBoxSzerkeszt.Validated += new System.EventHandler(this.textBoxSzerkeszt_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Termékszűrés:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(182, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Raktárkészlet:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBoxRaktar
            // 
            this.listBoxRaktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(96)))), ((int)(((byte)(20)))));
            this.listBoxRaktar.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxRaktar.ForeColor = System.Drawing.Color.Black;
            this.listBoxRaktar.FormattingEnabled = true;
            this.listBoxRaktar.ItemHeight = 38;
            this.listBoxRaktar.Location = new System.Drawing.Point(186, 163);
            this.listBoxRaktar.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRaktar.Name = "listBoxRaktar";
            this.listBoxRaktar.Size = new System.Drawing.Size(673, 346);
            this.listBoxRaktar.TabIndex = 12;
            this.listBoxRaktar.SelectedIndexChanged += new System.EventHandler(this.listBoxRaktar_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1731, 83);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 1016);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1731, 83);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1730, 1096);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxRaktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSzerkeszt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJelenleg);
            this.Controls.Add(this.buttonMinusz);
            this.Controls.Add(this.buttonPlusz);
            this.Controls.Add(this.buttonMégse);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxSzuro);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxSzuro;
        public System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.Button buttonMégse;
        public System.Windows.Forms.Button buttonPlusz;
        public System.Windows.Forms.Button buttonMinusz;
        public System.Windows.Forms.TextBox textBoxJelenleg;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxSzerkeszt;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox listBoxRaktar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
    }
}