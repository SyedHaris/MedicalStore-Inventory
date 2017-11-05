namespace MedicalStoreInventory
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.teltb = new System.Windows.Forms.TextBox();
            this.adtb = new System.Windows.Forms.RichTextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADDRESS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "TEL:";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(133, 31);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(100, 20);
            this.nametb.TabIndex = 3;
            this.nametb.TextChanged += new System.EventHandler(this.nametb_TextChanged);
            // 
            // teltb
            // 
            this.teltb.Location = new System.Drawing.Point(133, 74);
            this.teltb.Name = "teltb";
            this.teltb.Size = new System.Drawing.Size(100, 20);
            this.teltb.TabIndex = 5;
            this.teltb.TextChanged += new System.EventHandler(this.teltb_TextChanged);
            // 
            // adtb
            // 
            this.adtb.Location = new System.Drawing.Point(133, 120);
            this.adtb.Name = "adtb";
            this.adtb.Size = new System.Drawing.Size(100, 96);
            this.adtb.TabIndex = 6;
            this.adtb.Text = "";
            this.adtb.TextChanged += new System.EventHandler(this.adtb_TextChanged);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(133, 270);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 7;
            this.button12.Text = "button1";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 334);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.adtb);
            this.Controls.Add(this.teltb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox teltb;
        private System.Windows.Forms.RichTextBox adtb;
        private System.Windows.Forms.Button button12;
    }
}