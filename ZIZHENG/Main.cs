using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using ZIZHENG.WaitingBox;

namespace ZIZHENG
{
    public partial class Main : Form
    {
        AccessHelper Helper = new AccessHelper();
        public double[] rclist;
        public int Flag = 0;
        public int Flag_C = 0;
        DataTable dt_js = new DataTable();
        

        public void YZ()
        {
            Computer c = new Computer();
            KeysSet k = new KeysSet();
            FileRead f = new FileRead();
            string from_key = f.ReadData();
            string key = c.CpuID;

            if (k.EncryptDES(c.CpuID, "zanglili") != from_key)
            {
                MessageBox.Show("请验证");
                YZ y = new YZ();
                y.ShowDialog();
            }


            //String a1 = k.EncryptDES(key, "zanglili");
            //MessageBox.Show(a1);//加密后的字符串
            //String a2 = k.DecryptDES(a1, "zanglili");
            //MessageBox.Show(a2);//解密后的原样字符串
            // return i;
        }

        public Main()
        {
            InitializeComponent();
            //label9.Text = new AccessHelper().Path();

            //YZ();//验证



            // string conn = AccessHelper.connstr();
            // string sqlstr = "select * from CSSZ";

            // DataSet ds = AccessHelper.ExecuteDataSet(conn, sqlstr);
            JSSZ();
            CSSZ();
            DataJS();
            DataCS();



        }

        //锁定前一列两行
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //     comboBox2.Items.Clear();
            if (((System.Data.DataRowView) (comboBox1.SelectedItem)).Row.ItemArray[1].ToString() != "其他")
            {
                comboBox2.Enabled = true;
                DataTable dt2 =
                    Helper.GetDataTableFromDB("select ID ,MS from CSSZ where ZID =" + comboBox1.SelectedValue.ToString());
                comboBox2.DisplayMember = "1";
                comboBox2.ValueMember = "0";
                comboBox2.DataSource = dt2;
            }
            else
            {
                comboBox2.DataSource = null;
                comboBox2.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 输入页面进水水质表输入控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                dataGridView1.CurrentCell.ReadOnly = true;
            }
            else
            {
                dataGridView1.CurrentCell.ReadOnly = false;
            }

            if (dataGridView1.CurrentCell.RowIndex == 0 || dataGridView1.CurrentCell.RowIndex == 1)
            {
                dataGridView1.CurrentCell.ReadOnly = true;
            }
            else
            {
                dataGridView1.CurrentCell.ReadOnly = false;
            }
        }

        /// <summary>
        /// 初始化进水水质表格
        /// </summary>
        public void JSSZ()
        {
            /*
            DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Rows.Clear();
            dataGridView1.DataSource = dt; 
            */
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "指标";
            dataGridView1.Rows[0].Cells[1].Value = "COD0";
            dataGridView1.Rows[0].Cells[2].Value = "BOD5";
            dataGridView1.Rows[0].Cells[3].Value = "SS0";
            dataGridView1.Rows[0].Cells[4].Value = "TNO";
            dataGridView1.Rows[0].Cells[5].Value = "Nk";
            dataGridView1.Rows[0].Cells[6].Value = "TP0";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "单位";
            dataGridView1.Rows[1].Cells[1].Value = "mg/L";
            dataGridView1.Rows[1].Cells[2].Value = "mg/L";
            dataGridView1.Rows[1].Cells[3].Value = "mg/L";
            dataGridView1.Rows[1].Cells[4].Value = "mg/L";
            dataGridView1.Rows[1].Cells[5].Value = "mg/L";
            dataGridView1.Rows[1].Cells[6].Value = "mg/L";

            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "水质";
            dataGridView1.Rows[2].Cells[1].Value = 0;
            dataGridView1.Rows[2].Cells[2].Value = 0;
            dataGridView1.Rows[2].Cells[3].Value = 0;
            dataGridView1.Rows[2].Cells[4].Value = 0;
            dataGridView1.Rows[2].Cells[5].Value = 0;
            dataGridView1.Rows[2].Cells[6].Value = 0;


        }

