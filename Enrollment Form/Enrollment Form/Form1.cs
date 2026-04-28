using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enrollment_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            User.Visible = false;
            UsertextBox1.Visible = false;
            Password.Visible = false;
            PasstextBox1.Visible = false;
            LOGIN.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void IS_Click(object sender, EventArgs e)
        {

        }

        private void COMPSCI_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IT_Click(object sender, EventArgs e)
        {
            ITPANEL.Visible = true;
        }

        private void ITPANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ITNEW_Click(object sender, EventArgs e)
        {
            ITtextBox1.Enabled = true;
            ITtextBox2.Enabled = true;
            ITtextBox3.Enabled = true;
            ITtextBox4.Enabled = true;
            ITdateTimePicker1.Enabled = true;
            ITlistBox1.Enabled = true;
            ITlistView1.Enabled = true;
            ITNEW.Enabled = false;
            ITADD.Enabled = true;
            ITUPDATE.Enabled = false;
            ITDELETE.Enabled = false;
        }

        private void ITLISTVIEW_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ITADD_Click(object sender, EventArgs e)
        {
            ListViewItem nah = new ListViewItem(ITtextBox1.Text);
            nah.SubItems.Add(ITtextBox2.Text);
            nah.SubItems.Add(ITtextBox3.Text);
            nah.SubItems.Add(ITtextBox4.Text);
            nah.SubItems.Add(ITdateTimePicker1.Text);
            nah.SubItems.Add(ITlistBox1.Text);
            ITlistView1.Items.Add(nah);
            ITNEW.Enabled = true;
            ITADD.Enabled = false;
            ITUPDATE.Enabled = true;
            ITDELETE.Enabled = true;
            ITtextBox1.Enabled = false;
            ITtextBox2.Enabled = false;
            ITtextBox3.Enabled = false;
            ITtextBox4.Enabled = false;
            ITdateTimePicker1.Enabled = false;
            ITlistBox1.Enabled = false;
            ITlistView1.Text = "";
            ITtextBox1.Text = "";
            ITtextBox2.Text = "";
            ITtextBox3.Text = "";
            ITtextBox4.Text = "";
            ITdateTimePicker1.Text = "";
            ITlistBox1.Text = "";
            ITlistView1.Text = "";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ITUPDATE_Click(object sender, EventArgs e)
        {
                ITlistView1.SelectedItems[0].SubItems[0].Text = ITtextBox1.Text;
                ITlistView1.SelectedItems[0].SubItems[1].Text = ITtextBox2.Text;
                ITlistView1.SelectedItems[0].SubItems[2].Text = ITtextBox3.Text;
                ITlistView1.SelectedItems[0].SubItems[3].Text = ITtextBox4.Text;
                ITlistView1.SelectedItems[0].SubItems[4].Text = ITdateTimePicker1.Text;
                ITlistView1.SelectedItems[0].SubItems[5].Text = ITlistBox1.Text;
                ITNEW.Enabled = true;
                ITtextBox1.Text = "";
                ITtextBox2.Text = "";
                ITtextBox3.Text = "";
                ITtextBox4.Text = "";
                ITdateTimePicker1.Text = "";
                ITlistBox1.Text = "";
                ITtextBox1.Enabled = false;
                ITtextBox2.Enabled = false;
                ITtextBox3.Enabled = false;
                ITtextBox4.Enabled = false;
                ITdateTimePicker1.Enabled = false;
                ITlistBox1.Enabled = false;
                ITUPDATE.Enabled = false;
                ITDELETE.Enabled = false;

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void ITDELETE_Click(object sender, EventArgs e)
        {
            ITlistView1.Items.Remove(ITlistView1.SelectedItems[0]);
            ITNEW.Enabled = true;
            ITtextBox1.Text = "";
            ITtextBox2.Text = "";
            ITtextBox3.Text = "";
            ITtextBox4.Text = "";
            ITdateTimePicker1.Text = "";
            ITlistBox1.Text = "";
            ITtextBox1.Enabled = false;
            ITtextBox2.Enabled = false;
            ITtextBox3.Enabled = false;
            ITtextBox4.Enabled = false;
            ITdateTimePicker1.Enabled = false;
            ITlistBox1.Enabled = false;
            ITUPDATE.Enabled = false;
            ITDELETE.Enabled = false;

        }

        private void ITlistView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ITlistView1.SelectedItems.Count > 0)
            {
                ITtextBox1.Text = ITlistView1.SelectedItems[0].SubItems[0].Text;
                ITtextBox2.Text = ITlistView1.SelectedItems[0].SubItems[1].Text;
                ITtextBox3.Text = ITlistView1.SelectedItems[0].SubItems[2].Text;
                ITtextBox4.Text = ITlistView1.SelectedItems[0].SubItems[3].Text;
                ITdateTimePicker1.Text = ITlistView1.SelectedItems[0].SubItems[4].Text;
                ITlistBox1.Text = ITlistView1.SelectedItems[0].SubItems[5].Text;
                ITNEW.Enabled = false;
                ITtextBox1.Enabled = true;
                ITtextBox2.Enabled = true;
                ITtextBox3.Enabled = true;
                ITtextBox4.Enabled = true;
                ITdateTimePicker1.Enabled = true;
                ITlistBox1.Enabled = true;
                ITUPDATE.Enabled = true;
                ITDELETE.Enabled = true;
            }
        }

        private void TOUR_Click(object sender, EventArgs e)
        {
            TOURPANEL.Visible = true;
        }

        private void TOURNEW_Click(object sender, EventArgs e)
        {
            TOURtextBox1.Enabled = true;
            TOURtextBox2.Enabled = true;
            TOURtextBox3.Enabled = true;
            TOURtextBox4.Enabled = true;
            TOURdateTimePicker1.Enabled = true;
            TOURlistBox1.Enabled = true;
            TOURlistView1.Enabled = true;
            TOURNEW.Enabled = false;
            TOURADD.Enabled = true;
            TOURUPDATE.Enabled = false;
            TOURDELETE.Enabled = false;
        }

        private void TOURADD_Click(object sender, EventArgs e)
        {

        }
    }
}
