namespace MedicalStoreInventory
{
    partial class Form6
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
            this.label4 = new System.Windows.Forms.Label();
            this.form6btn = new System.Windows.Forms.Button();
            this.form6tb1 = new System.Windows.Forms.TextBox();
            this.form6tb4 = new System.Windows.Forms.TextBox();
            this.form6tb3 = new System.Windows.Forms.TextBox();
            this.form6tb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacturer ID:";
            // 
            // form6btn
            // 
            this.form6btn.Location = new System.Drawing.Point(69, 228);
            this.form6btn.Name = "form6btn";
            this.form6btn.Size = new System.Drawing.Size(75, 23);
            this.form6btn.TabIndex = 4;
            this.form6btn.Text = "button1";
            this.form6btn.UseVisualStyleBackColor = true;
            this.form6btn.Click += new System.EventHandler(this.form6btn_Click);
            // 
            // form6tb1
            // 
            this.form6tb1.Location = new System.Drawing.Point(105, 34);
            this.form6tb1.Name = "form6tb1";
            this.form6tb1.Size = new System.Drawing.Size(100, 20);
            this.form6tb1.TabIndex = 5;
            this.form6tb1.TextChanged += new System.EventHandler(this.form6tb1_TextChanged);
            // 
            // form6tb4
            // 
            this.form6tb4.Location = new System.Drawing.Point(105, 156);
            this.form6tb4.Name = "form6tb4";
            this.form6tb4.Size = new System.Drawing.Size(100, 20);
            this.form6tb4.TabIndex = 6;
            this.form6tb4.TextChanged += new System.EventHandler(this.form6tb4_TextChanged);
            // 
            // form6tb3
            // 
            this.form6tb3.Location = new System.Drawing.Point(105, 118);
            this.form6tb3.Name = "form6tb3";
            this.form6tb3.Size = new System.Drawing.Size(100, 20);
            this.form6tb3.TabIndex = 7;
            this.form6tb3.TextChanged += new System.EventHandler(this.form6tb3_TextChanged);
            // 
            // form6tb2
            // 
            this.form6tb2.Location = new System.Drawing.Point(105, 73);
            this.form6tb2.Name = "form6tb2";
            this.form6tb2.Size = new System.Drawing.Size(100, 20);
            this.form6tb2.TabIndex = 8;
            this.form6tb2.TextChanged += new System.EventHandler(this.form6tb2_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 296);
            this.Controls.Add(this.form6tb2);
            this.Controls.Add(this.form6tb3);
            this.Controls.Add(this.form6tb4);
            this.Controls.Add(this.form6tb1);
            this.Controls.Add(this.form6btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button form6btn;
        private System.Windows.Forms.TextBox form6tb1;
        private System.Windows.Forms.TextBox form6tb4;
        private System.Windows.Forms.TextBox form6tb3;
        private System.Windows.Forms.TextBox form6tb2;
    }
}