        /// <summary>
        /// 初始化出水水质表格
        /// </summary>
        public void CSSZ()
        {
            /*
            DataTable dt = (DataTable)dataGridView2.DataSource;
            dt.Rows.Clear();
            dataGridView2.DataSource = dt;
            */

            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add();
            dataGridView2.Rows[0].Cells[0].Value = "指标";
            dataGridView2.Rows[0].Cells[1].Value = "CODe";
            dataGridView2.Rows[0].Cells[2].Value = "BOD5";
            dataGridView2.Rows[0].Cells[3].Value = "SSe";
            dataGridView2.Rows[0].Cells[4].Value = "TNe";
            dataGridView2.Rows[0].Cells[5].Value = "Nke";
            dataGridView2.Rows[0].Cells[6].Value = "TPe";


            dataGridView2.Rows[1].Cells[0].Value = "单位";
            dataGridView2.Rows[1].Cells[1].Value = "mg/L";
            dataGridView2.Rows[1].Cells[2].Value = "mg/L";
            dataGridView2.Rows[1].Cells[3].Value = "mg/L";
            dataGridView2.Rows[1].Cells[4].Value = "mg/L";
            dataGridView2.Rows[1].Cells[5].Value = "mg/L";
            dataGridView2.Rows[1].Cells[6].Value = "mg/L";

            dataGridView2.Rows.Add();
            dataGridView2.Rows[2].Cells[0].Value = "水质";
            dataGridView2.Rows[2].Cells[1].Value = 0;
            dataGridView2.Rows[2].Cells[2].Value = 0;
            dataGridView2.Rows[2].Cells[3].Value = 0;
            dataGridView2.Rows[2].Cells[4].Value = 0;
            dataGridView2.Rows[2].Cells[5].Value = 0;
            dataGridView2.Rows[2].Cells[6].Value = 0;
        }

        /// <summary>
        /// 初始化出水下拉框
        /// </summary>

        public void DataCS()
        {
            DataTable dt3 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 0");
            comboBox3.DisplayMember = "1";
            comboBox3.ValueMember = "0";
            comboBox3.DataSource = dt3;

            /*
            DataTable dt4 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 2");
            comboBox4.DisplayMember = "1";
            comboBox4.ValueMember = "0";
            comboBox4.DataSource = dt4;
            */

            DataTable dt5 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 3");
            comboBox5.DisplayMember = "1";
            comboBox5.ValueMember = "0";
            comboBox5.DataSource = dt5;

            
            DataTable dt9 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 6");
            comboBox9.DisplayMember = "1";
            comboBox9.ValueMember = "0";
            comboBox9.DataSource = dt9;
            
        }

        /// <summary>
        /// 初始化出水下拉框
        /// </summary>

        public void DataJS()
        {
            comboBox1.Items.Clear();
            DataTable dt1 = Helper.GetDataTableFromDB("select ID ,MS from CSSZ where ZID =0 order by id asc");
            comboBox1.DisplayMember = "1";
            comboBox1.ValueMember = "0";
            comboBox1.DataSource = dt1;

            DataTable dt7 = Helper.GetDataTableFromDB("select ID,MS from JSSZ");
            comboBox7.DisplayMember = "1";
            comboBox7.ValueMember = "0";
            comboBox7.DataSource = dt7;

        }

        /// <summary>
        /// 输入页面出水水质表输入控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.ColumnIndex == 0)
            {
                dataGridView2.CurrentCell.ReadOnly = true;
            }
            else
            {
                dataGridView2.CurrentCell.ReadOnly = false;
            }

            if (dataGridView2.CurrentCell.RowIndex == 0 || dataGridView2.CurrentCell.RowIndex == 1)
            {
                dataGridView2.CurrentCell.ReadOnly = true;
            }
            else
            {
                dataGridView2.CurrentCell.ReadOnly = false;
            }

