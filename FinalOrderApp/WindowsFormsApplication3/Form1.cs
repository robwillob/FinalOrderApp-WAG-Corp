using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //Gadget Selection 

            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plain Finish Small Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("630.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Painted Finish Small Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("630.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plated Finish Small Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("630.00");
                    listView1.Items.Add(item);

                }

            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plain Finish Medium Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("1,373.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Painted Finish Medium Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("1,373.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plated Finish Medium Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("1,373.00");
                    listView1.Items.Add(item);

                }
            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plain Finish Large Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3,935.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Painted Finish Large Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3,935.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plated Finish Large Gadget");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3,935.00");
                    listView1.Items.Add(item);

                }
            }

            else if (radioButton4.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plain Finish Custom Order");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Painted Finish Custom Order");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0.00");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Plated Finish Custom Order");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0.00");
                    listView1.Items.Add(item);

                }
            }


            //Finish/Color Selection

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  White Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Black Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Gray Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Green Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Chief's Red Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Royal Blue Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Yellow Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pink Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Gold Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Platinum Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Rose Gold");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Silver Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }


            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Camouflage Color");
                item.SubItems.Add("");
                item.SubItems.Add("0.00");
                listView1.Items.Add(item);

            }

            if (checkBox14.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Rhodium Color");
                item.SubItems.Add("");
                item.SubItems.Add("200.00");
                listView1.Items.Add(item);

            }

            //Replacement Part Selection

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Replacement Parts: Small Widget - $250.00");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 250.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Replacement Parts: Medium Widget - $300.00");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 300.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Replacement Parts: Large Widget - $350.00");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 350.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Replacement Parts: Switch - $10.00");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 10.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox19.Checked == true)
            {
                ListViewItem item = new ListViewItem("Replacement Parts: Buttons - $10.00");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 10.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox20.Checked == true)
            {
                ListViewItem item = new ListViewItem("Replacement Parts: Lights - $15.00");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 15.00;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }



            //Power Source Selection

            if (checkBox22.Checked == true)
            {
                ListViewItem item = new ListViewItem("Battery Powered ($50.00)");
                item.SubItems.Add("");
                item.SubItems.Add("50.00");
                listView1.Items.Add(item);

            }

            if (checkBox23.Checked == true)
            {
                ListViewItem item = new ListViewItem("Solar Powered ($100.00)");
                item.SubItems.Add("");
                item.SubItems.Add("100.00");
                listView1.Items.Add(item);

            }

            if (checkBox24.Checked == true)
            {
                ListViewItem item = new ListViewItem("Generator Powered ($200.00m)");
                item.SubItems.Add("");
                item.SubItems.Add("200.00");
                listView1.Items.Add(item);

            }




            double total = 0;
            double hst = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            hst = total * 0.13;
            totaldue = hst + total;

            string hstDisplay = hst.ToString("c2");
            string totalDisplay = totaldue.ToString("c2");
            string amount = total.ToString("c2");

            textBox8.Text = amount;
            textBox9.Text = hstDisplay;
            textBox10.Text = totalDisplay;

            tabControl1.SelectTab("tabPage2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            textBox21.Enabled = false;

            comboBox1.Items.Add("Kansas");
            comboBox1.Items.Add("Missouri");
            comboBox1.Items.Add("Nebraska");
            comboBox1.Items.Add("Iowa");
            comboBox1.Items.Add("Illinois");
            comboBox1.Items.Add("Oklahoma");
            comboBox1.Items.Add("Arkansas");
            comboBox1.Items.Add("Tennessee");
            comboBox1.Items.Add("Kentucky");

            comboBox2.Items.Add("Cash");
            comboBox2.Items.Add("Credit Card");
            comboBox2.Items.Add("Debit Card");
            comboBox2.Items.Add("Promo Card");

            button8.Enabled = false;

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 46)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox15.Text == "" || textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in required fields");
            }

            else
            {
                string money = textBox19.Text;
                char[] dollars = { '$' };
                string paymoney = money.TrimStart(dollars);
                double paymentDue = Convert.ToDouble(paymoney);
                double amountPaid = Convert.ToDouble(textBox20.Text);
                double change = 0;
                change = amountPaid - paymentDue;
                textBox21.Text = change.ToString("c2");

                if (change < 0)
                {
                    MessageBox.Show("Please pay your balance");

                }

                else
                {
                    button8.Enabled = true;
                }


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Thanks for ordering at the WAG Corporation. Your ordered items will be ready and delivered within 24 hours. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                //Clearing all data
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";

                listView1.Items.Clear();
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";

                tabControl1.SelectTab("tabPage1");
            }

            else if (dialog == DialogResult.No)
            {
                this.Close();
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
                textBox18.Enabled = false;
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
//cpfn
