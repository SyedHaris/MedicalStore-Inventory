namespace MedicalStoreInventory
{
    partial class Add_Manufacturer
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
            this.adm_tb1 = new System.Windows.Forms.TextBox();
            this.admtb2 = new System.Windows.Forms.TextBox();
            this.admbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // adm_tb1
            // 
            this.adm_tb1.Location = new System.Drawing.Point(95, 42);
            this.adm_tb1.Name = "adm_tb1";
            this.adm_tb1.Size = new System.Drawing.Size(100, 20);
            this.adm_tb1.TabIndex = 2;
            this.adm_tb1.TextChanged += new System.EventHandler(this.adm_tb1_TextChanged);
            // 
            // admtb2
            // 
            this.admtb2.Location = new System.Drawing.Point(95, 94);
            this.admtb2.Name = "admtb2";
            this.admtb2.Size = new System.Drawing.Size(100, 20);
            this.admtb2.TabIndex = 3;
            this.admtb2.TextChanged += new System.EventHandler(this.admtb2_TextChanged);
            // 
            // admbtn
            // 
            this.admbtn.Location = new System.Drawing.Point(95, 149);
            this.admbtn.Name = "admbtn";
            this.admbtn.Size = new System.Drawing.Size(75, 23);
            this.admbtn.TabIndex = 4;
            this.admbtn.Text = "Add";
            this.admbtn.UseVisualStyleBackColor = true;
            this.admbtn.Click += new System.EventHandler(this.admbtn_Click);
            // 
            // Add_Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 193);
            this.Controls.Add(this.admbtn);
            this.Controls.Add(this.admtb2);
            this.Controls.Add(this.adm_tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Manufacturer";
            this.Text = "Add_Manufacturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adm_tb1;
        private System.Windows.Forms.TextBox admtb2;
        private System.Windows.Forms.Button admbtn;
    }
}