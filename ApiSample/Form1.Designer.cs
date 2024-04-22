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
            this.SuspendLayout();
            // 
            // textBoxSzuro
            // 
            this.textBoxSzuro.Location = new System.Drawing.Point(62, 33);
            this.textBoxSzuro.Name = "textBoxSzuro";
            this.textBoxSzuro.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzuro.TabIndex = 1;
            this.textBoxSzuro.TextChanged += new System.EventHandler(this.textBoxSzuro_TextChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(814, 333);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonMégse
            // 
            this.buttonMégse.Location = new System.Drawing.Point(895, 333);
            this.buttonMégse.Name = "buttonMégse";
            this.buttonMégse.Size = new System.Drawing.Size(75, 23);
            this.buttonMégse.TabIndex = 3;
            this.buttonMégse.Text = "Mégse";
            this.buttonMégse.UseVisualStyleBackColor = true;
            this.buttonMégse.Click += new System.EventHandler(this.buttonMégse_Click);
            // 
            // buttonPlusz
            // 
            this.buttonPlusz.Location = new System.Drawing.Point(895, 172);
            this.buttonPlusz.Name = "buttonPlusz";
            this.buttonPlusz.Size = new System.Drawing.Size(36, 23);
            this.buttonPlusz.TabIndex = 4;
            this.buttonPlusz.Text = "+";
            this.buttonPlusz.UseVisualStyleBackColor = true;
            this.buttonPlusz.Click += new System.EventHandler(this.buttonPlusz_Click);
            // 
            // buttonMinusz
            // 
            this.buttonMinusz.Location = new System.Drawing.Point(934, 172);
            this.buttonMinusz.Name = "buttonMinusz";
            this.buttonMinusz.Size = new System.Drawing.Size(36, 23);
            this.buttonMinusz.TabIndex = 5;
            this.buttonMinusz.Text = "-";
            this.buttonMinusz.UseVisualStyleBackColor = true;
            this.buttonMinusz.Click += new System.EventHandler(this.buttonMinusz_Click);
            // 
            // textBoxJelenleg
            // 
            this.textBoxJelenleg.Location = new System.Drawing.Point(897, 80);
            this.textBoxJelenleg.Name = "textBoxJelenleg";
            this.textBoxJelenleg.Size = new System.Drawing.Size(73, 20);
            this.textBoxJelenleg.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jelenleg ennyi termék van készletem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Termékkészlet szerkesztése:";
            // 
            // textBoxSzerkeszt
            // 
            this.textBoxSzerkeszt.Location = new System.Drawing.Point(870, 137);
            this.textBoxSzerkeszt.Name = "textBoxSzerkeszt";
            this.textBoxSzerkeszt.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzerkeszt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Termékszűrés:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Raktárkészlet:";
            // 
            // listBoxRaktar
            // 
            this.listBoxRaktar.FormattingEnabled = true;
            this.listBoxRaktar.Location = new System.Drawing.Point(62, 93);
            this.listBoxRaktar.Name = "listBoxRaktar";
            this.listBoxRaktar.Size = new System.Drawing.Size(450, 407);
            this.listBoxRaktar.TabIndex = 12;
            this.listBoxRaktar.SelectedIndexChanged += new System.EventHandler(this.listBoxRaktar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 553);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSzuro;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonMégse;
        private System.Windows.Forms.Button buttonPlusz;
        private System.Windows.Forms.Button buttonMinusz;
        private System.Windows.Forms.TextBox textBoxJelenleg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSzerkeszt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxRaktar;
    }
}