using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ZIZHENG
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageUtil.ShowTips("请输入认证码!");
            }
            else
            {
                try { 
                KeysSet k = new KeysSet();
                //Computer c = new Computer();
                textBox2.Text = k.EncryptDES(textBox1.Text, "zanglili");
                StreamWriter sw = new StreamWriter(Application.StartupPath + "/" + textBox1.Text + "_key.txt");
                sw.Write(textBox2.Text);
                sw.Close();
                MessageBox.Show("生成授权文件成功!");    
                }
                catch (Exception ex)
                {
                    MessageUtil.ShowError("错误信息:"+ex.Message);

                }

            }
           
        }
    }
}
