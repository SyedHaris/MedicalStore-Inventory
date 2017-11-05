using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalStoreInventory
{
    public partial class Adminstrator : Form
    {
        int adminid,id,itemid;
        public Adminstrator()
        {
            InitializeComponent();
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Adminstrator_Load(object sender, EventArgs e)
        {
            try
            {
                adminid = DataBase.getid(Login_Form.pwd,"admin");
                DataBase.admin_info(ref idbox2, ref telBox2, ref addressbox2, ref namelabel2, Login_Form.pwd);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(id,"Add");
            f5.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(id,"Update");
            f5.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataBase.del_user(id);
            MessageBox.Show("User deleted");
            add_user.Enabled = delete_user.Enabled = update_user.Enabled = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            add_user.Enabled = delete_user.Enabled = update_user.Enabled = true;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void enterid_TextChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(enterid.Text.ToString());
        }

   

        private void button4_Click(object sender, EventArgs e)
        {
            DataBase.del_item(itemid);
            MessageBox.Show("Item deleted");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(itemid,"Update");
            f6.Show();
        }

        private void okbtn2_Click(object sender, EventArgs e)
        {

            addbtn.Enabled = updatebtn.Enabled = delbtn.Enabled = true;
        }

        private void item_idtb_TextChanged(object sender, EventArgs e)
        {
            itemid = Convert.ToInt32(item_idtb.Text.ToString());
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(itemid,"Add");
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Manufacturer adm = new Add_Manufacturer();
            adm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Delete_Manufacturer dmf = new Delete_Manufacturer();
            dmf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.search_mf(ref admin_mf_dg);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataBase.search_users(ref show_user_dg);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
