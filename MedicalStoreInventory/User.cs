using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MedicalStoreInventory
{
    public partial class User : Form
    {
        String search, name, payment = "cash",name2;
        int custid,userid,quantity,bill_id,bill_id_tot,id2,id3,custid2,bill_id2;
        DateTime dt;
        float price,total,discount=0.0f,total2;
        public User()
        {

            InitializeComponent(); 
        }

        private void User_Load(object sender, EventArgs e)
        {
            //Login_Form lgf = new Login_Form();
            userid = DataBase.getid(Login_Form.pwd,"user");
            DataBase.update_llogin(userid);
            DataBase.user_info(ref idbox,ref telBox,ref addressbox,ref lloginbox,ref namelabel,Login_Form.pwd);
            DataBase.searchall(ref dataGridView2);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

      
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            search = searchbox.Text.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.itemsearch(search,ref dataGridView1);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.mfsearch(search,ref dataGridView1);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                DataBase.autocomp_source(ref auto);
                textBox1.AutoCompleteCustomSource = auto;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            total = (float)Convert.ToDouble(textBox3.Text.ToString());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            payment = textBox4.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text.ToString();
            quantity = Convert.ToInt32(textBox2.Text.ToString());
            if (DataBase.checkquantity(name, quantity))
            {
               
                DataBase.bill_detail(bill_id, name, quantity);
                try
                {
                    textBox1.ResetText();
                    textBox2.ResetText();
                }
                catch(Exception exp)
                {
                }
            }
            else
            {
                MessageBox.Show("Out of stock");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //custid = Convert.ToInt32(textBox6.Text.ToString());
        }

        private void label10_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            bill_id = DataBase.get_uniqueid();
            DataBase.createbill(bill_id,userid);
            textBox1.Enabled = textBox2.Enabled =button2.Enabled =button5.Enabled= true;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = textBox5.Enabled = button3.Enabled=button6.Enabled= true;
            DataBase.total(ref textBox3,bill_id);
            DataBase.makebill(bill_id,total,discount,payment);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            discount = (float)Convert.ToDouble(textBox5.Text.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(bill_id,total);
            f3.Show();
            textBox1.Enabled=textBox2.Enabled=button2.Enabled=button5.Enabled=button4.Enabled=textBox4.Enabled=textBox5.Enabled=false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataBase.del_bill(bill_id);
            MessageBox.Show("Bill deleted id: "+bill_id);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                bill_id_tot = Convert.ToInt32(textBox6.Text.ToString());
                DataBase.search_bill(bill_id_tot, ref dataGridView3, "id");
            }
            catch(Exception)
            {
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
            dateTimePicker1.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = dateTimePicker1.Enabled = false;
            try
            {
                DataBase.search_bill(ref dataGridView3, "id");
            }
            catch (Exception)
            {
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dt = Convert.ToDateTime(dateTimePicker1.Text.ToString());
            DataBase.search_bill(dt, ref dataGridView3, "id");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            textBox6.Enabled = false;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sort;
            sort = comboBox1.Text.ToString();
            switch (sort)
            {
                case "date":
                    {
                     if (radioButton3.Checked)
                            DataBase.search_bill(bill_id_tot, ref dataGridView3, "date");
                        else if (radioButton5.Checked)
                            DataBase.search_bill(ref dataGridView3, "date");
                        else
                            DataBase.search_bill(dt, ref dataGridView3, "date");
                        break;
                    }
                case "id":
                    {
                        if (radioButton3.Checked)
                            DataBase.search_bill(bill_id_tot, ref dataGridView3, "id");
                        else if (radioButton5.Checked)
                            DataBase.search_bill(ref dataGridView3, "id");
                        else
                            DataBase.search_bill(dt, ref dataGridView3, "id");
                        break;
                    }
                case "total":
                    {
                        if (radioButton3.Checked)
                            DataBase.search_bill(bill_id_tot, ref dataGridView3, "total");
                        else if (radioButton5.Checked)
                            DataBase.search_bill(ref dataGridView3, "total");
                        else
                            DataBase.search_bill(dt, ref dataGridView3, "total");
                        break;
                    }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bill_Detail bd = new Bill_Detail();
            bd.Show();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(id2,"Add");
            f4.Show();
            button8.Enabled = button9.Enabled = button10.Enabled = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            id2 = Convert.ToInt32(textBox7.Text.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button8.Enabled = button9.Enabled = button10.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(id2, "Update");
            f4.Show();
            button8.Enabled = button9.Enabled = button10.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataBase.del_cust(id2);
            MessageBox.Show("Customer deleted");
            button8.Enabled = button9.Enabled = button10.Enabled = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            idtb.Enabled = true;
            nametb.Enabled = false;
        }

        private void idtb_TextChanged(object sender, EventArgs e)
        {
            id3 = Convert.ToInt32(idtb.Text.ToString());
            DataBase.search_cust(id3,ref dataGridView4,"id");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            nametb.Enabled = true;
            idtb.Enabled = false;
        }

        private void nametb_TextChanged(object sender, EventArgs e)
        {
            name2 = nametb.Text.ToString();
            DataBase.search_cust(name2, ref dataGridView4, "id");
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sort;
            sort = cb2.Text.ToString();
            switch (sort)
            {
                case "name":
                    {
                        if (radioButton7.Checked)
                            DataBase.search_cust(id3, ref dataGridView4, "name");
                        else if (radioButton6.Checked)
                            DataBase.search_cust(name2, ref dataGridView3, "name");
                        else
                            DataBase.search_cust(ref dataGridView4, "name");
                        break;
                    }
                case "id":
                    {
                        if (radioButton7.Checked)
                            DataBase.search_cust(id3, ref dataGridView4, "id");
                        else if (radioButton6.Checked)
                            DataBase.search_cust(name2,ref dataGridView4, "id");
                        else
                            DataBase.search_cust(ref dataGridView4, "id");
                        break;
                    }
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.search_cust(ref dataGridView4,"id");
            idtb.Enabled=nametb.Enabled=false;
        }

        private void cidtb_TextChanged(object sender, EventArgs e)
        {
            custid2 = Convert.ToInt32(cidtb.Text.ToString());
        }

        private void bidtb_TextChanged(object sender, EventArgs e)
        {
            bill_id2 = Convert.ToInt32(bidtb.Text.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.place_order(custid2, bill_id2);
            }
            catch (Exception)
            {
                MessageBox.Show("Field is empty");
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void order_searchtb_TextChanged(object sender, EventArgs e)
        {
            custid2 = Convert.ToInt32(order_searchtb.Text.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataBase.search_order(custid2,ref dataGridView5);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bill_Detail bd = new Bill_Detail();
            bd.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
