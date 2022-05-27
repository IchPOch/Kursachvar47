
namespace Kursachvar47
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVivod = new System.Windows.Forms.TextBox();
            this.textBoxVvod = new System.Windows.Forms.TextBox();
            this.radioButton2bit = new System.Windows.Forms.RadioButton();
            this.radioButton4bit = new System.Windows.Forms.RadioButton();
            this.radioButton6bit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "te";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxVivod
            // 
            this.textBoxVivod.Location = new System.Drawing.Point(214, 48);
            this.textBoxVivod.Name = "textBoxVivod";
            this.textBoxVivod.ReadOnly = true;
            this.textBoxVivod.Size = new System.Drawing.Size(177, 23);
            this.textBoxVivod.TabIndex = 1;
            // 
            // textBoxVvod
            // 
            this.textBoxVvod.Location = new System.Drawing.Point(59, 48);
            this.textBoxVvod.Name = "textBoxVvod";
            this.textBoxVvod.Size = new System.Drawing.Size(100, 23);
            this.textBoxVvod.TabIndex = 2;
            // 
            // radioButton2bit
            // 
            this.radioButton2bit.AutoSize = true;
            this.radioButton2bit.Checked = true;
            this.radioButton2bit.Location = new System.Drawing.Point(472, 48);
            this.radioButton2bit.Name = "radioButton2bit";
            this.radioButton2bit.Size = new System.Drawing.Size(45, 19);
            this.radioButton2bit.TabIndex = 3;
            this.radioButton2bit.TabStop = true;
            this.radioButton2bit.Text = "2bit";
            this.radioButton2bit.UseVisualStyleBackColor = true;
            this.radioButton2bit.Click += new System.EventHandler(this.radioButton2bit_Click);
            // 
            // radioButton4bit
            // 
            this.radioButton4bit.AutoSize = true;
            this.radioButton4bit.Location = new System.Drawing.Point(472, 73);
            this.radioButton4bit.Name = "radioButton4bit";
            this.radioButton4bit.Size = new System.Drawing.Size(45, 19);
            this.radioButton4bit.TabIndex = 4;
            this.radioButton4bit.Text = "4bit";
            this.radioButton4bit.UseVisualStyleBackColor = true;
            this.radioButton4bit.Click += new System.EventHandler(this.radioButton4bit_Click);
            // 
            // radioButton6bit
            // 
            this.radioButton6bit.AutoSize = true;
            this.radioButton6bit.Location = new System.Drawing.Point(472, 98);
            this.radioButton6bit.Name = "radioButton6bit";
            this.radioButton6bit.Size = new System.Drawing.Size(45, 19);
            this.radioButton6bit.TabIndex = 5;
            this.radioButton6bit.Text = "6bit";
            this.radioButton6bit.UseVisualStyleBackColor = true;
            this.radioButton6bit.Click += new System.EventHandler(this.radioButton6bit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton6bit);
            this.Controls.Add(this.radioButton4bit);
            this.Controls.Add(this.radioButton2bit);
            this.Controls.Add(this.textBoxVvod);
            this.Controls.Add(this.textBoxVivod);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVivod;
        private System.Windows.Forms.TextBox textBoxVvod;
        private System.Windows.Forms.RadioButton radioButton2bit;
        private System.Windows.Forms.RadioButton radioButton4bit;
        private System.Windows.Forms.RadioButton radioButton6bit;
    }
}

