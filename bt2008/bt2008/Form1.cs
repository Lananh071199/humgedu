using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int tongchan = 0, tongle = 0, tongcacpt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNhapSo.Text);
            txtDayVuaNhap.Text += x.ToString() + " ";
            if (x % 2 == 0)
            {
                tongchan += x;
                txtTongChan.Text = tongchan.ToString();

            }else
            {
                tongle += x;
                txtTongLe.Text = tongle.ToString();
            }
            tongcacpt += x;
            txtTongPT.Text = tongcacpt.ToString();
            txtNhapSo.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDayVuaNhap.ResetText();
            txtTongPT.ResetText();
            txtTongChan.ResetText();
            txtTongLe.ResetText();
            tongchan = 0;
            tongle = 0;
            tongcacpt = 0;
        }


   
        
        
    }
}
