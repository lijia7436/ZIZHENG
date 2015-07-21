using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace ZIZHENG
{
    public partial class YZ : Form
    {
        public YZ()
        {
            InitializeComponent();
            Computer c = new Computer();
            textBox2.Text = c.CpuID;
             
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeysSet k = new KeysSet();
            Computer c = new Computer();
            string m1 = k.EncryptDES(c.CpuID,"zanglili");
            //string m2 = k.EncryptDES(textBox1.Text, "zanglili");
            string m2 = textBox1.Text;
            if (m1 == m2)
            {
                FileRead f = new FileRead();
                f.WriterData(m1);
                YZ.ActiveForm.Close();
            }
            else 
            {
                MessageBox.Show("认证错误，请咨询管理人员");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YZ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
