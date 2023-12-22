using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R.R
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Method
        public void clear()
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            txtq.Text = txtp1.Text = txtp2.Text = txtp3.Text = txtp4.Text = "";
            MessageBox.Show("Operation IS Finished ");
        } 
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = txtp1.Text;
            label12.Text = txtp2.Text;
            label13.Text = txtp3.Text;
            label14.Text =txtp4.Text;

            Start();          
        }
        private void Start()
        {
            if (txtp1.Text != "" && txtp2.Text != "" && txtp3.Text != "" && txtp4.Text != "" && txtq.Text != "")
            {
                //p1
                if (Convert.ToInt16(txtp1.Text) > 0)
                {
                    if (Convert.ToInt16(txtp1.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        txtp1.Text = (Convert.ToInt16(txtp1.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(label1.Text);
                    }
                    else if (Convert.ToInt16(txtp1.Text) < Convert.ToInt16(txtq.Text))
                    {
                        txtp1.Text = "0";
                        checkedListBox1.Items.Add(label1.Text);
                    }
                }
                //p2
                if (Convert.ToInt16(txtp2.Text) > 0)
                {
                    if (Convert.ToInt16(txtp2.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        txtp2.Text = (Convert.ToInt16(txtp2.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(label2.Text);
                    }
                    else if (Convert.ToInt16(txtp2.Text) < Convert.ToInt16(txtq.Text))
                    {
                        txtp2.Text = "0";
                        checkedListBox1.Items.Add(label2.Text);
                    }
                }

                //p3
                if (Convert.ToInt16(txtp3.Text) > 0)
                {
                    if (Convert.ToInt16(txtp3.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        txtp3.Text = (Convert.ToInt16(txtp3.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(label3.Text);
                    }
                    else if (Convert.ToInt16(txtp3.Text) < Convert.ToInt16(txtq.Text))
                    {
                        txtp3.Text = "0";
                        checkedListBox1.Items.Add(label3.Text);
                    }
                }

                //p4
                if (Convert.ToInt16(txtp4.Text) > 0)
                {
                    if (Convert.ToInt16(txtp4.Text) >= Convert.ToInt16(txtq.Text))
                    {
                        txtp4.Text = (Convert.ToInt16(txtp4.Text) - Convert.ToInt16(txtq.Text)).ToString();
                        checkedListBox1.Items.Add(label4.Text);
                    }
                    else if (Convert.ToInt16(txtp4.Text) < Convert.ToInt16(txtq.Text))
                    {
                        txtp4.Text = "0";
                        checkedListBox1.Items.Add(label4.Text);
                    }
                }
                textBox5.Text = "";
                timer2.Start();

            }
            else
            {
                MessageBox.Show("You should Inter Values First");
            }         
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count>0)
            {
                textBox5.Text=checkedListBox1.Items[0].ToString();
                checkedListBox1.Items.RemoveAt(0);
                //timer2.Stop();
            }
            else if(checkedListBox1.Items.Count<=0)
            {
                timer2.Stop();
                clear();               
            }                
        }
    }
}
