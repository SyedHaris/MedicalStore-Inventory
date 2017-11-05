namespace MedicalStoreInventory
{
    partial class Form5
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
            this.userpwd_tb = new System.Windows.Forms.TextBox();
            this.user_teltb = new System.Windows.Forms.TextBox();
            this.user_nametb = new System.Windows.Forms.TextBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.add_usertb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel NO.:";
            // 
            // userpwd_tb
            // 
            this.userpwd_tb.Location = new System.Drawing.Point(99, 25);
            this.userpwd_tb.Name = "userpwd_tb";
            this.userpwd_tb.Size = new System.Drawing.Size(100, 20);
            this.userpwd_tb.TabIndex = 4;
            this.userpwd_tb.TextChanged += new System.EventHandler(this.userpwd_tb_TextChanged);
            // 
            // user_teltb
            // 
            this.user_teltb.Location = new System.Drawing.Point(99, 111);
            this.user_teltb.Name = "user_teltb";
            this.user_teltb.Size = new System.Drawing.Size(100, 20);
            this.user_teltb.TabIndex = 6;
            this.user_teltb.TextChanged += new System.EventHandler(this.user_teltb_TextChanged);
            // 
            // user_nametb
            // 
            this.user_nametb.Location = new System.Drawing.Point(99, 66);
            this.user_nametb.Name = "user_nametb";
            this.user_nametb.Size = new System.Drawing.Size(100, 20);
            this.user_nametb.TabIndex = 7;
            this.user_nametb.TextChanged += new System.EventHandler(this.user_nametb_TextChanged);
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(99, 266);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 8;
            this.OK_btn.Text = "button1";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // add_usertb
            // 
            this.add_usertb.Location = new System.Drawing.Point(99, 157);
            this.add_usertb.Name = "add_usertb";
            this.add_usertb.Size = new System.Drawing.Size(100, 96);
            this.add_usertb.TabIndex = 9;
            this.add_usertb.Text = "";
            this.add_usertb.TextChanged += new System.EventHandler(this.add_usertb_TextChanged_1);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 311);
            this.Controls.Add(this.add_usertb);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.user_nametb);
            this.Controls.Add(this.user_teltb);
            this.Controls.Add(this.userpwd_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userpwd_tb;
        private System.Windows.Forms.TextBox user_teltb;
        private System.Windows.Forms.TextBox user_nametb;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.RichTextBox add_usertb;
    }
}