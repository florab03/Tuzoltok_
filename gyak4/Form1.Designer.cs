namespace gyak4
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
            buttonPlusz1 = new Button();
            buttonPlusz2 = new Button();
            SuspendLayout();
            // 
            // buttonPlusz1
            // 
            buttonPlusz1.Location = new Point(35, 83);
            buttonPlusz1.Name = "buttonPlusz1";
            buttonPlusz1.Size = new Size(75, 23);
            buttonPlusz1.TabIndex = 0;
            buttonPlusz1.Text = "+1";
            buttonPlusz1.UseVisualStyleBackColor = true;
            buttonPlusz1.Click += buttonPlusz1_Click;
            // 
            // buttonPlusz2
            // 
            buttonPlusz2.Location = new Point(146, 83);
            buttonPlusz2.Name = "buttonPlusz2";
            buttonPlusz2.Size = new Size(75, 23);
            buttonPlusz2.TabIndex = 1;
            buttonPlusz2.Text = "+2";
            buttonPlusz2.UseVisualStyleBackColor = true;
            buttonPlusz2.Click += buttonPlusz2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPlusz2);
            Controls.Add(buttonPlusz1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPlusz1;
        private Button buttonPlusz2;
    }
}