            if (((System.Data.DataRowView) (comboBox1.SelectedItem)).Row.ItemArray[1].ToString() != "其他")
            {
                dataGridView2.CurrentCell.ReadOnly = true;
            }
            else
            {
                dataGridView2.CurrentCell.ReadOnly = false;
            }
        }


        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((System.Data.DataRowView) (comboBox3.SelectedItem)).Row.ItemArray[1].ToString() == "土建")
            {
                DataTable dt8 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 5");
                comboBox8.DisplayMember = "1";
                comboBox8.ValueMember = "0";
                comboBox8.DataSource = dt8;
                comboBox8.Enabled = true;
            }else
            { 

                if (((System.Data.DataRowView) (comboBox6.SelectedItem)).Row.ItemArray[1].ToString() == "碳钢+防腐" ||
                    ((System.Data.DataRowView) (comboBox6.SelectedItem)).Row.ItemArray[1].ToString() == "不锈钢" ||
                    ((System.Data.DataRowView) (comboBox6.SelectedItem)).Row.ItemArray[1].ToString() == "玻璃钢拼装水箱"
                    ){
                    DataTable dt8 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 5");
                    comboBox8.DisplayMember = "1";
                    comboBox8.ValueMember = "0";
                    comboBox8.DataSource = dt8;
                    comboBox8.Enabled = true;
                }else
                {
                    //只有一层
                    DataTable dt9 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ID = 13");
                    comboBox8.DisplayMember = "1";
                    comboBox8.ValueMember = "0";
                    comboBox8.DataSource = dt9;
                    comboBox8.Enabled = true;
                    //comboBox8.DataSource = null;
                    //comboBox8.Enabled = false;
                }
            }
        }

        /// <summary>
        /// 弹出输出界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (BTJY() == 0)
                {
                    return;
                }
                if (Flag == 1)
                {
                    return;
                }

                RclList(
                    textEdit5.Text, textEdit5.Text, textEdit6.Text,
                    dataGridView1.Rows[2].Cells[1].Value.ToString(),
                    dataGridView1.Rows[2].Cells[2].Value.ToString(),
                    dataGridView1.Rows[2].Cells[3].Value.ToString(),
                    dataGridView1.Rows[2].Cells[4].Value.ToString(),
                    dataGridView1.Rows[2].Cells[5].Value.ToString(),
                    dataGridView1.Rows[2].Cells[6].Value.ToString(),

                    dataGridView2.Rows[2].Cells[1].Value.ToString(),
                    dataGridView2.Rows[2].Cells[2].Value.ToString(),
                    dataGridView2.Rows[2].Cells[3].Value.ToString(),
                    dataGridView2.Rows[2].Cells[4].Value.ToString(),
                    dataGridView2.Rows[2].Cells[5].Value.ToString(),
                    dataGridView2.Rows[2].Cells[6].Value.ToString()
                    );

                dt_js = new JS().SS_DT(textEdit1.Text.ToString(), textEdit2.Text.ToString(), textEdit3.Text.ToString(),
                   rclist[0], rclist[1], rclist[2],
                   rclist[3], rclist[4], rclist[5], rclist[6], rclist[7], rclist[8],
                   rclist[9], rclist[10], rclist[11], rclist[12], rclist[13], rclist[14],
                   0, 0,
                   0, 0, Convert.ToDouble(((System.Data.DataRowView)(comboBox8.SelectedItem)).Row.ItemArray[0]));

                MessageBox.Show("计算完成，数据生成中，请按确定继续！");
                Flag_C = 1;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("运算异常，请检查参数");
                Flag_C = 0;
            }

            ArrayList listShow = new ArrayList();
            #region //弹出
            
            if (Flag_C == 0)
            {
                MessageBox.Show("运算异常，请检查参数");
                return;
            }
            if (BTJY() == 0)
            {
                return;
            }
            if (Flag == 1)
            {
                return;
            }

            RclList(
                textEdit5.Text, textEdit5.Text, textEdit6.Text,
                dataGridView1.Rows[2].Cells[1].Value.ToString(),
                dataGridView1.Rows[2].Cells[2].Value.ToString(),
                dataGridView1.Rows[2].Cells[3].Value.ToString(),
                dataGridView1.Rows[2].Cells[4].Value.ToString(),
                dataGridView1.Rows[2].Cells[5].Value.ToString(),
                dataGridView1.Rows[2].Cells[6].Value.ToString(),

                dataGridView2.Rows[2].Cells[1].Value.ToString(),
                dataGridView2.Rows[2].Cells[2].Value.ToString(),
                dataGridView2.Rows[2].Cells[3].Value.ToString(),
                dataGridView2.Rows[2].Cells[4].Value.ToString(),
                dataGridView2.Rows[2].Cells[5].Value.ToString(),
                dataGridView2.Rows[2].Cells[6].Value.ToString()
                );

            string m_cb3 = "";
            string m_cb4 = "";
            string m_cb5 = "";
            string m_cb6 = "";
            string m_cb8 = "";
            string m_cb9 = "";

         m_cb3 =((System.Data.DataRowView)(comboBox3.SelectedItem)).Row.ItemArray[0].ToString();
         m_cb4 =((System.Data.DataRowView)(comboBox4.SelectedItem)).Row.ItemArray[0].ToString();
         m_cb6 = "0";
        if (m_cb3 == "1")
        {
            m_cb6 = "0";
        }
        else
        {
            m_cb6 = ((System.Data.DataRowView)(comboBox6.SelectedItem)).Row.ItemArray[0].ToString();
        }
        
         m_cb8 =((System.Data.DataRowView)(comboBox8.SelectedItem)).Row.ItemArray[0].ToString();
         m_cb5 =((System.Data.DataRowView)(comboBox5.SelectedItem)).Row.ItemArray[0].ToString();
         m_cb9 = ((System.Data.DataRowView)(comboBox9.SelectedItem)).Row.ItemArray[0].ToString();

        
        listShow.Add(textEdit5.Text);
        listShow.Add(textEdit6.Text);
        listShow.Add(((System.Data.DataRowView)(comboBox7.SelectedItem)).Row.ItemArray[1]);
        listShow.Add(dataGridView1.Rows[2].Cells[1].Value.ToString());
        listShow.Add(dataGridView1.Rows[2].Cells[2].Value.ToString());
        listShow.Add(dataGridView1.Rows[2].Cells[3].Value.ToString());
        listShow.Add(dataGridView1.Rows[2].Cells[4].Value.ToString());
        listShow.Add(dataGridView1.Rows[2].Cells[5].Value.ToString());
        listShow.Add(dataGridView1.Rows[2].Cells[6].Value.ToString());
        listShow.Add(((System.Data.DataRowView)(comboBox1.SelectedItem)).Row.ItemArray[1] + "（" + ((System.Data.DataRowView)(comboBox2.SelectedItem)).Row.ItemArray[1] + "）");
        listShow.Add(dataGridView2.Rows[2].Cells[1].Value.ToString());
        listShow.Add(dataGridView2.Rows[2].Cells[2].Value.ToString());
        listShow.Add(dataGridView2.Rows[2].Cells[3].Value.ToString());
        listShow.Add(dataGridView2.Rows[2].Cells[4].Value.ToString());
        listShow.Add(dataGridView2.Rows[2].Cells[5].Value.ToString());
        listShow.Add(dataGridView2.Rows[2].Cells[6].Value.ToString());

        listShow.Add(((System.Data.DataRowView)(comboBox3.SelectedItem)).Row.ItemArray[1]);
        try
        {

            listShow.Add(((System.Data.DataRowView)(comboBox6.SelectedItem)).Row.ItemArray[1]);
        }
        catch (Exception ex)
        {
            listShow.Add("");
        }
        
        listShow.Add(((System.Data.DataRowView)(comboBox5.SelectedItem)).Row.ItemArray[1]);
        listShow.Add(((System.Data.DataRowView)(comboBox4.SelectedItem)).Row.ItemArray[1]);
        listShow.Add(((System.Data.DataRowView)(comboBox8.SelectedItem)).Row.ItemArray[1]);
        listShow.Add(((System.Data.DataRowView)(comboBox9.SelectedItem)).Row.ItemArray[1]);
        listShow.Add(((System.Data.DataRowView)(comboBox1.SelectedItem)).Row.ItemArray[1]);
        listShow.Add(((System.Data.DataRowView)(comboBox2.SelectedItem)).Row.ItemArray[1]);
        #endregion

        BaseFrom frm = new BaseFrom
                (
                listShow,textEdit1.Text.ToString(), textEdit2.Text.ToString(), textEdit3.Text.ToString(),
                dt_js, m_cb3, m_cb4, m_cb6, m_cb8, m_cb5,m_cb9);
            frm.ShowDialog();
        }

        public double[] RclList(
            string D1, string F1, string D8,
            string C4, string D4, string E4, string F4, string G4, string H4,
            string C7, string D7, string E7, string F7, string G7, string H7
            )
        {
            Flag = 0;
            rclist = null;
            rclist = new double[15];
            rclist[0] = Convert.ToDouble(D1);
            rclist[1] = Convert.ToDouble(D1)/24;
            rclist[2] = Convert.ToDouble(D8);

            try
            {
                //进水
                if (C4 == "-")
                {
                    rclist[3] = 0;
                } //COD0
                else
                {
                    rclist[3] = Convert.ToDouble(C4);
                }

                if (D4 == "-")
                {
                    rclist[4] = Convert.ToDouble(C4)*2;
                } //BOD5
                else
                {
                    rclist[4] = Convert.ToDouble(D4);
                }

                if (E4 == "-")
                {
                    rclist[5] = 0;
                } //SS0
                else
                {
                    rclist[5] = Convert.ToDouble(E4);
                }

                if (F4 == "-")
                {
                    rclist[6] = 0;
                } //TNO
                else
                {
                    rclist[6] = Convert.ToDouble(F4);
                }

                if (G4 == "-")
                {
                    rclist[7] = 0;
                } //Nk
                else
                {
                    rclist[7] = Convert.ToDouble(G4);
                }

                if (H4 == "-")
                {
                    rclist[8] = 0;
                } //TP0
                else
                {
                    rclist[8] = Convert.ToDouble(H4);
                }

                //出水
                if (C7 == "-")
                {
                    rclist[9] = Convert.ToDouble(D7)*2;
                } //CODe
                else
                {
                    rclist[9] = Convert.ToDouble(C7);
                }

                if (D7 == "-")
                {
                    rclist[10] = 0;
                } //BOD5
                else
                {
                    rclist[10] = Convert.ToDouble(D7);
                } //SSe

                if (E7 == "-")
                {
                    rclist[11] = 5;
                }
                else
                {
                    rclist[11] = Convert.ToDouble(E7);
                }

                if (F7 == "-")
                {
                    rclist[12] = Convert.ToDouble(F4);
                } //TNe(TNe = TNo)
                else
                {
                    rclist[12] = Convert.ToDouble(F7);
                }
                if (G7 == "-")
                {
                    rclist[13] = 2;
                } //Nke
                else
                {
                    if (Convert.ToDouble(G7) < 2)
                    {
                        rclist[13] = 2;
                    }
                    else
                    {
                        rclist[13] = Convert.ToDouble(G7);
                    }
                }
                if (H7 == "-")
                {
                    rclist[14] = Convert.ToDouble(H4);
                } //TPe(TPe = TPo)
                else
                {
                    rclist[14] = Convert.ToDouble(H7);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString() + "有未能识别数值，请检查");
                Flag = 1;
                return rclist;
            }
            return rclist;
        }

        /// <summary>
        /// 必填校验
        /// </summary>
        public int BTJY()
        {
            if (textEdit1.Text == "" || textEdit2.Text == "" || textEdit3.Text == "" || textEdit4.Text == "")
            {
                MessageBox.Show("请填写项目信息");
                return 0;
            }
            else if (textEdit5.Text == "0" || textEdit5.Text == "")
            {
                MessageBox.Show("处理量不能为空");
                return 0;
            }
            else if (textEdit6.Text == "0" || textEdit6.Text == "")
            {
                MessageBox.Show("温度不能为空");
                return 0;
            }
            else
            {
                return 1;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((System.Data.DataRowView) (comboBox3.SelectedItem)).Row.ItemArray[1].ToString() == "土建"
                )
            {
                DataTable dt4 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 1");
                comboBox4.DisplayMember = "1";
                comboBox4.ValueMember = "0";
                comboBox4.DataSource = dt4;
                comboBox4.Enabled = true;

                //DataTable dt6 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 6");
                //comboBox6.DisplayMember = "1";
                //comboBox6.ValueMember = "0";
                //comboBox6.DataSource = dt6;
                //comboBox6.Enabled = true;
                comboBox6.Enabled = false;

                DataTable dt8 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 5");
                comboBox8.DisplayMember = "1";
                comboBox8.ValueMember = "0";
                comboBox8.DataSource = dt8;
                comboBox8.Enabled = true;

            }
            else
            {
                DataTable dt4 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 2");
                comboBox4.DisplayMember = "1";
                comboBox4.ValueMember = "0";
                comboBox4.DataSource = dt4;
                comboBox4.Enabled = true;

                DataTable dt6 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 4");
                comboBox6.DisplayMember = "1";
                comboBox6.ValueMember = "0";
                comboBox6.DataSource = dt6;
                comboBox6.Enabled = true;

                DataTable dt8 = Helper.GetDataTableFromDB("select TDY_ID,MS from LX where ZID = 7");
                comboBox8.DisplayMember = "1";
                comboBox8.ValueMember = "0";
                comboBox8.DataSource = dt8;
                comboBox8.Enabled = true;
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt8 =
                Helper.GetDataTableFromDB("select ID,COD0,BOD5,SS0,TNO,Nk,TP0 from JSSZ where ID = " +
                                          ((System.Data.DataRowView) (comboBox7.SelectedItem)).Row.ItemArray[0].ToString
                                              ());
            dataGridView1.Rows[2].Cells[0].Value = "水质";
            dataGridView1.Rows[2].Cells[1].Value = dt8.Rows[0][1];
            dataGridView1.Rows[2].Cells[2].Value = dt8.Rows[0][2];
            dataGridView1.Rows[2].Cells[3].Value = dt8.Rows[0][3];
            dataGridView1.Rows[2].Cells[4].Value = dt8.Rows[0][4];
            dataGridView1.Rows[2].Cells[5].Value = dt8.Rows[0][5];
            dataGridView1.Rows[2].Cells[6].Value = dt8.Rows[0][6];



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((System.Data.DataRowView) (comboBox1.SelectedItem)).Row.ItemArray[1].ToString() != "其他")
            {
                DataTable dt8 =
                    Helper.GetDataTableFromDB("SELECT ID,CODe,BOD5,SSe,TNe,Nke,TPe FROM CSSZ where ID = " +
                                              ((System.Data.DataRowView) (comboBox2.SelectedItem)).Row.ItemArray[0]
                                                  .ToString());
                dataGridView2.Rows[2].Cells[0].Value = "水质";
                dataGridView2.Rows[2].Cells[1].Value = dt8.Rows[0][1];
                dataGridView2.Rows[2].Cells[2].Value = dt8.Rows[0][2];
                dataGridView2.Rows[2].Cells[3].Value = dt8.Rows[0][3];
                dataGridView2.Rows[2].Cells[4].Value = dt8.Rows[0][4];
                dataGridView2.Rows[2].Cells[5].Value = dt8.Rows[0][5];
                dataGridView2.Rows[2].Cells[6].Value = dt8.Rows[0][6];
            }
            else
            {
                dataGridView2.Rows[2].Cells[1].Value = 0;
                dataGridView2.Rows[2].Cells[2].Value = 0;
                dataGridView2.Rows[2].Cells[3].Value = 0;
                dataGridView2.Rows[2].Cells[4].Value = 0;
                dataGridView2.Rows[2].Cells[5].Value = 0;
                dataGridView2.Rows[2].Cells[6].Value = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            if (BTJY() == 0){
                return;
            }
            if (Flag == 1)
            {
                return;
            }

            RclList(
                textEdit5.Text, textEdit5.Text, textEdit6.Text,
                dataGridView1.Rows[2].Cells[1].Value.ToString(),
                dataGridView1.Rows[2].Cells[2].Value.ToString(),
                dataGridView1.Rows[2].Cells[3].Value.ToString(),
                dataGridView1.Rows[2].Cells[4].Value.ToString(),
                dataGridView1.Rows[2].Cells[5].Value.ToString(),
                dataGridView1.Rows[2].Cells[6].Value.ToString(),

                dataGridView2.Rows[2].Cells[1].Value.ToString(),
                dataGridView2.Rows[2].Cells[2].Value.ToString(),
                dataGridView2.Rows[2].Cells[3].Value.ToString(),
                dataGridView2.Rows[2].Cells[4].Value.ToString(),
                dataGridView2.Rows[2].Cells[5].Value.ToString(),
                dataGridView2.Rows[2].Cells[6].Value.ToString()
                );

             dt_js = new JS().SS_DT(textEdit1.Text.ToString(), textEdit2.Text.ToString(), textEdit3.Text.ToString(),
                rclist[0], rclist[1], rclist[2],
                rclist[3], rclist[4], rclist[5], rclist[6], rclist[7], rclist[8],
                rclist[9], rclist[10], rclist[11], rclist[12], rclist[13], rclist[14],
                0, 0,
                0, 0, Convert.ToDouble(((System.Data.DataRowView)(comboBox8.SelectedItem)).Row.ItemArray[0]));

            MessageBox.Show("计算完成");
                Flag_C = 1;
                }catch(Exception ex)
                {
                    MessageBox.Show("运算异常，请检查参数");
                    Flag_C = 0;
                }


            /*
            new JS().SJJS(textEdit1.Text.ToString(), textEdit2.Text.ToString(), textEdit3.Text.ToString(),
                rclist[0], rclist[1], rclist[2],
                rclist[3], rclist[4], rclist[5], rclist[6], rclist[7], rclist[8],
                rclist[9], rclist[10], rclist[11],rclist[12], rclist[13], rclist[14],
                0, 0, 0, 0,
                0, 0, 0, 0, Convert.ToDouble(comboBox8.DisplayMember));
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new ExcelExport().ExportExcel(dt_js, "C:/中国.XLS");
           //ExcelExport.DataGridviewShowToExcel(dataGridView1, true);
           // ExcelExport.DataTableShowToExcel(dt_js, true);
            //LicenseGenerator licensegen = new LicenseGenerator(project_filename);
            //licensegen.AdditonalLicenseInformation.Add("Name", "John Doe");
            //licensegen.AdditonalLicenseInformation.Add("Company", "Acme");
            //licensegen.HardwareLock_Enabled = true;
            //licensegen.HardwareID = "1234-1234-1234-1234-1234";
            //licensegen.CreateLicenseFile(@"C:\MyProject\newlicense.license");


              
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (((System.Data.DataRowView)(comboBox5.SelectedItem)).Row.ItemArray[1].ToString() == "是" &&
                    ((System.Data.DataRowView)(comboBox9.SelectedItem)).Row.ItemArray[1].ToString() == "设备箱")
                {
                    MessageBox.Show("设备有备用时，只能采用设备机房，不能采用设备箱");
                    comboBox9.SelectedIndex = 0;
                    comboBox5.SelectedIndex = 0;
                }
            }
            catch (Exception )
            { 
            
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            if (
                ((System.Data.DataRowView)(comboBox5.SelectedItem)).Row.ItemArray[1].ToString() == "是"&&
                ((System.Data.DataRowView)(comboBox9.SelectedItem)).Row.ItemArray[1].ToString() == "设备箱"
                )
            {
                MessageBox.Show("设备有备用时，只能采用设备机房，不能采用设备箱");
                comboBox9.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
            }
            }
            catch (Exception)
            {

            }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control)
            {
                Reg frm = new Reg();
                frm.ShowDialog();
            }
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Control)
            {
                Reg frm = new Reg();
                frm.ShowDialog();
            }
        }
    }
}