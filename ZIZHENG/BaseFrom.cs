using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;
using System.Collections;
//using DevExpress.XtraEditors;

namespace ZIZHENG
{
    public partial class BaseFrom : Form//DevExpress.XtraEditors.XtraForm
    {
        private string p1;
        private string p2;
        private string p3;

        public double D1;
        public double F1;
        public double D8;
        public double C4;
        public double D4;
        public double E4;
        public double F4;
        public double G4;
        public double H4;

        public double C7;
        public double D7;
        public double E7;
        public double F7;
        public double G7;
        public double H7;

        // public double D8;
        public double D9;
        public double D11;
        public double D41;
        public double D45;

        public double I9;
        public double H1;
        public double K9;
        public double K11;
        public double K12;
        public DataTable dt;
        
         public string B_D1;
         public string B_D25;
         public string B_C4;
         public string B_C7;
         public string B_D4;
         public string B_D7;
         public string B_E4;
         public string B_E7;
         public string B_F4;
         public string B_F7;
         public string B_G4;
         public string B_G7;
         public string B_H4;
         public string B_H7;

        string xh_c_10_0  = "" ;
        double sl_c_10_0 = 0.00;
        string dw_c_10_0 = "";
        double dj_c_10_0 = 0.00;
        string xh_c_10_1 = "";
        double sl_c_10_1 = 0.00;
        string dw_c_10_1 = "";
        double dj_c_10_1 = 0.00;
        string xh_c_10_2 = "";
        double sl_c_10_2 = 0.00;
        string dw_c_10_2 = "";
        double dj_c_10_2 = 0.00;
        string xh_c_10_3 = "";
        double sl_c_10_3 = 0.00;
        string dw_c_10_3 = "";
        double dj_c_10_3 = 0.00;
        string xh_c_10_4 = "";
        double sl_c_10_4 = 0.00;
        string dw_c_10_4 = "";
        double dj_c_10_4 = 0.00;
        string xh_c_10_5 = "";
        double sl_c_10_5 = 0.00;
        string dw_c_10_5 = "";
        double dj_c_10_5 = 0.00;
        string xh_c_10_6 = "";
        double sl_c_10_6 = 0.00;
        string dw_c_10_6 = "";
        double dj_c_10_6 = 0.00;
        string xh_c_10_7 = "";
        double sl_c_10_7 = 0.00;
        string dw_c_10_7 = "";
        double dj_c_10_7 = 0.00;
        string xh_c_10_8 = "";
        double sl_c_10_8 = 0.00;
        string dw_c_10_8 = "";
        double dj_c_10_8 = 0.00;
        string xh_c_10_9 = "";
        double sl_c_10_9 = 0.00;
        string dw_c_10_9 = "";
        double dj_c_10_9 = 0.00;
        string xh_c_10_10 = "";
        double sl_c_10_10 = 0.00;
        string dw_c_10_10 = "";
        double dj_c_10_10 = 0.00;
        string xh_c_10_11 = "";
        double sl_c_10_11 = 0.00;
        string dw_c_10_11 = "";
        double dj_c_10_11 = 0.00;
        string xh_c_10_12 = "";
        double sl_c_10_12 = 0.00;
        string dw_c_10_12 = "";
        double dj_c_10_12 = 0.00;
        double ZDZZB = 0.00;
        double SBNHZB = 0.00;
        double YXDFZB = 0.00;
        string m_cb3_2 = "";
        string m_cb4_2 = "";
        string m_cb6_2 = "";
        string m_cb8_2 = "";
        string m_cb5_2 = "";
        string m_cb9_2 = "";
        int I18_FLAG = 0; // 0代表未修改，1代表已修改
        int D17_FLAG = 0;  //判断D17是否修正
        int D18_FLAG= 0;  //判断D18是否修正

        //导出word
        public DataTable dtwd1;
        public DataTable dtwd2;
        /// <summary>
        /// 设备参数
        /// </summary>
        public DataTable dtwd3; 
        /// <summary>
        /// 设备尺寸
        /// </summary>
        public DataTable dtwd4;
        public DataTable dtwd5;
        public DataTable dtwd6;
        public DataTable dtwd7;
        public DataTable dtwd8;
        public DataTable dtwd9;
        public DataTable dtwd10;
        public DataTable dtwd11;
        /// <summary>
        /// 图片
        /// </summary>
        public DataTable dtwd12;


        AccessHelper Helper = new AccessHelper();
        public BaseFrom()
        {
            InitializeComponent();
            // CSH();
        }

        /*
         public BaseFrom
             (string p1, string p2, string p3,
             double D1, double F1, double D8,
             double C4, double D4, double E4, double F4, double G4, double H4,
             double C7, double D7, double E7, double F7, double G7, double H7,
             double D9, double,double D41,double D45,
             double I9, double H1, double K9, double K11,double K12
             )
         */
        public BaseFrom(ArrayList listShow, string p1, string p2, string p3, DataTable dt1, string m_cb3, string m_cb4, string m_cb6, string m_cb8, string m_cb5, string m_cb9)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.dt = dt1;
            this.m_cb3_2 = m_cb3;
            this.m_cb4_2 = m_cb4;
            this.m_cb5_2 = m_cb5;
            this.m_cb6_2 = m_cb6;
            this.m_cb8_2 = m_cb8;
            this.m_cb9_2 = m_cb9;

            


            InitializeComponent();
            this.rowMergeView1.MergeColumnNames.Add("Column1");
            this.rowMergeView2.MergeColumnNames.Add("Column64");
            this.rowMergeView3.MergeColumnNames.Add("Column65");
            this.rowMergeView4.MergeColumnNames.Add("Column66");
            this.rowMergeView5.MergeColumnNames.Add("Column30");
            this.rowMergeView6.MergeColumnNames.Add("Column37");
            this.rowMergeView7.MergeColumnNames.Add("Column43");
            this.rowMergeView8.MergeColumnNames.Add("Column48");
            this.rowMergeView9.MergeColumnNames.Add("Column57");
            this.rowMergeView10.MergeColumnNames.Add("Column100");
            this.rowMergeView11.MergeColumnNames.Add("dataGridViewTextBoxColumn1");

            //CSH();
            CshText(listShow);
            SJCS_Table();
            FHCS_Table();
            WNCS_Table();
            BQCS_Table();
            SBCS_Table();
            SBCC1_Table();
            SBCC2_Table();
            YXNH_Table();
            TZCB_Table();

            this.rowMergeView6.ColumnHeadersHeight = 40;
            this.rowMergeView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rowMergeView6.MergeColumnNames.Add("Column43");
            this.rowMergeView6.AddSpanHeader(0, 2, "设备尺寸");
            ReTable(dt);
            System_sj(dt);            
            /*
            //设计参数一览表
            rowMergeView1.Rows[1].Cells[1].Value = dt.Select("BS='SJ' AND WZ='D45'")[0][2];
            rowMergeView1.Rows[1].Cells[2].Value = dt.Select("BS='SJ' AND WZ='D46'")[0][2];
            rowMergeView1.Rows[1].Cells[3].Value = dt.Select("BS='SJ' AND WZ='D42'")[0][2];
            rowMergeView1.Rows[1].Cells[4].Value = dt.Select("BS='SJ' AND WZ='D40'")[0][2];
            rowMergeView1.Rows[1].Cells[5].Value = dt.Select("BS='SJ' AND WZ='I19'")[0][2];
            rowMergeView1.Rows[1].Cells[6].Value = dt.Select("BS='SJ' AND WZ='I17'")[0][2];
            rowMergeView1.Rows[1].Cells[7].Value = dt.Select("BS='SJ' AND WZ='I9'")[0][2];
            rowMergeView1.Rows[1].Cells[8].Value = dt.Select("BS='SJ' AND WZ='I10'")[0][2];
            rowMergeView1.Rows[1].Cells[9].Value = dt.Select("BS='SJ' AND WZ='D43'")[0][2];
            rowMergeView1.Rows[1].Cells[10].Value = dt.Select("BS='SJ' AND WZ='D30'")[0][2];
            rowMergeView1.Rows[1].Cells[11].Value = dt.Select("BS='SJ' AND WZ='D25'")[0][2];
            rowMergeView1.Rows[1].Cells[12].Value = dt.Select("BS='SJ' AND WZ='D49'")[0][2];
            rowMergeView1.Rows[1].Cells[13].Value = dt.Select("BS='SJ' AND WZ='D39'")[0][2];

            //负荷参数一览表
            rowMergeView2.Rows[1].Cells[1].Value = dt.Select("BS='SJ' AND WZ='D17'")[0][2];
            rowMergeView2.Rows[1].Cells[2].Value = dt.Select("BS='SJ' AND WZ='D18'")[0][2];
            rowMergeView2.Rows[1].Cells[3].Value = dt.Select("BS='SJ' AND WZ='D17'")[0][2];
            rowMergeView2.Rows[1].Cells[4].Value = dt.Select("BS='SJ' AND WZ='D18'")[0][2];
            rowMergeView2.Rows[1].Cells[5].Value = dt.Select("BS='SJ' AND WZ='I35'")[0][2];



            //污泥参数一览表
            rowMergeView3.Rows[1].Cells[1].Value = dt.Select("BS='SJ' AND WZ='I33'")[0][2];
            rowMergeView3.Rows[1].Cells[2].Value = dt.Select("BS='SJ' AND WZ='D34'")[0][2];
            rowMergeView3.Rows[1].Cells[3].Value = dt.Select("BS='SJ' AND WZ='D38'")[0][2];
            rowMergeView3.Rows[1].Cells[4].Value = dt.Select("BS='SJ' AND WZ='D24'")[0][2];
            rowMergeView3.Rows[1].Cells[5].Value = dt.Select("BS='SJ' AND WZ='D36'")[0][2];
            rowMergeView3.Rows[1].Cells[6].Value = dt.Select("BS='SJ' AND WZ='D19'")[0][2];
            rowMergeView3.Rows[1].Cells[7].Value = dt.Select("BS='SJ' AND WZ='D29'")[0][2];
            rowMergeView3.Rows[1].Cells[8].Value = dt.Select("BS='SJ' AND WZ='D26'")[0][2];
            //曝气参数一览表
            rowMergeView4.Rows[1].Cells[1].Value = dt.Select("BS='BQ' AND WZ='D1'")[0][2];
            rowMergeView4.Rows[1].Cells[2].Value = dt.Select("BS='BQ' AND WZ='D24'")[0][2];
            rowMergeView4.Rows[1].Cells[3].Value = dt.Select("BS='BQ' AND WZ='D27'")[0][2];
            rowMergeView4.Rows[1].Cells[4].Value = dt.Select("BS='BQ' AND WZ='D58'")[0][2];
            rowMergeView4.Rows[1].Cells[5].Value = dt.Select("BS='BQ' AND WZ='D38'")[0][2];
            rowMergeView4.Rows[1].Cells[6].Value = dt.Select("BS='BQ' AND WZ='D66'")[0][2];
            rowMergeView4.Rows[1].Cells[7].Value = dt.Select("BS='BQ' AND WZ='D67'")[0][2];
            rowMergeView4.Rows[1].Cells[8].Value = dt.Select("BS='BQ' AND WZ='D68'")[0][2];
            rowMergeView4.Rows[1].Cells[9].Value = dt.Select("BS='BQ' AND WZ='D33'")[0][2];
            rowMergeView4.Rows[1].Cells[10].Value = dt.Select("BS='SJ' AND WZ='D50'")[0][2];
            */

            string sb_D1 = dt.Select("BS='SJ' AND WZ='D1'")[0][2].ToString();
            string sb_D45 = dt.Select("BS='SJ' AND WZ='D45'")[0][2].ToString();
            string sb_D48 = dt.Select("BS='SJ' AND WZ='D48'")[0][2].ToString();
            string sb_D49 = dt.Select("BS='SJ' AND WZ='D49'")[0][2].ToString();
            string sb_D50 = dt.Select("BS='SJ' AND WZ='D50'")[0][2].ToString();
            string sb_K11 = dt.Select("BS='SJ' AND WZ='K11'")[0][2].ToString();
            string sb_K12 = dt.Select("BS='SJ' AND WZ='K12'")[0][2].ToString();
            string sb_D30 = dt.Select("BS='SJ' AND WZ='D30'")[0][2].ToString();
            string sb_I10 = dt.Select("BS='SJ' AND WZ='I10'")[0][2].ToString();
            string sb_I19 = dt.Select("BS='SJ' AND WZ='I19'")[0][2].ToString();
            string sb_D42 = dt.Select("BS='SJ' AND WZ='D42'")[0][2].ToString();
            B_D1  = dt.Select("BS='SJ' AND WZ='D1'")[0][2].ToString();
            B_D25 = dt.Select("BS='SJ' AND WZ='D25'")[0][2].ToString();
            B_C4  = dt.Select("BS='SJ' AND WZ='C4'")[0][2].ToString();
            B_C7  = dt.Select("BS='SJ' AND WZ='C7'")[0][2].ToString();
            B_D4  = dt.Select("BS='SJ' AND WZ='D4'")[0][2].ToString();
            B_D7  = dt.Select("BS='SJ' AND WZ='D7'")[0][2].ToString();
            B_E4  = dt.Select("BS='SJ' AND WZ='E4'")[0][2].ToString();
            B_E7  = dt.Select("BS='SJ' AND WZ='E7'")[0][2].ToString();
            B_F4  = dt.Select("BS='SJ' AND WZ='F4'")[0][2].ToString();
            B_F7  = dt.Select("BS='SJ' AND WZ='F7'")[0][2].ToString();
            B_G4  = dt.Select("BS='SJ' AND WZ='G4'")[0][2].ToString();
            B_G7  = dt.Select("BS='SJ' AND WZ='G7'")[0][2].ToString();
            B_H4  = dt.Select("BS='SJ' AND WZ='H4'")[0][2].ToString();
            B_H7  = dt.Select("BS='SJ' AND WZ='H7'")[0][2].ToString();
            TableSet(sb_D1, sb_D45, sb_D48,sb_D49, sb_D50, sb_K11, sb_K12, sb_D30, sb_I10,sb_I19,sb_D42,m_cb3, m_cb4, m_cb6, m_cb8, m_cb5, m_cb9);
            //这里是第二个结尾

            tabControl1.TabPages.Remove(tabPage9);
           // tabControl1.TabPages.Remove(tabPage10);
           // tabControl1.TabPages.Remove(tabPage11);
           // tabControl1.TabPages.Remove(tabPage12);
           // tabControl1.TabPages.Remove(tabPage13); 

            Dtwd_DT(2,dt); //获取表数据

        }
        /// <summary>
        /// 项目初始化
        /// </summary>
        public void CshText(ArrayList listShow)
        {

            textBox1.Text = p1;
            textBox2.Text = p2;
            textBox3.Text = p3;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

			lab5.Text =  "处 理 量："+listShow[0].ToString()+"m³/d";
            lab6.Text =  "设计温度："+listShow[1].ToString()+"℃";
            lab7.Text =  "进水水质："+listShow[2].ToString();
            lab8.Text =  "CODO    ："+listShow[3].ToString()+"mg/L";
            lab9.Text =  "BOD5    ："+listShow[4].ToString()+"mg/L";
            lab10.Text = "SS0     ："+listShow[5].ToString()+"mg/L";
            lab11.Text = "TN0     ："+listShow[6].ToString()+"mg/L";
            lab12.Text = "NK      ："+listShow[7].ToString()+"mg/L";
            lab13.Text = "TP0     ："+listShow[8].ToString()+"mg/L";
            lab14.Text = "出水水质："+listShow[9].ToString();
            lab15.Text = "C0De    ："+listShow[10].ToString()+"mg/L";
            lab16.Text = "B0D5    ："+listShow[11].ToString()+"mg/L";
            lab17.Text = "SSe     ："+listShow[12].ToString()+"mg/L";
            lab18.Text = "TNe     ："+listShow[13].ToString()+"mg/L";
            lab19.Text = "Nke     ："+listShow[14].ToString()+"mg/L";
            lab20.Text = "TPe     ："+listShow[15].ToString()+"mg/L";
            lab21.Text = "设备形式："+listShow[16].ToString();
            lab22.Text = "设备材质："+listShow[17].ToString();
            lab23.Text = "设备是否需要备用："+listShow[18].ToString();
            lab24.Text = "设备类型："+listShow[19].ToString();
            lab25.Text = "膜组件层数："+listShow[20].ToString();
            lab26.Text = "设备机房形式："+listShow[21].ToString();

            this.Column1.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column67.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column68.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column69.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column9.Resizable  = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column70.Resizable = System.Windows.Forms.DataGridViewTriState.True;

            ///word传值
            dtwd1 = DataTableHelper.CreateTable("BS,SZ");
            dtwd1.Rows.Add(new object[] { p1, p1 });
            dtwd1.Rows.Add(new object[] { p2, p2 });
            dtwd1.Rows.Add(new object[] { p3, p3 });
            for (var i = 0; i < listShow.Count; i++) 
            {
                dtwd1.Rows.Add(new object[] { listShow[i].ToString(), listShow[i].ToString() });
            }

        //dtwd1 = new DataTable("DBWD1"); 
        //dt.Columns.Add("column0", System.Type.GetType("System.String"));
       // DataColumn dc = new DataColumn("column1", System.Type.GetType("System.Boolean"));
       // dt.Columns.Add(dc);
        //DataRow row;
        //row = dt.NewRow();
        //row["img"] = "Image/index/BISnn2_03.gif";

        }

        /// <summary>
        /// 设计参数表格初始化
        /// </summary>
        public void SJCS_Table()
        {
            /*
            rowMergeView1.Rows.Add();
            rowMergeView1.Rows[0].Cells[0].Value = "指标";
            rowMergeView1.Rows[0].Cells[1].Value = "CODe";
            rowMergeView1.Rows[0].Cells[2].Value = "BOD5";
            rowMergeView1.Rows[0].Cells[3].Value = "SSe";
            rowMergeView1.Rows[0].Cells[4].Value = "TNe";
            rowMergeView1.Rows[0].Cells[5].Value = "Nke";
            rowMergeView1.Rows[0].Cells[6].Value = "TPe";
            */

            rowMergeView1.Rows.Add();
            rowMergeView1.Rows[0].Cells[0].Value = "单位";
            rowMergeView1.Rows[0].Cells[1].Value = "h";
            rowMergeView1.Rows[0].Cells[2].Value = "m³";
            rowMergeView1.Rows[0].Cells[3].Value = "h";
            rowMergeView1.Rows[0].Cells[4].Value = "m³";
            rowMergeView1.Rows[0].Cells[5].Value = "h";
            rowMergeView1.Rows[0].Cells[6].Value = "m³";
            rowMergeView1.Rows[0].Cells[7].Value = "L/m²d";
            rowMergeView1.Rows[0].Cells[8].Value = "片";
            rowMergeView1.Rows[0].Cells[9].Value = "%";
            rowMergeView1.Rows[0].Cells[10].Value = "m³/d";
            rowMergeView1.Rows[0].Cells[11].Value = "kg/d";
            rowMergeView1.Rows[0].Cells[12].Value = "m³/min";
            rowMergeView1.Rows[0].Cells[13].Value = "m³/m²•min";

            rowMergeView1.Rows.Add();
            rowMergeView1.Rows[1].Cells[0].Value = "计算结果";
            rowMergeView1.Rows[1].Cells[1].Value = "0";
            rowMergeView1.Rows[1].Cells[2].Value = "0";
            rowMergeView1.Rows[1].Cells[3].Value = "0";
            rowMergeView1.Rows[1].Cells[4].Value = "0";
            rowMergeView1.Rows[1].Cells[5].Value = "0";
            rowMergeView1.Rows[1].Cells[6].Value = "0";
            rowMergeView1.Rows[1].Cells[7].Value = "0";
            rowMergeView1.Rows[1].Cells[8].Value = "0";
            rowMergeView1.Rows[1].Cells[9].Value = "0";
            rowMergeView1.Rows[1].Cells[10].Value = "0";
            rowMergeView1.Rows[1].Cells[11].Value = "0";
            rowMergeView1.Rows[1].Cells[12].Value = "0";
            rowMergeView1.Rows[1].Cells[13].Value = "0";

            rowMergeView1.Rows.Add();
            rowMergeView1.Rows[2].Cells[0].Value = "矫正值";
            rowMergeView1.Rows[2].Cells[1].Value = "0";
            rowMergeView1.Rows[2].Cells[2].Value = "";
            rowMergeView1.Rows[2].Cells[3].Value = "";
            rowMergeView1.Rows[2].Cells[4].Value = "0";
            rowMergeView1.Rows[2].Cells[5].Value = "";
            rowMergeView1.Rows[2].Cells[6].Value = "0";
            rowMergeView1.Rows[2].Cells[7].Value = "0";
            rowMergeView1.Rows[2].Cells[8].Value = "";
            rowMergeView1.Rows[2].Cells[9].Value = "";
            rowMergeView1.Rows[2].Cells[10].Value = "";
            rowMergeView1.Rows[2].Cells[11].Value = "";
            rowMergeView1.Rows[2].Cells[12].Value = "";
            rowMergeView1.Rows[2].Cells[13].Value = "0";

        }

        /// <summary>
        /// 负荷参数表格初始化
        /// </summary>
        public void FHCS_Table()
        {
            rowMergeView2.Rows.Add();
            //rowMergeView2.Rows[0].Cells[0].Value = "单位";
            rowMergeView2.Rows[0].Cells[0].Value = "单位";
            rowMergeView2.Rows[0].Cells[1].Value = "kgCOD/(m³•d)";
            rowMergeView2.Rows[0].Cells[2].Value = "kgN/(m³•d)";
            rowMergeView2.Rows[0].Cells[3].Value = "kgBOD5/m³d";
            rowMergeView2.Rows[0].Cells[4].Value = "kgBOD5/kgMLSS•d";
            rowMergeView2.Rows[0].Cells[5].Value = "kgNO3-N/(kgMLSS•d)";

            rowMergeView2.Rows.Add();
            rowMergeView2.Rows[1].Cells[0].Value = "计算结果";
            rowMergeView2.Rows[1].Cells[1].Value = "0";
            rowMergeView2.Rows[1].Cells[2].Value = "0";
            rowMergeView2.Rows[1].Cells[3].Value = "0";
            rowMergeView2.Rows[1].Cells[4].Value = "0";
            rowMergeView2.Rows[1].Cells[5].Value = "0";

            rowMergeView2.Rows.Add();
            rowMergeView2.Rows[2].Cells[0].Value = "矫正值";
            rowMergeView2.Rows[2].Cells[1].Value = "0";
            rowMergeView2.Rows[2].Cells[2].Value = "0";
            rowMergeView2.Rows[2].Cells[3].Value = "";
            rowMergeView2.Rows[2].Cells[4].Value = "";
            rowMergeView2.Rows[2].Cells[5].Value = "0";

        }

        /// <summary>
        /// 污泥参数表格初始化
        /// </summary>
        public void WNCS_Table()
        {
            rowMergeView3.Rows.Add();
            rowMergeView3.Rows[0].Cells[0].Value = "单位";
            rowMergeView3.Rows[0].Cells[1].Value = "d－1";
            rowMergeView3.Rows[0].Cells[2].Value = "kg/d";
            rowMergeView3.Rows[0].Cells[3].Value = "kg/d";
            rowMergeView3.Rows[0].Cells[4].Value = "kg/d";
            rowMergeView3.Rows[0].Cells[5].Value = "g/L";
            rowMergeView3.Rows[0].Cells[6].Value = "g/L";
            rowMergeView3.Rows[0].Cells[7].Value = "d-1";
            rowMergeView3.Rows[0].Cells[8].Value = "d-1";

            rowMergeView3.Rows.Add();
            rowMergeView3.Rows[1].Cells[0].Value = "计算结果";
            rowMergeView3.Rows[1].Cells[1].Value = "0";
            rowMergeView3.Rows[1].Cells[2].Value = "0";
            rowMergeView3.Rows[1].Cells[3].Value = "0";
            rowMergeView3.Rows[1].Cells[4].Value = "0";
            rowMergeView3.Rows[1].Cells[5].Value = "0";
            rowMergeView3.Rows[1].Cells[6].Value = "0";
            rowMergeView3.Rows[1].Cells[7].Value = "0";
            rowMergeView3.Rows[1].Cells[8].Value = "0";

            rowMergeView3.Rows.Add();
            rowMergeView3.Rows[2].Cells[0].Value = "矫正值";
            rowMergeView3.Rows[2].Cells[1].Value = "0";
            rowMergeView3.Rows[2].Cells[2].Value = "";
            rowMergeView3.Rows[2].Cells[3].Value = "";
            rowMergeView3.Rows[2].Cells[4].Value = "";
            rowMergeView3.Rows[2].Cells[5].Value = "";
            rowMergeView3.Rows[2].Cells[6].Value = "";
            rowMergeView3.Rows[2].Cells[7].Value = "0";
            rowMergeView3.Rows[2].Cells[8].Value = "";
        }

        /// <summary>
        /// 曝气参数表格初始化
        /// </summary>
        public void BQCS_Table()
        {
            rowMergeView4.Rows.Add();
            rowMergeView4.Rows[0].Cells[0].Value = "单位";
            rowMergeView4.Rows[0].Cells[1].Value = "kgO2/d";
            rowMergeView4.Rows[0].Cells[2].Value = "m";
            rowMergeView4.Rows[0].Cells[3].Value = "%";
            rowMergeView4.Rows[0].Cells[4].Value = "%";
            rowMergeView4.Rows[0].Cells[5].Value = "m³/min";
            rowMergeView4.Rows[0].Cells[6].Value = "m³/min";
            rowMergeView4.Rows[0].Cells[7].Value = "m³/min";
            rowMergeView4.Rows[0].Cells[8].Value = "m³/min";
            rowMergeView4.Rows[0].Cells[9].Value = "℃"; //温度
            rowMergeView4.Rows[0].Cells[10].Value = "m³/m³h"; //调节池曝气强度D50

            rowMergeView4.Rows.Add(); rowMergeView4.Rows[1].Cells[0].Value = "计算结果";
            rowMergeView4.Rows[1].Cells[1].Value = "0";
            rowMergeView4.Rows[1].Cells[2].Value = "0";
            rowMergeView4.Rows[1].Cells[3].Value = "0";
            rowMergeView4.Rows[1].Cells[4].Value = "0";
            rowMergeView4.Rows[1].Cells[5].Value = "0";
            rowMergeView4.Rows[1].Cells[6].Value = "0";
            rowMergeView4.Rows[1].Cells[7].Value = "0";
            rowMergeView4.Rows[1].Cells[8].Value = "0";
            rowMergeView4.Rows[1].Cells[9].Value = "0";
            rowMergeView4.Rows[1].Cells[10].Value = "0";

            rowMergeView4.Rows.Add(); rowMergeView4.Rows[2].Cells[0].Value = "矫正值";
            //rowMergeView4.Rows[2].Cells[1].Value = "0";
            //rowMergeView4.Rows[2].Cells[2].Value = "0";
            rowMergeView4.Rows[2].Cells[3].Value = "0";
            rowMergeView4.Rows[2].Cells[4].Value = "0";
            //rowMergeView4.Rows[2].Cells[5].Value = "0";
            //rowMergeView4.Rows[2].Cells[6].Value = "0";
            //rowMergeView4.Rows[2].Cells[7].Value = "0";
            //rowMergeView4.Rows[2].Cells[8].Value = "0";
            //rowMergeView4.Rows[2].Cells[9].Value = "0";
            //rowMergeView4.Rows[2].Cells[10].Value = "0";

        }

        /// <summary>
        /// 设备参数表格初始化
        /// </summary>
        public void SBCS_Table()
        {
            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[0].Cells[0].Value = "水箱/水池"; //设备名称1
            rowMergeView5.Rows[0].Cells[1].Value = "";     //设备名称2
            rowMergeView5.Rows[0].Cells[2].Value = "";     //型号
            rowMergeView5.Rows[0].Cells[3].Value = "";     //参数
            rowMergeView5.Rows[0].Cells[4].Value = "";     //单位
            rowMergeView5.Rows[0].Cells[5].Value = "";     //参数值
            rowMergeView5.Rows[0].Cells[6].Value = "";     //数量

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[1].Cells[0].Value = "设备箱";
            rowMergeView5.Rows[1].Cells[1].Value = "";
            rowMergeView5.Rows[1].Cells[2].Value = "";
            rowMergeView5.Rows[1].Cells[3].Value = "";
            rowMergeView5.Rows[1].Cells[4].Value = "";
            rowMergeView5.Rows[1].Cells[5].Value = "";
            rowMergeView5.Rows[1].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[2].Cells[0].Value = "预处理单元";
            rowMergeView5.Rows[2].Cells[1].Value = "格栅";
            rowMergeView5.Rows[2].Cells[2].Value = "";
            rowMergeView5.Rows[2].Cells[3].Value = "";
            rowMergeView5.Rows[2].Cells[4].Value = "";
            rowMergeView5.Rows[2].Cells[5].Value = "";
            rowMergeView5.Rows[2].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[3].Cells[0].Value = "预处理单元";
            rowMergeView5.Rows[3].Cells[1].Value = "调节池出水泵";
            rowMergeView5.Rows[3].Cells[2].Value = "";
            rowMergeView5.Rows[3].Cells[3].Value = "";
            rowMergeView5.Rows[3].Cells[4].Value = "";
            rowMergeView5.Rows[3].Cells[5].Value = "";
            rowMergeView5.Rows[3].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[4].Cells[0].Value = "污水处理单元";
            rowMergeView5.Rows[4].Cells[1].Value = "鼓风机";
            rowMergeView5.Rows[4].Cells[2].Value = "";
            rowMergeView5.Rows[4].Cells[3].Value = "";
            rowMergeView5.Rows[4].Cells[4].Value = "";
            rowMergeView5.Rows[4].Cells[5].Value = "";
            rowMergeView5.Rows[4].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[5].Cells[0].Value = "污水处理单元";
            rowMergeView5.Rows[5].Cells[1].Value = "膜出水泵";
            rowMergeView5.Rows[5].Cells[2].Value = "";
            rowMergeView5.Rows[5].Cells[3].Value = "";
            rowMergeView5.Rows[5].Cells[4].Value = "";
            rowMergeView5.Rows[5].Cells[5].Value = "";
            rowMergeView5.Rows[5].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[6].Cells[0].Value = "污水处理单元";
            rowMergeView5.Rows[6].Cells[1].Value = "回流泵";
            rowMergeView5.Rows[6].Cells[2].Value = "";
            rowMergeView5.Rows[6].Cells[3].Value = "";
            rowMergeView5.Rows[6].Cells[4].Value = "";
            rowMergeView5.Rows[6].Cells[5].Value = "";
            rowMergeView5.Rows[6].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[7].Cells[0].Value = "污水处理单元";
            rowMergeView5.Rows[7].Cells[1].Value = "膜组件";
            rowMergeView5.Rows[7].Cells[2].Value = "";
            rowMergeView5.Rows[7].Cells[3].Value = "";
            rowMergeView5.Rows[7].Cells[4].Value = "";
            rowMergeView5.Rows[7].Cells[5].Value = "";
            rowMergeView5.Rows[7].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[8].Cells[0].Value = "污泥处理单元";
            rowMergeView5.Rows[8].Cells[1].Value = "MSTD出水泵";
            rowMergeView5.Rows[8].Cells[2].Value = "";
            rowMergeView5.Rows[8].Cells[3].Value = "";
            rowMergeView5.Rows[8].Cells[4].Value = "";
            rowMergeView5.Rows[8].Cells[5].Value = "";
            rowMergeView5.Rows[8].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[9].Cells[0].Value = "污泥处理单元";
            rowMergeView5.Rows[9].Cells[1].Value = "排泥泵";
            rowMergeView5.Rows[9].Cells[2].Value = "";
            rowMergeView5.Rows[9].Cells[3].Value = "";
            rowMergeView5.Rows[9].Cells[4].Value = "";
            rowMergeView5.Rows[9].Cells[5].Value = "";
            rowMergeView5.Rows[9].Cells[6].Value = "";

            rowMergeView5.Rows.Add();
            rowMergeView5.Rows[10].Cells[0].Value = "污泥处理单元";
            rowMergeView5.Rows[10].Cells[1].Value = "MSTD膜组件";
            rowMergeView5.Rows[10].Cells[2].Value = "";
            rowMergeView5.Rows[10].Cells[3].Value = "";
            rowMergeView5.Rows[10].Cells[4].Value = "";
            rowMergeView5.Rows[10].Cells[5].Value = "";
            rowMergeView5.Rows[10].Cells[6].Value = "";
        }

        /// <summary>
        /// 设备尺寸1表格初始化
        /// </summary>
        public void SBCC1_Table()
        {
            /*
            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[0].Cells[0].Value = "单位";
            rowMergeView6.Rows[0].Cells[1].Value = "";
            rowMergeView6.Rows[0].Cells[2].Value = "m";
            rowMergeView6.Rows[0].Cells[3].Value = "m";
            rowMergeView6.Rows[0].Cells[4].Value = "m";
            rowMergeView6.Rows[0].Cells[5].Value = "m3";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[1].Cells[0].Value = "反应器";
            rowMergeView6.Rows[1].Cells[1].Value = "总尺寸";
            rowMergeView6.Rows[1].Cells[2].Value = "";
            rowMergeView6.Rows[1].Cells[3].Value = "";
            rowMergeView6.Rows[1].Cells[4].Value = "";
            rowMergeView6.Rows[1].Cells[5].Value = "";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[2].Cells[0].Value = "反应器";
            rowMergeView6.Rows[2].Cells[1].Value = "调节池";
            rowMergeView6.Rows[2].Cells[2].Value = "";
            rowMergeView6.Rows[2].Cells[3].Value = "";
            rowMergeView6.Rows[2].Cells[4].Value = "";
            rowMergeView6.Rows[2].Cells[5].Value = "";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[3].Cells[0].Value = "反应器";
            rowMergeView6.Rows[3].Cells[1].Value = "缺氧池";
            rowMergeView6.Rows[3].Cells[2].Value = "";
            rowMergeView6.Rows[3].Cells[3].Value = "";
            rowMergeView6.Rows[3].Cells[4].Value = "";
            rowMergeView6.Rows[3].Cells[5].Value = "";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[4].Cells[0].Value = "反应器";
            rowMergeView6.Rows[4].Cells[1].Value = "好氧池";
            rowMergeView6.Rows[4].Cells[2].Value = "";
            rowMergeView6.Rows[4].Cells[3].Value = "";
            rowMergeView6.Rows[4].Cells[4].Value = "";
            rowMergeView6.Rows[4].Cells[5].Value = "";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[5].Cells[0].Value = "反应器";
            rowMergeView6.Rows[5].Cells[1].Value = "MSTD池";
            rowMergeView6.Rows[5].Cells[2].Value = "";
            rowMergeView6.Rows[5].Cells[3].Value = "";
            rowMergeView6.Rows[5].Cells[4].Value = "";
            rowMergeView6.Rows[5].Cells[5].Value = "";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[6].Cells[0].Value = "设备箱";
            rowMergeView6.Rows[6].Cells[1].Value = "参数";
            rowMergeView6.Rows[6].Cells[2].Value = "L（长）";
            rowMergeView6.Rows[6].Cells[3].Value = "B（宽）";
            rowMergeView6.Rows[6].Cells[4].Value = "H（高）";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[7].Cells[0].Value = "单位";
            rowMergeView6.Rows[7].Cells[1].Value = "";
            rowMergeView6.Rows[7].Cells[2].Value = "m";
            rowMergeView6.Rows[7].Cells[3].Value = "m";
            rowMergeView6.Rows[7].Cells[4].Value = "m";

            rowMergeView6.Rows.Add();
            rowMergeView6.Rows[8].Cells[0].Value = "设备箱";
            rowMergeView6.Rows[8].Cells[1].Value = "";
            rowMergeView6.Rows[8].Cells[2].Value = "";
            rowMergeView6.Rows[8].Cells[3].Value = "";
            rowMergeView6.Rows[8].Cells[4].Value = "";
            */


        }

        /// <summary>
        /// 设备尺寸2表格初始化
        /// </summary>
        public void SBCC2_Table()
        {
            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[0].Cells[0].Value = "单位";
            rowMergeView7.Rows[0].Cells[1].Value = "";
            rowMergeView7.Rows[0].Cells[2].Value = "m";
            rowMergeView7.Rows[0].Cells[3].Value = "m";
            rowMergeView7.Rows[0].Cells[4].Value = "m3";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[1].Cells[0].Value = "反应器";
            rowMergeView7.Rows[1].Cells[1].Value = "总尺寸";
            rowMergeView7.Rows[1].Cells[2].Value = "";
            rowMergeView7.Rows[1].Cells[3].Value = "";
            rowMergeView7.Rows[1].Cells[4].Value = "";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[2].Cells[0].Value = "反应器";
            rowMergeView7.Rows[2].Cells[1].Value = "调节池";
            rowMergeView7.Rows[2].Cells[2].Value = "";
            rowMergeView7.Rows[2].Cells[3].Value = "";
            rowMergeView7.Rows[2].Cells[4].Value = "";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[3].Cells[0].Value = "反应器";
            rowMergeView7.Rows[3].Cells[1].Value = "缺氧池";
            rowMergeView7.Rows[3].Cells[2].Value = "";
            rowMergeView7.Rows[3].Cells[3].Value = "";
            rowMergeView7.Rows[3].Cells[4].Value = "";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[4].Cells[0].Value = "反应器";
            rowMergeView7.Rows[4].Cells[1].Value = "好氧池";
            rowMergeView7.Rows[4].Cells[2].Value = "";
            rowMergeView7.Rows[4].Cells[3].Value = "";
            rowMergeView7.Rows[4].Cells[4].Value = "";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[5].Cells[0].Value = "反应器";
            rowMergeView7.Rows[5].Cells[1].Value = "MSTD池";
            rowMergeView7.Rows[5].Cells[2].Value = "";
            rowMergeView7.Rows[5].Cells[3].Value = "";
            rowMergeView7.Rows[5].Cells[4].Value = "";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[6].Cells[0].Value = "设备箱";
            rowMergeView7.Rows[6].Cells[1].Value = "参数";
            rowMergeView7.Rows[6].Cells[2].Value = "L（长）";
            rowMergeView7.Rows[6].Cells[3].Value = "B（宽）";
            rowMergeView7.Rows[6].Cells[4].Value = "H（高）";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[7].Cells[0].Value = "单位";
            rowMergeView7.Rows[7].Cells[1].Value = "";
            rowMergeView7.Rows[7].Cells[2].Value = "m";
            rowMergeView7.Rows[7].Cells[3].Value = "m";
            rowMergeView7.Rows[7].Cells[4].Value = "m";

            rowMergeView7.Rows.Add();
            rowMergeView7.Rows[8].Cells[0].Value = "设备箱";
            rowMergeView7.Rows[8].Cells[1].Value = "";
            rowMergeView7.Rows[8].Cells[2].Value = "";
            rowMergeView7.Rows[8].Cells[3].Value = "";
            rowMergeView7.Rows[8].Cells[4].Value = "";

        }

        /// <summary>
        /// 设备运行能耗表格初始化
        /// </summary>
        public void YXNH_Table()
        {
            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[0].Cells[0].Value = "单位";
            rowMergeView8.Rows[0].Cells[1].Value = "";
            rowMergeView8.Rows[0].Cells[2].Value = "--";
            rowMergeView8.Rows[0].Cells[3].Value = "kw";
            rowMergeView8.Rows[0].Cells[4].Value = "--";
            rowMergeView8.Rows[0].Cells[5].Value = "--";
            rowMergeView8.Rows[0].Cells[6].Value = "kw";
            rowMergeView8.Rows[0].Cells[7].Value = "--";
            rowMergeView8.Rows[0].Cells[8].Value = "kwh";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[1].Cells[0].Value = "预处理单元";
            rowMergeView8.Rows[1].Cells[1].Value = "调节池进水泵";
            rowMergeView8.Rows[1].Cells[2].Value = "";
            rowMergeView8.Rows[1].Cells[3].Value = "";
            rowMergeView8.Rows[1].Cells[4].Value = "";
            rowMergeView8.Rows[1].Cells[5].Value = "";
            rowMergeView8.Rows[1].Cells[6].Value = "";
            rowMergeView8.Rows[1].Cells[7].Value = "";
            rowMergeView8.Rows[1].Cells[8].Value = "";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[2].Cells[0].Value = "污水处理单元";
            rowMergeView8.Rows[2].Cells[1].Value = "鼓风机";
            rowMergeView8.Rows[2].Cells[2].Value = "";
            rowMergeView8.Rows[2].Cells[3].Value = "";
            rowMergeView8.Rows[2].Cells[4].Value = "";
            rowMergeView8.Rows[2].Cells[5].Value = "";
            rowMergeView8.Rows[2].Cells[6].Value = "";
            rowMergeView8.Rows[2].Cells[7].Value = "";
            rowMergeView8.Rows[2].Cells[8].Value = "";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[3].Cells[0].Value = "污水处理单元";
            rowMergeView8.Rows[3].Cells[1].Value = "膜出水泵";
            rowMergeView8.Rows[3].Cells[2].Value = "";
            rowMergeView8.Rows[3].Cells[3].Value = "";
            rowMergeView8.Rows[3].Cells[4].Value = "";
            rowMergeView8.Rows[3].Cells[5].Value = "";
            rowMergeView8.Rows[3].Cells[6].Value = "";
            rowMergeView8.Rows[3].Cells[7].Value = "";
            rowMergeView8.Rows[3].Cells[8].Value = "";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[4].Cells[0].Value = "污水处理单元";
            rowMergeView8.Rows[4].Cells[1].Value = "回流泵";
            rowMergeView8.Rows[4].Cells[2].Value = "";
            rowMergeView8.Rows[4].Cells[3].Value = "";
            rowMergeView8.Rows[4].Cells[4].Value = "";
            rowMergeView8.Rows[4].Cells[5].Value = "";
            rowMergeView8.Rows[4].Cells[6].Value = "";
            rowMergeView8.Rows[4].Cells[7].Value = "";
            rowMergeView8.Rows[4].Cells[8].Value = "";


            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[5].Cells[0].Value = "污泥处理单元";
            rowMergeView8.Rows[5].Cells[1].Value = "MSTD出水泵";
            rowMergeView8.Rows[5].Cells[2].Value = "";
            rowMergeView8.Rows[5].Cells[3].Value = "";
            rowMergeView8.Rows[5].Cells[4].Value = "";
            rowMergeView8.Rows[5].Cells[5].Value = "";
            rowMergeView8.Rows[5].Cells[6].Value = "";
            rowMergeView8.Rows[5].Cells[7].Value = "";
            rowMergeView8.Rows[5].Cells[8].Value = "";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[6].Cells[0].Value = "污泥处理单元";
            rowMergeView8.Rows[6].Cells[1].Value = "排泥泵";
            rowMergeView8.Rows[6].Cells[2].Value = "";
            rowMergeView8.Rows[6].Cells[3].Value = "";
            rowMergeView8.Rows[6].Cells[4].Value = "";
            rowMergeView8.Rows[6].Cells[5].Value = "";
            rowMergeView8.Rows[6].Cells[6].Value = "";
            rowMergeView8.Rows[6].Cells[7].Value = "";
            rowMergeView8.Rows[6].Cells[8].Value = "";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[7].Cells[0].Value = "合计";
            rowMergeView8.Rows[7].Cells[1].Value = "";
            rowMergeView8.Rows[7].Cells[2].Value = "";
            rowMergeView8.Rows[7].Cells[3].Value = "";
            rowMergeView8.Rows[7].Cells[4].Value = "";
            rowMergeView8.Rows[7].Cells[5].Value = "";
            rowMergeView8.Rows[7].Cells[6].Value = "";
            rowMergeView8.Rows[7].Cells[7].Value = "";
            rowMergeView8.Rows[7].Cells[8].Value = "";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[8].Cells[0].Value = "吨水处理能耗";
            rowMergeView8.Rows[8].Cells[1].Value = "(KWh)";
            rowMergeView8.Rows[8].Cells[2].Value = "";
            rowMergeView8.Rows[8].Cells[3].Value = "";
            rowMergeView8.Rows[8].Cells[4].Value = "";
            rowMergeView8.Rows[8].Cells[5].Value = "";
            rowMergeView8.Rows[8].Cells[6].Value = "";
            rowMergeView8.Rows[8].Cells[7].Value = "";
            rowMergeView8.Rows[8].Cells[8].Value = "";

            rowMergeView8.Rows.Add();
            rowMergeView8.Rows[9].Cells[0].Value = "吨水处理电费";
            rowMergeView8.Rows[9].Cells[1].Value = "";
            rowMergeView8.Rows[9].Cells[2].Value = "";
            rowMergeView8.Rows[9].Cells[3].Value = "";
            rowMergeView8.Rows[9].Cells[4].Value = "";
            rowMergeView8.Rows[9].Cells[5].Value = "";
            rowMergeView8.Rows[9].Cells[6].Value = "";
            rowMergeView8.Rows[9].Cells[7].Value = "";
            rowMergeView8.Rows[9].Cells[8].Value = "";

        }

        /// <summary>
        /// 设备投资成本表格初始化
        /// </summary>
        public void TZCB_Table()
        {
            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[0].Cells[0].Value = "水箱/水池";
            rowMergeView9.Rows[0].Cells[1].Value = "";
            rowMergeView9.Rows[0].Cells[2].Value = "";
            rowMergeView9.Rows[0].Cells[3].Value = "";
            rowMergeView9.Rows[0].Cells[4].Value = "";
            rowMergeView9.Rows[0].Cells[5].Value = "";
            rowMergeView9.Rows[0].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[1].Cells[0].Value = "设备箱";
            rowMergeView9.Rows[1].Cells[1].Value = "";
            rowMergeView9.Rows[1].Cells[2].Value = "";
            rowMergeView9.Rows[1].Cells[3].Value = "";
            rowMergeView9.Rows[1].Cells[4].Value = "";
            rowMergeView9.Rows[1].Cells[5].Value = "";
            rowMergeView9.Rows[1].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[2].Cells[0].Value = "预处理单元";
            rowMergeView9.Rows[2].Cells[1].Value = "格栅";
            rowMergeView9.Rows[2].Cells[2].Value = "";
            rowMergeView9.Rows[2].Cells[3].Value = "";
            rowMergeView9.Rows[2].Cells[4].Value = "";
            rowMergeView9.Rows[2].Cells[5].Value = "";
            rowMergeView9.Rows[2].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[3].Cells[0].Value = "预处理单元";
            rowMergeView9.Rows[3].Cells[1].Value = "调节池进水泵";
            rowMergeView9.Rows[3].Cells[2].Value = "";
            rowMergeView9.Rows[3].Cells[3].Value = "";
            rowMergeView9.Rows[3].Cells[4].Value = "";
            rowMergeView9.Rows[3].Cells[5].Value = "";
            rowMergeView9.Rows[3].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[4].Cells[0].Value = "污水处理单元";
            rowMergeView9.Rows[4].Cells[1].Value = "鼓风机";
            rowMergeView9.Rows[4].Cells[2].Value = "";
            rowMergeView9.Rows[4].Cells[3].Value = "";
            rowMergeView9.Rows[4].Cells[4].Value = "";
            rowMergeView9.Rows[4].Cells[5].Value = "";
            rowMergeView9.Rows[4].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[5].Cells[0].Value = "污水处理单元";
            rowMergeView9.Rows[5].Cells[1].Value = "膜出水泵";
            rowMergeView9.Rows[5].Cells[2].Value = "";
            rowMergeView9.Rows[5].Cells[3].Value = "";
            rowMergeView9.Rows[5].Cells[4].Value = "";
            rowMergeView9.Rows[5].Cells[5].Value = "";
            rowMergeView9.Rows[5].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[6].Cells[0].Value = "污水处理单元";
            rowMergeView9.Rows[6].Cells[1].Value = "回流泵";
            rowMergeView9.Rows[6].Cells[2].Value = "";
            rowMergeView9.Rows[6].Cells[3].Value = "";
            rowMergeView9.Rows[6].Cells[4].Value = "";
            rowMergeView9.Rows[6].Cells[5].Value = "";
            rowMergeView9.Rows[6].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[7].Cells[0].Value = "污水处理单元";
            rowMergeView9.Rows[7].Cells[1].Value = "膜组件";
            rowMergeView9.Rows[7].Cells[2].Value = "";
            rowMergeView9.Rows[7].Cells[3].Value = "";
            rowMergeView9.Rows[7].Cells[4].Value = "";
            rowMergeView9.Rows[7].Cells[5].Value = "";
            rowMergeView9.Rows[7].Cells[6].Value = "";


            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[8].Cells[0].Value = "污泥处理单元";
            rowMergeView9.Rows[8].Cells[1].Value = "MSTD出水泵";
            rowMergeView9.Rows[8].Cells[2].Value = "";
            rowMergeView9.Rows[8].Cells[3].Value = "";
            rowMergeView9.Rows[8].Cells[4].Value = "";
            rowMergeView9.Rows[8].Cells[5].Value = "";
            rowMergeView9.Rows[8].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[9].Cells[0].Value = "污泥处理单元";
            rowMergeView9.Rows[9].Cells[1].Value = "MSTD膜组件";
            rowMergeView9.Rows[9].Cells[2].Value = "";
            rowMergeView9.Rows[9].Cells[3].Value = "";
            rowMergeView9.Rows[9].Cells[4].Value = "";
            rowMergeView9.Rows[9].Cells[5].Value = "";
            rowMergeView9.Rows[9].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[10].Cells[0].Value = "污泥处理单元";
            rowMergeView9.Rows[10].Cells[1].Value = "排泥泵";
            rowMergeView9.Rows[10].Cells[2].Value = "";
            rowMergeView9.Rows[10].Cells[3].Value = "";
            rowMergeView9.Rows[10].Cells[4].Value = "";
            rowMergeView9.Rows[10].Cells[5].Value = "";
            rowMergeView9.Rows[10].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[11].Cells[0].Value = "附件";
            rowMergeView9.Rows[11].Cells[1].Value = "管配件";
            rowMergeView9.Rows[11].Cells[2].Value = "";
            rowMergeView9.Rows[11].Cells[3].Value = "";
            rowMergeView9.Rows[11].Cells[4].Value = "";
            rowMergeView9.Rows[11].Cells[5].Value = "";
            rowMergeView9.Rows[11].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[12].Cells[0].Value = "附件";
            rowMergeView9.Rows[12].Cells[1].Value = "电线电缆";
            rowMergeView9.Rows[12].Cells[2].Value = "";
            rowMergeView9.Rows[12].Cells[3].Value = "";
            rowMergeView9.Rows[12].Cells[4].Value = "";
            rowMergeView9.Rows[12].Cells[5].Value = "";
            rowMergeView9.Rows[12].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[13].Cells[0].Value = "以上";
            rowMergeView9.Rows[13].Cells[1].Value = "小计";
            rowMergeView9.Rows[13].Cells[2].Value = "";
            rowMergeView9.Rows[13].Cells[3].Value = "";
            rowMergeView9.Rows[13].Cells[4].Value = "";
            rowMergeView9.Rows[13].Cells[5].Value = "";
            rowMergeView9.Rows[13].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[14].Cells[0].Value = "";
            rowMergeView9.Rows[14].Cells[1].Value = "安装费";
            rowMergeView9.Rows[14].Cells[2].Value = "";
            rowMergeView9.Rows[14].Cells[3].Value = "";
            rowMergeView9.Rows[14].Cells[4].Value = "";
            rowMergeView9.Rows[14].Cells[5].Value = "";
            rowMergeView9.Rows[14].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[15].Cells[0].Value = "";
            rowMergeView9.Rows[15].Cells[1].Value = "调试费";
            rowMergeView9.Rows[15].Cells[2].Value = "";
            rowMergeView9.Rows[15].Cells[3].Value = "";
            rowMergeView9.Rows[15].Cells[4].Value = "";
            rowMergeView9.Rows[15].Cells[5].Value = "";
            rowMergeView9.Rows[15].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[16].Cells[0].Value = "";
            rowMergeView9.Rows[16].Cells[1].Value = "合计";
            rowMergeView9.Rows[16].Cells[2].Value = "";
            rowMergeView9.Rows[16].Cells[3].Value = "";
            rowMergeView9.Rows[16].Cells[4].Value = "";
            rowMergeView9.Rows[16].Cells[5].Value = "";
            rowMergeView9.Rows[16].Cells[6].Value = "";

            rowMergeView9.Rows.Add();
            rowMergeView9.Rows[17].Cells[0].Value = "";
            rowMergeView9.Rows[17].Cells[1].Value = "总合计";
            rowMergeView9.Rows[17].Cells[2].Value = "";
            rowMergeView9.Rows[17].Cells[3].Value = "";
            rowMergeView9.Rows[17].Cells[4].Value = "";
            rowMergeView9.Rows[17].Cells[5].Value = "";
            rowMergeView9.Rows[17].Cells[6].Value = "";



        }
        //------------
        /// <summary>
        /// 设备报价一览表格初始化
        /// </summary>
        public void SBBJ_Table()
        {
            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[0].Cells[0].Value = "水箱/水池";
            rowMergeView10.Rows[0].Cells[1].Value = "";
            rowMergeView10.Rows[0].Cells[2].Value = "";
            rowMergeView10.Rows[0].Cells[3].Value = "";
            rowMergeView10.Rows[0].Cells[4].Value = "";
            rowMergeView10.Rows[0].Cells[5].Value = "";
            rowMergeView10.Rows[0].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[1].Cells[0].Value = "设备箱";
            rowMergeView10.Rows[1].Cells[1].Value = "";
            rowMergeView10.Rows[1].Cells[2].Value = "";
            rowMergeView10.Rows[1].Cells[3].Value = "";
            rowMergeView10.Rows[1].Cells[4].Value = "";
            rowMergeView10.Rows[1].Cells[5].Value = "";
            rowMergeView10.Rows[1].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[2].Cells[0].Value = "预处理单元";
            rowMergeView10.Rows[2].Cells[1].Value = "格栅";
            rowMergeView10.Rows[2].Cells[2].Value = "";
            rowMergeView10.Rows[2].Cells[3].Value = "";
            rowMergeView10.Rows[2].Cells[4].Value = "";
            rowMergeView10.Rows[2].Cells[5].Value = "";
            rowMergeView10.Rows[2].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[3].Cells[0].Value = "预处理单元";
            rowMergeView10.Rows[3].Cells[1].Value = "调节池进水泵";
            rowMergeView10.Rows[3].Cells[2].Value = "";
            rowMergeView10.Rows[3].Cells[3].Value = "";
            rowMergeView10.Rows[3].Cells[4].Value = "";
            rowMergeView10.Rows[3].Cells[5].Value = "";
            rowMergeView10.Rows[3].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[4].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[4].Cells[1].Value = "鼓风机";
            rowMergeView10.Rows[4].Cells[2].Value = "";
            rowMergeView10.Rows[4].Cells[3].Value = "";
            rowMergeView10.Rows[4].Cells[4].Value = "";
            rowMergeView10.Rows[4].Cells[5].Value = "";
            rowMergeView10.Rows[4].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[5].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[5].Cells[1].Value = "膜出水泵";
            rowMergeView10.Rows[5].Cells[2].Value = "";
            rowMergeView10.Rows[5].Cells[3].Value = "";
            rowMergeView10.Rows[5].Cells[4].Value = "";
            rowMergeView10.Rows[5].Cells[5].Value = "";
            rowMergeView10.Rows[5].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[6].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[6].Cells[1].Value = "回流泵";
            rowMergeView10.Rows[6].Cells[2].Value = "";
            rowMergeView10.Rows[6].Cells[3].Value = "";
            rowMergeView10.Rows[6].Cells[4].Value = "";
            rowMergeView10.Rows[6].Cells[5].Value = "";
            rowMergeView10.Rows[6].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[7].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[7].Cells[1].Value = "膜组件";
            rowMergeView10.Rows[7].Cells[2].Value = "";
            rowMergeView10.Rows[7].Cells[3].Value = "";
            rowMergeView10.Rows[7].Cells[4].Value = "";
            rowMergeView10.Rows[7].Cells[5].Value = "";
            rowMergeView10.Rows[7].Cells[6].Value = "";


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[8].Cells[0].Value = "污泥处理单元";
            rowMergeView10.Rows[8].Cells[1].Value = "MSTD出水泵";
            rowMergeView10.Rows[8].Cells[2].Value = "";
            rowMergeView10.Rows[8].Cells[3].Value = "";
            rowMergeView10.Rows[8].Cells[4].Value = "";
            rowMergeView10.Rows[8].Cells[5].Value = "";
            rowMergeView10.Rows[8].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[9].Cells[0].Value = "污泥处理单元";
            rowMergeView10.Rows[9].Cells[1].Value = "MSTD膜组件";
            rowMergeView10.Rows[9].Cells[2].Value = "";
            rowMergeView10.Rows[9].Cells[3].Value = "";
            rowMergeView10.Rows[9].Cells[4].Value = "";
            rowMergeView10.Rows[9].Cells[5].Value = "";
            rowMergeView10.Rows[9].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[10].Cells[0].Value = "污泥处理单元";
            rowMergeView10.Rows[10].Cells[1].Value = "排泥泵";
            rowMergeView10.Rows[10].Cells[2].Value = "";
            rowMergeView10.Rows[10].Cells[3].Value = "";
            rowMergeView10.Rows[10].Cells[4].Value = "";
            rowMergeView10.Rows[10].Cells[5].Value = "";
            rowMergeView10.Rows[10].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[11].Cells[0].Value = "附件";
            rowMergeView10.Rows[11].Cells[1].Value = "管配件";
            rowMergeView10.Rows[11].Cells[2].Value = "";
            rowMergeView10.Rows[11].Cells[3].Value = "";
            rowMergeView10.Rows[11].Cells[4].Value = "";
            rowMergeView10.Rows[11].Cells[5].Value = "";
            rowMergeView10.Rows[11].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[12].Cells[0].Value = "附件";
            rowMergeView10.Rows[12].Cells[1].Value = "电线电缆";
            rowMergeView10.Rows[12].Cells[2].Value = "";
            rowMergeView10.Rows[12].Cells[3].Value = "";
            rowMergeView10.Rows[12].Cells[4].Value = "";
            rowMergeView10.Rows[12].Cells[5].Value = "";
            rowMergeView10.Rows[12].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[13].Cells[0].Value = "以上";
            rowMergeView10.Rows[13].Cells[1].Value = "小计";
            rowMergeView10.Rows[13].Cells[2].Value = "";
            rowMergeView10.Rows[13].Cells[3].Value = "";
            rowMergeView10.Rows[13].Cells[4].Value = "";
            rowMergeView10.Rows[13].Cells[5].Value = "";
            rowMergeView10.Rows[13].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[14].Cells[0].Value = "";
            rowMergeView10.Rows[14].Cells[1].Value = "安装费";
            rowMergeView10.Rows[14].Cells[2].Value = "";
            rowMergeView10.Rows[14].Cells[3].Value = "";
            rowMergeView10.Rows[14].Cells[4].Value = "";
            rowMergeView10.Rows[14].Cells[5].Value = "";
            rowMergeView10.Rows[14].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[15].Cells[0].Value = "";
            rowMergeView10.Rows[15].Cells[1].Value = "调试费";
            rowMergeView10.Rows[15].Cells[2].Value = "";
            rowMergeView10.Rows[15].Cells[3].Value = "";
            rowMergeView10.Rows[15].Cells[4].Value = "";
            rowMergeView10.Rows[15].Cells[5].Value = "";
            rowMergeView10.Rows[15].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[16].Cells[0].Value = "";
            rowMergeView10.Rows[16].Cells[1].Value = "合计";
            rowMergeView10.Rows[16].Cells[2].Value = "";
            rowMergeView10.Rows[16].Cells[3].Value = "";
            rowMergeView10.Rows[16].Cells[4].Value = "";
            rowMergeView10.Rows[16].Cells[5].Value = "";
            rowMergeView10.Rows[16].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[17].Cells[0].Value = "";
            rowMergeView10.Rows[17].Cells[1].Value = "税额";
            rowMergeView10.Rows[17].Cells[2].Value = "";
            rowMergeView10.Rows[17].Cells[3].Value = "";
            rowMergeView10.Rows[17].Cells[4].Value = "";
            rowMergeView10.Rows[17].Cells[5].Value = "";
            rowMergeView10.Rows[17].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[18].Cells[0].Value = "";
            rowMergeView10.Rows[18].Cells[1].Value = "小计";
            rowMergeView10.Rows[18].Cells[2].Value = "";
            rowMergeView10.Rows[18].Cells[3].Value = "";
            rowMergeView10.Rows[18].Cells[4].Value = "";
            rowMergeView10.Rows[18].Cells[5].Value = "";
            rowMergeView10.Rows[18].Cells[6].Value = "";

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[19].Cells[0].Value = "";
            rowMergeView10.Rows[19].Cells[1].Value = "总合计";
            rowMergeView10.Rows[19].Cells[2].Value = "";
            rowMergeView10.Rows[19].Cells[3].Value = "";
            rowMergeView10.Rows[19].Cells[4].Value = "";
            rowMergeView10.Rows[19].Cells[5].Value = "";
            rowMergeView10.Rows[19].Cells[6].Value = "";



        }

        private void rowMergeView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (rowMergeView1.CurrentCell.ColumnIndex == 1 || rowMergeView1.CurrentCell.ColumnIndex == 4 ||
                rowMergeView1.CurrentCell.ColumnIndex == 6 || rowMergeView1.CurrentCell.ColumnIndex == 7 || rowMergeView1.CurrentCell.ColumnIndex == 13)
            {
                if (rowMergeView1.CurrentCell.RowIndex == 0 || rowMergeView1.CurrentCell.RowIndex == 1)
                {
                    rowMergeView1.CurrentCell.ReadOnly = true;
                }
                else
                {
                    rowMergeView1.CurrentCell.ReadOnly = false;
                }
            }
            else
            {
                rowMergeView1.CurrentCell.ReadOnly = true;
            }

        }

        private void rowMergeView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (rowMergeView2.CurrentCell.ColumnIndex == 1 || rowMergeView2.CurrentCell.ColumnIndex == 2 || rowMergeView2.CurrentCell.ColumnIndex == 5)
            {
                if (rowMergeView2.CurrentCell.RowIndex == 0 || rowMergeView2.CurrentCell.RowIndex == 1)
                {
                    rowMergeView2.CurrentCell.ReadOnly = true;
                }
                else
                {
                    rowMergeView2.CurrentCell.ReadOnly = false;
                }
            }
            else
            {
                rowMergeView2.CurrentCell.ReadOnly = true;
            }
        }

        private void rowMergeView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (rowMergeView4.CurrentCell.ColumnIndex == 3 || rowMergeView4.CurrentCell.ColumnIndex == 4)
            {
                if (rowMergeView4.CurrentCell.RowIndex == 0 || rowMergeView4.CurrentCell.RowIndex == 1)
                {
                    rowMergeView4.CurrentCell.ReadOnly = true;
                }
                else
                {
                    rowMergeView4.CurrentCell.ReadOnly = false;
                }
            }
            else
            {
                rowMergeView4.CurrentCell.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rowMergeView10.Rows.Clear();
            rowMergeView11.Rows.Clear();
            rowMergeView10.Refresh();
            rowMergeView11.Refresh();

            double D1_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D1'")[0][2]);
            double F1_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='F1'")[0][2]);
            double D8_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D8'")[0][2]);
            double C4_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='C4'")[0][2]);
            double D4_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D4'")[0][2]);
            double E4_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='E4'")[0][2]);
            double F4_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='F4'")[0][2]);
            double G4_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='G4'")[0][2]);
            double H4_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='H4'")[0][2]);
            double C7_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='C7'")[0][2]);
            double D7_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D7'")[0][2]);
            double E7_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='E7'")[0][2]);
            double F7_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='F7'")[0][2]);
            double G7_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='G7'")[0][2]);
            double H7_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='H7'")[0][2]);
            
            double D9_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D9'")[0][2]);
            double D11_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D11'")[0][2]);
            double D45_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D45'")[0][2]);
            double I9_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='I9'")[0][2]);
            double H49_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='H49'")[0][2]);
            double K11_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='K11'")[0][2]);
            double K12_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='K12'")[0][2]);

            string p1_2 = textBox1.Text;
            string p2_2 = textBox2.Text;
            string p3_2 = textBox3.Text;
            double D41_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D41'")[0][2]);
            double I18_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='I18'")[0][2]);
            double K9_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='K9'")[0][2]);
            double K39_2 = 0.00;
            double I35_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='I35'")[0][2]);
            double I33_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='I33'")[0][2]);
            double D29_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D29'")[0][2]);
            double D27_2 = Convert.ToDouble(dt.Select("BS='BQ' AND WZ='D27'")[0][2]);
            double D58_2 = Convert.ToDouble(dt.Select("BS='BQ' AND WZ='D58'")[0][2]);
            double D33_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D33'")[0][2]);
            double D50_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D50'")[0][2]);
            double D39_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='D39'")[0][2]);
            double I10_2 =  Convert.ToDouble(dt.Select("BS='SJ' AND WZ='I10'")[0][2]);
            double I13_2 = Convert.ToDouble(dt.Select("BS='SJ' AND WZ='I13'")[0][2]);
           

            D45_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[1].Value);
            D41_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[4].Value);
            I18_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[6].Value);
            K9_2  = Convert.ToDouble(rowMergeView1.Rows[2].Cells[7].Value);
            D39_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[13].Value);
            D11_2 = Convert.ToDouble(rowMergeView2.Rows[2].Cells[1].Value);
            D9_2  = Convert.ToDouble(rowMergeView2.Rows[2].Cells[2].Value);
            I35_2 = Convert.ToDouble(rowMergeView2.Rows[2].Cells[5].Value);
            I33_2 = Convert.ToDouble(rowMergeView3.Rows[2].Cells[1].Value);
            D29_2 = Convert.ToDouble(rowMergeView3.Rows[2].Cells[7].Value);


            double BQ_D27_2 = Convert.ToDouble(rowMergeView4.Rows[2].Cells[3].Value);
            double BQ_D58_2 = Convert.ToDouble(rowMergeView4.Rows[2].Cells[4].Value);

            D27_2 = Convert.ToDouble(rowMergeView4.Rows[2].Cells[3].Value);
            D58_2 = Convert.ToDouble(rowMergeView4.Rows[2].Cells[4].Value);

            //D45 -停留时间
            if (Convert.ToDouble(rowMergeView1.Rows[2].Cells[1].Value) == 0)
            {
                D45_2 = Convert.ToDouble(rowMergeView1.Rows[1].Cells[1].Value);
            }
            else
            {
                D45_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[1].Value);
            }

            //D41 -缺氧池
            if (Convert.ToDouble(rowMergeView1.Rows[2].Cells[4].Value) == 0)
            {
                D41_2 = Convert.ToDouble(rowMergeView1.Rows[1].Cells[4].Value);
            }
            else
            {
                D41_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[4].Value);
            }

            I18_FLAG = 0;
            //I18 -好氧池
            if (Convert.ToDouble(rowMergeView1.Rows[2].Cells[6].Value) == 0)
            {
                I18_2 = Convert.ToDouble(rowMergeView1.Rows[1].Cells[6].Value);
            }
            else
            {
                I18_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[6].Value);
                I18_FLAG = 1;
            }

            //K9 -膜通量
            if (Convert.ToDouble(rowMergeView1.Rows[2].Cells[7].Value) == 0)
            {
                K9_2 = Convert.ToDouble(rowMergeView1.Rows[1].Cells[7].Value);
            }
            else
            {
                K9_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[7].Value);
            }
            //D39 曝气强度
            if (Convert.ToDouble(rowMergeView1.Rows[2].Cells[13].Value) == 0)
            {
                D39_2 = Convert.ToDouble(rowMergeView1.Rows[1].Cells[13].Value);
            }
            else
            {
                D39_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[13].Value);
            }
            //D11 ncod
            if (Convert.ToDouble(rowMergeView2.Rows[2].Cells[1].Value) == 0)
            {
                D11_2 = Convert.ToDouble(rowMergeView2.Rows[1].Cells[1].Value);
            }
            else
            {
                D11_2 = Convert.ToDouble(rowMergeView2.Rows[2].Cells[1].Value);
            }

            //D9 NNH3-N
            if (Convert.ToDouble(rowMergeView2.Rows[2].Cells[2].Value) == 0)
            {
                D9_2 = Convert.ToDouble(rowMergeView2.Rows[1].Cells[2].Value);
            }
            else
            {
                D9_2 = Convert.ToDouble(rowMergeView2.Rows[2].Cells[2].Value);
            }
            //I35 Kde(20)
            if (Convert.ToDouble(rowMergeView2.Rows[2].Cells[5].Value) == 0)
            {
                I35_2 = Convert.ToDouble(rowMergeView2.Rows[1].Cells[5].Value);
            }
            else
            {
                I35_2 = Convert.ToDouble(rowMergeView2.Rows[2].Cells[5].Value);
            }
            //I33 Kd(20)
            if (Convert.ToDouble(rowMergeView3.Rows[2].Cells[1].Value) == 0)
            {
                I33_2 = Convert.ToDouble(rowMergeView3.Rows[1].Cells[1].Value);
            }
            else
            {
                I33_2 = Convert.ToDouble(rowMergeView3.Rows[2].Cells[1].Value);
            }

            //D29
            if (Convert.ToDouble(rowMergeView3.Rows[2].Cells[7].Value) == 0)
            {
                D29_2 = Convert.ToDouble(rowMergeView3.Rows[1].Cells[7].Value);
            }
            else
            {
                D29_2 = Convert.ToDouble(rowMergeView3.Rows[2].Cells[7].Value);
            }

            //D27  曝气
            if (Convert.ToDouble(rowMergeView4.Rows[2].Cells[3].Value) == 0)
            {
                BQ_D27_2 = Convert.ToDouble(rowMergeView4.Rows[1].Cells[3].Value)/100;
            }
            else
            {
                BQ_D27_2 = Convert.ToDouble(rowMergeView4.Rows[2].Cells[3].Value) / 100;
            }

            //D58  曝气
            if (Convert.ToDouble(rowMergeView4.Rows[2].Cells[4].Value) == 0)
            {
                BQ_D58_2 = Convert.ToDouble(rowMergeView4.Rows[1].Cells[4].Value) / 100;
            }
            else
            {
                BQ_D58_2 = Convert.ToDouble(rowMergeView4.Rows[2].Cells[4].Value)/100;
            }
            //K9
            if (Convert.ToDouble(rowMergeView1.Rows[2].Cells[7].Value) == 0)
            {
                K9_2 = Convert.ToDouble(rowMergeView1.Rows[1].Cells[7].Value);
            }
            else
            {
                K9_2 = Convert.ToDouble(rowMergeView1.Rows[2].Cells[7].Value);
            }




            DataTable jsdt_2 =
                new JS().SS_DT_2(
                p1_2, p2_2, p3_2,
                D1_2, F1_2, D8_2, C4_2, D4_2, E4_2, F4_2, G4_2, H4_2, C7_2, D7_2, E7_2, F7_2, G7_2, H7_2, D9_2, D11_2, D45_2, I9_2, H49_2, K11_2, K12_2,
                D45_2, D41_2,
                I18_2, K9_2, K39_2, D11_2,
                D9_2, I35_2, I33_2, D29_2,
                BQ_D27_2, BQ_D58_2, D33_2, D50_2, D39_2, I10_2, I13_2, K11_2, dt,I18_FLAG
                );
            ReTable(jsdt_2);
            D17_FLAG = 0;
            D17_FLAG = 0;
            System_sj(jsdt_2);
            Dtwd_DT(2, jsdt_2);
            //这是结尾

        }

        private void rowMergeView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (rowMergeView3.CurrentCell.ColumnIndex == 1 || rowMergeView3.CurrentCell.ColumnIndex == 7)
            {
                if (rowMergeView3.CurrentCell.RowIndex == 0 || rowMergeView3.CurrentCell.RowIndex == 1)
                {
                    rowMergeView3.CurrentCell.ReadOnly = true;
                }
                else
                {
                    rowMergeView3.CurrentCell.ReadOnly = false;
                }
            }
            else
            {
                rowMergeView3.CurrentCell.ReadOnly = true;
            }
        }

        public void ReTable(DataTable DT)
        {
            rowMergeView1.Rows[1].Cells[1].Value = DT.Select("BS='SJ' AND WZ='D45'")[0][2];  // 调节池停留时间
            rowMergeView1.Rows[1].Cells[2].Value = DT.Select("BS='SJ' AND WZ='D46'")[0][2];  // 调节池体积
            rowMergeView1.Rows[1].Cells[3].Value = DT.Select("BS='SJ' AND WZ='D42'")[0][2];  // 缺氧池停留时间     
            rowMergeView1.Rows[1].Cells[4].Value = DT.Select("BS='SJ' AND WZ='D41'")[0][2];  // 缺氧池体积
            rowMergeView1.Rows[1].Cells[5].Value = DT.Select("BS='SJ' AND WZ='I19'")[0][2];  // 好氧池停留时间
            rowMergeView1.Rows[1].Cells[6].Value = DT.Select("BS='SJ' AND WZ='I18'")[0][2];  // 好氧池体积
            rowMergeView1.Rows[1].Cells[7].Value = DT.Select("BS='SJ' AND WZ='I9'")[0][2];   // 膜通量
            rowMergeView1.Rows[1].Cells[8].Value = DT.Select("BS='SJ' AND WZ='I10'")[0][2];  // 膜数量
            rowMergeView1.Rows[1].Cells[9].Value = DT.Select("BS='SJ' AND WZ='D43'")[0][2];  // 回流比
            rowMergeView1.Rows[1].Cells[10].Value = DT.Select("BS='SJ' AND WZ='D30'")[0][2]; // 剩余污泥量
            rowMergeView1.Rows[1].Cells[11].Value = DT.Select("BS='SJ' AND WZ='D25'")[0][2]; // 除磷加药量
            rowMergeView1.Rows[1].Cells[12].Value = DT.Select("BS='BQ' AND WZ='D67'")[0][2]; // 曝气量
            rowMergeView1.Rows[1].Cells[13].Value = DT.Select("BS='BQ' AND WZ='D39'")[0][2]; // 曝气强度

            //负荷参数一览表
            rowMergeView2.Rows[1].Cells[1].Value = DT.Select("BS='SJ' AND WZ='D17'")[0][2];
            rowMergeView2.Rows[1].Cells[2].Value = DT.Select("BS='SJ' AND WZ='D18'")[0][2];
            rowMergeView2.Rows[1].Cells[3].Value = DT.Select("BS='SJ' AND WZ='D15'")[0][2];
            rowMergeView2.Rows[1].Cells[4].Value = DT.Select("BS='SJ' AND WZ='D16'")[0][2];
            rowMergeView2.Rows[1].Cells[5].Value = DT.Select("BS='SJ' AND WZ='I35'")[0][2];


            //污泥参数一览表
            rowMergeView3.Rows[1].Cells[1].Value = DT.Select("BS='SJ' AND WZ='I33'")[0][2];
            rowMergeView3.Rows[1].Cells[2].Value = DT.Select("BS='SJ' AND WZ='D34'")[0][2];
            rowMergeView3.Rows[1].Cells[3].Value = DT.Select("BS='SJ' AND WZ='D38'")[0][2];
            rowMergeView3.Rows[1].Cells[4].Value = DT.Select("BS='SJ' AND WZ='D24'")[0][2];
            rowMergeView3.Rows[1].Cells[5].Value = DT.Select("BS='SJ' AND WZ='D36'")[0][2];
            rowMergeView3.Rows[1].Cells[6].Value = DT.Select("BS='SJ' AND WZ='D19'")[0][2];
            rowMergeView3.Rows[1].Cells[7].Value = DT.Select("BS='SJ' AND WZ='D29'")[0][2];
            rowMergeView3.Rows[1].Cells[8].Value = DT.Select("BS='SJ' AND WZ='D26'")[0][2];
            //曝气参数一览表
            rowMergeView4.Rows[1].Cells[1].Value = DT.Select("BS='BQ' AND WZ='D1'")[0][2];
            rowMergeView4.Rows[1].Cells[2].Value = DT.Select("BS='BQ' AND WZ='D24'")[0][2];
            rowMergeView4.Rows[1].Cells[3].Value = (double.Parse(DT.Select("BS='BQ' AND WZ='D27'")[0][2].ToString()) * 100).ToString("0.00");
            rowMergeView4.Rows[1].Cells[4].Value = (double.Parse(DT.Select("BS='BQ' AND WZ='D58'")[0][2].ToString()) * 100).ToString("0.00");
            rowMergeView4.Rows[1].Cells[5].Value = DT.Select("BS='BQ' AND WZ='D43'")[0][2];//Gsc
            rowMergeView4.Rows[1].Cells[6].Value = DT.Select("BS='BQ' AND WZ='D66'")[0][2];//Gsw
            rowMergeView4.Rows[1].Cells[7].Value = DT.Select("BS='BQ' AND WZ='D67'")[0][2];//Gs
            rowMergeView4.Rows[1].Cells[8].Value = DT.Select("BS='BQ' AND WZ='D68'")[0][2];
            rowMergeView4.Rows[1].Cells[9].Value = DT.Select("BS='BQ' AND WZ='D33'")[0][2];
            rowMergeView4.Rows[1].Cells[10].Value = DT.Select("BS='SJ' AND WZ='D50'")[0][2];

            string sb_D1 = DT.Select("BS='SJ' AND WZ='D1'")[0][2].ToString();
            string sb_D45 = DT.Select("BS='SJ' AND WZ='D45'")[0][2].ToString();
            string sb_D48 = DT.Select("BS='SJ' AND WZ='D48'")[0][2].ToString();
            string sb_D49 = DT.Select("BS='SJ' AND WZ='D49'")[0][2].ToString();
            string sb_D50 = DT.Select("BS='SJ' AND WZ='D50'")[0][2].ToString();
            string sb_K11 = DT.Select("BS='SJ' AND WZ='K11'")[0][2].ToString();
            string sb_K12 = DT.Select("BS='SJ' AND WZ='K12'")[0][2].ToString();
            string sb_D30 = DT.Select("BS='SJ' AND WZ='D30'")[0][2].ToString();
            string sb_I10 = DT.Select("BS='SJ' AND WZ='I10'")[0][2].ToString();
            string sb_I19 = DT.Select("BS='SJ' AND WZ='I19'")[0][2].ToString();
            string sb_D42 = DT.Select("BS='SJ' AND WZ='D42'")[0][2].ToString();
            B_D1 =  DT.Select("BS='SJ' AND WZ='D1'")[0][2].ToString();
            B_D25 = DT.Select("BS='SJ' AND WZ='D25'")[0][2].ToString();
            B_C4 = DT.Select("BS='SJ' AND WZ='C4'")[0][2].ToString();
            B_C7 = DT.Select("BS='SJ' AND WZ='C7'")[0][2].ToString();
            B_D4 = DT.Select("BS='SJ' AND WZ='D4'")[0][2].ToString();
            B_D7 = DT.Select("BS='SJ' AND WZ='D7'")[0][2].ToString();
            B_E4 = DT.Select("BS='SJ' AND WZ='E4'")[0][2].ToString();
            B_E7 = DT.Select("BS='SJ' AND WZ='E7'")[0][2].ToString();
            B_F4 = DT.Select("BS='SJ' AND WZ='F4'")[0][2].ToString();
            B_F7 = DT.Select("BS='SJ' AND WZ='F7'")[0][2].ToString();
            B_G4 = DT.Select("BS='SJ' AND WZ='G4'")[0][2].ToString();
            B_G7 = DT.Select("BS='SJ' AND WZ='G7'")[0][2].ToString();
            B_H4 = DT.Select("BS='SJ' AND WZ='H4'")[0][2].ToString();
            B_H7 = DT.Select("BS='SJ' AND WZ='H7'")[0][2].ToString();
            TableSet(sb_D1, sb_D45, sb_D48, sb_D49, sb_D50, sb_K11, sb_K12, sb_D30, sb_I10, sb_I19, sb_D42, m_cb3_2, m_cb4_2, m_cb6_2, m_cb8_2, m_cb5_2, m_cb9_2);

        }

        private void rowMergeView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex > 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Height - 1, e.CellBounds.Height - 1);
                //新建一个图标
                System.Drawing.Image img;
                if (e.ColumnIndex == 1)
                {
                    img = (Image)Properties.Resources.h;
                }
                else if (e.ColumnIndex == 2)
                {
                    img = (Image)Properties.Resources.m3;
                }
                else if (e.ColumnIndex == 3)
                {
                    img = (Image)Properties.Resources.h;
                }
                else if (e.ColumnIndex == 4)
                {
                    img = (Image)Properties.Resources.m3;
                }
                else if (e.ColumnIndex == 5)
                {
                    img = (Image)Properties.Resources.h;
                }
                else if (e.ColumnIndex == 6)
                {
                    img = (Image)Properties.Resources.m3;
                }
                else if (e.ColumnIndex == 7)
                {
                    img = (Image)Properties.Resources.Lm2d;
                }
                else if (e.ColumnIndex == 8)
                {
                    img = (Image)Properties.Resources.片;
                }
                else if (e.ColumnIndex == 9)
                {
                    img = (Image)Properties.Resources.BFH;
                }
                else if (e.ColumnIndex == 10)
                {
                    img = (Image)Properties.Resources.m3d;
                }
                else if (e.ColumnIndex == 11)
                {
                    img = (Image)Properties.Resources.kgd;
                }
                else if (e.ColumnIndex == 12)
                {
                    img = (Image)Properties.Resources.m3min;
                }
                else if (e.ColumnIndex == 13)
                {
                    img = (Image)Properties.Resources.m3m2d;
                }
                else if (e.ColumnIndex == 14)
                {
                    img = (Image)Properties.Resources.m3d; //-------------
                }
                else
                {
                    img = (Image)Properties.Resources.m;
                }
                newRect.Width = img.Width;
                newRect.Height = img.Height;
                using (Brush gridBrush = new SolidBrush(this.rowMergeView1.GridColor),
                backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush, 2))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        //划线
                        Point p1 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top);
                        Point p2 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top + e.CellBounds.Height);
                        Point p3 = new Point(e.CellBounds.Left, e.CellBounds.Top + e.CellBounds.Height);
                        Point[] ps = new Point[] { p1, p2, p3 };
                        e.Graphics.DrawLines(gridLinePen, ps);

                        //画图标
                        e.Graphics.DrawImage(img, newRect);
                        //画字符串
                        //  e.Graphics.DrawString("123", e.CellStyle.Font, Brushes.Crimson, e.CellBounds.Left + 20, e.CellBounds.Top, StringFormat.GenericDefault);
                        e.Handled = true;
                    }
                }
            }
        }

        private void rowMergeView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex > 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Height - 1, e.CellBounds.Height - 1);
                //新建一个图标
                System.Drawing.Image img;
                if (e.ColumnIndex == 1)
                {
                    img = (Image)Properties.Resources.kgCODm3d;
                }
                else if (e.ColumnIndex == 2)
                {
                    img = (Image)Properties.Resources.kgNH3_Nm3d;
                }
                else if (e.ColumnIndex == 3)
                {
                    img = (Image)Properties.Resources.kgBOD5m3d;
                }
                else if (e.ColumnIndex == 4)
                {
                    img = (Image)Properties.Resources.kgBOD5kgMLSSd;
                }
                else if (e.ColumnIndex == 5)
                {
                    img = (Image)Properties.Resources.kgNO3_NkgMLSSd;
                }
                else if (e.ColumnIndex == 6)
                {
                    img = (Image)Properties.Resources.m;
                }
                else
                {
                    img = (Image)Properties.Resources.m;
                }
                newRect.Width = img.Width;
                newRect.Height = img.Height;
                using (Brush gridBrush = new SolidBrush(this.rowMergeView2.GridColor),
                backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush, 2))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        //划线
                        Point p1 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top);
                        Point p2 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top + e.CellBounds.Height);
                        Point p3 = new Point(e.CellBounds.Left, e.CellBounds.Top + e.CellBounds.Height);
                        Point[] ps = new Point[] { p1, p2, p3 };
                        e.Graphics.DrawLines(gridLinePen, ps);

                        //画图标
                        e.Graphics.DrawImage(img, newRect);
                        //画字符串
                        //   e.Graphics.DrawString("123", e.CellStyle.Font, Brushes.Crimson, e.CellBounds.Left + 20, e.CellBounds.Top, StringFormat.GenericDefault);
                        e.Handled = true;
                    }
                }
            }
        }

        private void rowMergeView3_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex > 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Height - 1, e.CellBounds.Height - 1);
                //新建一个图标
                System.Drawing.Image img;
                if (e.ColumnIndex == 1)
                {
                    img = (Image)Properties.Resources.d_1;
                }
                else if (e.ColumnIndex == 2)
                {
                    img = (Image)Properties.Resources.kgd;
                }
                else if (e.ColumnIndex == 3)
                {
                    img = (Image)Properties.Resources.kgd;
                }
                else if (e.ColumnIndex == 4)
                {
                    img = (Image)Properties.Resources.kgd;
                }
                else if (e.ColumnIndex == 5)
                {
                    img = (Image)Properties.Resources.kgd;
                }
                else if (e.ColumnIndex == 6)
                {
                    img = (Image)Properties.Resources.kgd;
                }
                else if (e.ColumnIndex == 7)
                {
                    img = (Image)Properties.Resources.d_1;
                }
                else if (e.ColumnIndex == 8)
                {
                    img = (Image)Properties.Resources.d_1;
                }
                else if (e.ColumnIndex == 9)
                {
                    img = (Image)Properties.Resources.m;
                }
                else
                {
                    img = (Image)Properties.Resources.m;
                }
                newRect.Width = img.Width;
                newRect.Height = img.Height;
                using (Brush gridBrush = new SolidBrush(this.rowMergeView3.GridColor),
                backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush, 2))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        //划线
                        Point p1 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top);
                        Point p2 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top + e.CellBounds.Height);
                        Point p3 = new Point(e.CellBounds.Left, e.CellBounds.Top + e.CellBounds.Height);
                        Point[] ps = new Point[] { p1, p2, p3 };
                        e.Graphics.DrawLines(gridLinePen, ps);

                        //画图标
                        e.Graphics.DrawImage(img, newRect);
                        //画字符串
                        // e.Graphics.DrawString("123", e.CellStyle.Font, Brushes.Crimson, e.CellBounds.Left + 20, e.CellBounds.Top, StringFormat.GenericDefault);
                        e.Handled = true;
                    }
                }
            }
        }

        private void rowMergeView4_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == 0 && e.ColumnIndex > 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Height - 1, e.CellBounds.Height - 1);
                //新建一个图标
                System.Drawing.Image img;

                if (e.ColumnIndex == 1)
                {
                    img = (Image)Properties.Resources.kgd;//-------------
                }
                else if (e.ColumnIndex == 2)
                {
                    img = (Image)Properties.Resources.m;
                }
                else if (e.ColumnIndex == 3)
                {
                    img = (Image)Properties.Resources.BFH;
                }
                else if (e.ColumnIndex == 4)
                {
                    img = (Image)Properties.Resources.BFH;
                }
                else if (e.ColumnIndex == 5)
                {
                    img = (Image)Properties.Resources.m3min;
                }
                else if (e.ColumnIndex == 6)
                {
                    img = (Image)Properties.Resources.m3min;
                }
                else if (e.ColumnIndex == 7)
                {
                    img = (Image)Properties.Resources.m3min;
                }
                else if (e.ColumnIndex == 8)
                {
                    img = (Image)Properties.Resources.m3min;
                }
                else if (e.ColumnIndex == 9)
                {
                    img = (Image)Properties.Resources.WD;//
                }
                else if (e.ColumnIndex == 10)
                {
                    img = (Image)Properties.Resources.m3min;
                }
                else if (e.ColumnIndex == 11)
                {
                    img = (Image)Properties.Resources.m;
                }
                else if (e.ColumnIndex == 12)
                {
                    img = (Image)Properties.Resources.m;
                }
                else if (e.ColumnIndex == 13)
                {
                    img = (Image)Properties.Resources.m;
                }
                else if (e.ColumnIndex == 14)
                {
                    img = (Image)Properties.Resources.m;
                }
                else
                {
                    img = (Image)Properties.Resources.m;
                }
                newRect.Width = img.Width;
                newRect.Height = img.Height; using (Brush gridBrush = new SolidBrush(this.rowMergeView4.GridColor),
                 backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush, 2))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        //划线
                        Point p1 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top);
                        Point p2 = new Point(e.CellBounds.Left + e.CellBounds.Width, e.CellBounds.Top + e.CellBounds.Height);
                        Point p3 = new Point(e.CellBounds.Left, e.CellBounds.Top + e.CellBounds.Height);
                        Point[] ps = new Point[] { p1, p2, p3 };
                        e.Graphics.DrawLines(gridLinePen, ps);

                        //画图标
                        e.Graphics.DrawImage(img, newRect);
                        //画字符串
                        //e.Graphics.DrawString("", e.CellStyle.Font, Brushes.Crimson, e.CellBounds.Left + 20, e.CellBounds.Top, StringFormat.GenericDefault);
                        e.Handled = true;
                    }
                }
            }
        }


        public void TableSet(
            string s_D1, string s_D45, string s_D48,string s_D49, string s_D50,
            string s_K11, string s_K12, string s_D30,string s_I10,
            string s_I19,string s_D42,
            string m_cb3, string m_cb4, string m_cb6, string m_cb8, string m_cb5, string m_cb9)
        {
            Main ma = new Main();

            String sbxs = m_cb3;  //设备形式
            String sblx = m_cb4;  //设备类型
            String sbcz = m_cb6;  //设备材质  
            String mzjcs = m_cb8; //膜组件层数
            String sfby = m_cb5; //是否备用
            String sbjf = m_cb9; //设备机房

            //如果选备用~风机，自吸泵，回流泵，        

            #region a3_计算水箱数据
            //如果是土建：1，一体化：2
            String sql_a3 = " from FADB where [TYPE_ALL] = '水箱'";
            if (sbxs == "1")
            {
                sql_a3 = sql_a3 + " AND [0_TYPE_BH] in ('104')";
                switch (mzjcs)
                {
                    case "1":
                        sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('101')";
                        break;
                    case "2":
                        sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('102')";
                        break;
                    case "3":
                        sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('103')";
                        break;
                }                
            }
            else if (sbxs == "2")
            {

                //碳钢+防腐：1 ，不锈钢：2 ，玻璃钢成套设备：3 ,玻璃钢拼装水箱:4，PP:5                
                switch (sbcz)
                {
                    case "1": //1,4 102:碳钢成套设备
                        sql_a3 = sql_a3 + " AND [0_TYPE_BH] in ('108') ";
                        switch (mzjcs)
                        {
                            case "1":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('102') ";
                                break;
                            case "2":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('102') ";
                                break;
                            case "3":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('102') ";
                                break;
                        }
                        break;
                    case "2": //103:不锈钢成套设备
                        sql_a3 = sql_a3 + " AND [0_TYPE_BH] in ('108') ";
                        switch (mzjcs)
                        {
                            case "1":
                                sql_a3 = sql_a3 + "AND [0_SBM_BH] in ('103') ";
                                break;
                            case "2":
                                sql_a3 = sql_a3 + "AND [0_SBM_BH] in ('103') ";
                                break;
                            case "3":
                                sql_a3 = sql_a3 + "AND [0_SBM_BH] in ('103') ";
                                break;
                        }
                        break;
                    case "3": //3,5 101:钢成套设备
                        sql_a3 = sql_a3 + " AND [0_TYPE_BH] in ('108')";
                        switch (mzjcs)
                        {
                            case "1":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('101')";
                                break;
                            case "2":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('101')";
                                break;
                            case "3":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('101')";
                                break;
                        }
                        break;
                    case "4": //1,4 102:碳钢成套设备
                        sql_a3 = sql_a3 + " AND [0_TYPE_BH] in ('108') ";
                        switch (mzjcs)
                        {
                            case "1":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('102') ";
                                break;
                            case "2":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('102') ";
                                break;
                            case "3":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('102') ";
                                break;
                        }
                        break;
                    case "5": //3,5 101:钢成套设备
                        sql_a3 = sql_a3 + " AND [0_TYPE_BH] in ('108') ";
                        switch (mzjcs)
                        {
                            case "1":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('101') ";
                                break;
                            case "2":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('101') ";
                                break;
                            case "3":
                                sql_a3 = sql_a3 + " AND [0_SBM_BH] in ('101') ";
                                break;
                        }
                        break;
                }



            }
            else
            {

            }
            #endregion

            #region a4_计算控制柜
            String sql_a4 = " from FADB where [TYPE_ALL] = '控制柜'";
            switch (sbjf)
            {
                //设备机房:1
                case "1":
                    sql_a4 = sql_a4 + " AND [0_SBM_BH] in ('102')";
                    rowMergeView5.Rows[1].Cells[0].Value = "设备机房";
                    break;
                //设备箱:2
                case "2":
                    sql_a4 = sql_a4 + " AND [0_SBM_BH] in ('101')";
                    rowMergeView5.Rows[1].Cells[0].Value = "设备箱";
                    break;
            }

            #endregion

            #region a5_计算格栅
            String sql_a5 = " from FADB where [TYPE_ALL] = '格栅'";
            #endregion

            #region a6_计算调节池出水泵
            String sql_a6 = " from FADB where [TYPE_ALL] = '调节池出水泵'";

            switch (s_K12)
            {
                //单层支架配套水泵
                case "1":
                    sql_a6 = sql_a6 + " AND [0_SBM_BH] in ('101')";
                    break;
                //两层支架配套水泵
                case "2":
                    sql_a6 = sql_a6 + " AND [0_SBM_BH] in ('102')";
                    break;
                //三层支架配套水泵
                case "3":
                    sql_a6 = sql_a6 + " AND [0_SBM_BH] in ('103')";
                    break;
            }
            #endregion

            #region a7_计算风机
            String sql_a7 = " from FADB where [TYPE_ALL] = '回转式鼓风机'";
            switch (s_K12)
            {
                //单层支架配套风机
                case "1":
                    sql_a7 = sql_a7 + " AND [0_SBM_BH] in ('101')";
                    break;
                //双层支架配套风机
                case "2":
                    sql_a7 = sql_a7 + " AND [0_SBM_BH] in ('102')";
                    break;
                //三层支架配套风机
                case "3":
                    sql_a7 = sql_a7 + " AND [0_SBM_BH] in ('103')";
                    break;
            }
            #endregion

            #region a8_计算自吸泵
            String sql_a8 = " from FADB where [TYPE_ALL] = '自吸泵'";
            #endregion

            #region a9_计算回流泵
            String sql_a9 = " from FADB where [TYPE_ALL] = '回流泵'";
            #endregion

            #region a10_膜组件
            String sql_a10 = " from FADB where [TYPE_ALL] = '膜组件'";
            #endregion

            #region a11_缺氧池搅拌机
            String sql_a11 = " from FADB where [TYPE_ALL] ='缺氧池搅拌机'";
            #endregion

            #region a12_MSTD出水泵
            String sql_a12 = " from FADB where [TYPE_ALL] ='自吸泵'";
            #endregion

            #region a13_排泥泵
            String sql_a13 = " from FADB where [TYPE_ALL] ='调节池出水泵'";
            #endregion

            #region a14_MSTD膜组件
            String sql_a14 = " from FADB where [TYPE_ALL] ='膜组件'";
            #endregion


            string sql_select = "SELECT * ";


            #region 计算a3-水箱
            //最大值为450
            //如果值小于450，那么，执行脚本得出数据。
            //如果大于450，那么循环除，最终得到一个小于450的数字。

            int i_a3 = 0;
            double dou_a3 = 0;
            DataTable dtx_a3 = null;
            string pd_sx_a3 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a3 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();

            if (double.Parse(s_D48) <= double.Parse(pd_sx_a3))
            {
                dou_a3 = double.Parse(s_D48);
                i_a3 = 1;
                dtx_a3 = Helper.GetDataTableFromDB("SELECT TOP 1 * " + sql_a3 + "AND (" + s_D48 + "<= [0_SX]) ORDER BY [0_SX] ASC");
            }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a3 = double.Parse(s_D48) / i;
                    if (dou_a3 > double.Parse(pd_sx_a3))
                    {
                        i_a3 = i;

                    }
                    else
                    {
                        i_a3 = i_a3 + 1;
                        dtx_a3 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a3 + "AND (" + dou_a3 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;

                    }
                }

            }
            #endregion

            #region 计算a4-设备箱
            int i_a4 = 0;
            double dou_a4 = 0;
            DataTable dtx_a4 = null;
            string pd_sx_a4 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a4 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D50) <= double.Parse(pd_sx_a4))
            {
                dou_a4 = double.Parse(s_D50);
                i_a4 = 1;
                dtx_a4 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a4 + "AND (" + s_D50 + "<= [0_SX]) ORDER BY [0_SX] ASC");
                if (sfby == "1")
                {
                    i_a4 = i_a4 + 1;  //备用加1
                }
            }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a4 = double.Parse(s_D50) / i;
                    if (dou_a4 > double.Parse(pd_sx_a4))
                    {
                        i_a4 = i;

                    }
                    else
                    {
                        i_a4 = i_a4 + 1;

                        dtx_a4 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a4 + "AND (" + dou_a4 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        if (sfby == "1")
                        {
                            i_a4 = i_a4 + 1;  //备用加1
                        }
                        break;

                    }
                }

            }
            #endregion

            #region 计算a5-格栅
            int i_a5 = 0;
            double dou_a5 = 0;
            DataTable dtx_a5 = null;
            string pd_sx_a5 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a5 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D1) <= double.Parse(pd_sx_a5))
            {
                dou_a5 = double.Parse(s_D1);
                i_a5 = 1;
                dtx_a5 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a5 + "AND (" + s_D1 + "<= [0_SX]) ORDER BY [0_SX] ASC");
            }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a5 = double.Parse(s_D1) / i;
                    if (dou_a5 > double.Parse(pd_sx_a5))
                    {
                        i_a5 = i;

                    }
                    else
                    {
                        i_a5 = i_a5 + 1;

                        dtx_a5 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a5 + "AND (" + dou_a5 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;

                    }
                }

            }
            #endregion

            #region 计算a6 //判断K12 -调节池出水泵
            int i_a6 = 0;
            double dou_a6 = 0;
            DataTable dtx_a6 = null;
            string pd_sx_a6 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a6 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D1) / 24 <= double.Parse(pd_sx_a6))
            {
                dou_a6 = double.Parse(s_D1) / 24;
                i_a6 = 1;
                dtx_a6 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a6 + "AND (" + double.Parse(s_D1) / 24 + "<= [0_SX]) ORDER BY [0_SX] ASC");
            }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a6 = double.Parse(s_D1) / 24 / i;
                    if (dou_a6 > double.Parse(pd_sx_a6))
                    {
                        i_a6 = i;

                    }
                    else
                    {
                        i_a6 = i_a6 + 1;

                        dtx_a6 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a6 + "AND (" + dou_a6 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;

                    }
                }

            }
            #endregion

            #region 计算a7 // 判断K12 -鼓风机
            int i_a7 = 0;
            double dou_a7 = 0;
            DataTable dtx_a7 = null;
            string pd_sx_a7 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a7 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D50) <= double.Parse(pd_sx_a7))
            {
                dou_a7 = double.Parse(s_D50);
                i_a7 = 1;
                dtx_a7 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a7 + "AND (" + s_D50 + "<= [0_SX]) ORDER BY [0_SX] ASC");
            }
            else
            {
                for (int i = 1; i < 999; ++i)
                {
                    dou_a7 = double.Parse(s_D50) / i;
                    if (dou_a7 > double.Parse(pd_sx_a7))
                    {
                        i_a7 = i;

                    }
                    else
                    {
                        i_a7 = i_a7 + 1;

                        dtx_a7 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a7 + "AND (" + dou_a7 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;

                    }
                }

            }
            #endregion

            #region 计算a8-膜出水泵
            int i_a8 = 0;
            double dou_a8 = 0;
            DataTable dtx_a8 = null;
            string pd_sx_a8 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a8 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D1) / 20 <= double.Parse(pd_sx_a8))
            {
                dou_a8 = double.Parse(s_D1) / 20;
                i_a8 = 1;
                dtx_a8 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a8 + "AND (" + double.Parse(s_D1) / 20 + "<= [0_SX]) ORDER BY [0_SX] ASC");
            }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a8 = double.Parse(s_D1) / 20 * i;
                    if (dou_a8 > double.Parse(pd_sx_a8))
                    {
                        i_a8 = i;

                    }
                    else
                    {
                        i_a8 = i_a8 + 1;

                        dtx_a8 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a8 + "AND (" + dou_a8 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;

                    }
                }

            }
            #endregion

            #region 计算a9-回流泵
            int i_a9 = 0;
            double dou_a9 = 0;
            DataTable dtx_a9 = null;
            string pd_sx_a9 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a9 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D45) <= double.Parse(pd_sx_a9))
            {
                dou_a9 = double.Parse(s_D45);
                i_a9 = 1;
                dtx_a9 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a9 + "AND (" + s_D45 + "<= [0_SX]) ORDER BY [0_SX] ASC");
            }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a9 = double.Parse(s_D45) / i;
                    if (dou_a9 > double.Parse(pd_sx_a9))
                    {
                        i_a9 = i;

                    }
                    else
                    {
                        i_a9 = i_a9 + 1;

                        dtx_a9 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a9 + "AND (" + dou_a9 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;

                    }
                }

            }
            #endregion

            #region 计算a10 - 膜组件
            int i_a10 = int.Parse(s_I10) * 9/10;
            double dou_a10 = 0;
            DataTable dtx_a10 = null;
            dtx_a10 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a10 + " AND ([7_CS_7]=" + int.Parse(s_K11) * 0.9 + ") ORDER BY [7_CS_7] ASC");

            #endregion

            #region 计算a11 -搅拌机
            int i_a11 = 0;
            double dou_a11 = 0;
            DataTable dtx_a11 = null;
            string pd_sx_a11 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a11 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D45) <= double.Parse(pd_sx_a11))
            {
                dou_a11 = double.Parse(s_D45);
                i_a11 = 1;
                dtx_a11 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a11 + "AND (" + s_D45 + "<= [0_SX]) ORDER BY [0_SX] ASC");
            }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a11 = double.Parse(s_D45) / i;
                    if (dou_a11 > double.Parse(pd_sx_a11))
                    {
                        i_a11 = i;

                    }
                    else
                    {
                        i_a11 = i_a11 + 1;

                        dtx_a11 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a11 + "AND (" + dou_a11 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;

                    }
                }

            }

            #endregion

            #region 计算a12- MSTD膜出水泵
            int i_a12 = 1;
            double dou_a12 = 0;
            DataTable dtx_a12 = null;
            dtx_a12 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a12 + "AND [7_XH]='PW-081E' ORDER BY [0_SX] ASC");

            #endregion

            #region 计算a13 -排泥泵
            int i_a13 = 0;
            double dou_a13 = 0;
            DataTable dtx_a13 = null;
            string pd_sx_a13 = Helper.GetDataTableFromDB("SELECT TOP 1 [0_SX] " + sql_a13 + "ORDER BY [0_SX] DESC").Rows[0][0].ToString();
            if (double.Parse(s_D30) / 24 <= double.Parse(pd_sx_a13))
            {
                dou_a13 = double.Parse(s_D30) / 24;
                i_a13 = 1;
                try
                {
                    dtx_a13 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a13 + "AND (" + double.Parse(s_D30) / 24 + "<= [0_SX]) ORDER BY [0_SX] ASC");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
            else
            {
                for (int i = 1; i < 200; ++i)
                {
                    dou_a13 = double.Parse(s_D30) / 24 / i;
                    if (dou_a13 > double.Parse(pd_sx_a13))
                    {
                        i_a13 = i;

                    }
                    else
                    {
                        i_a13 = i_a13 + 1;

                        dtx_a13 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a13 + "AND (" + dou_a13 + ">= [0_SX]) ORDER BY [0_SX] DESC");
                        break;
                    }
                }
            }
            #endregion

            #region 计算a14 -MDTD膜组件
                int i_a14 = 0;
                double dou_a14 = 0;
                DataTable dtx_a14 = null;
                string pd_sx_a14 = Helper.GetDataTableFromDB("SELECT TOP 1 [7_CS_7] " + sql_a14 + "ORDER BY [7_CS_7] DESC").Rows[0][0].ToString();
                if (Math.Ceiling(double.Parse(s_D30) / 24 / 0.01 * 0.7) <= double.Parse(pd_sx_a14))
                {
                    dou_a14 = Math.Ceiling(double.Parse(s_D30) / 24 / 0.01 * 0.7);
                    i_a14 = 1;
                    dtx_a14 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a14 + "AND (" + Math.Ceiling(double.Parse(s_D30) / 24 / 0.01 * 0.7) + "<= [7_CS_7]) ORDER BY [7_CS_7] ASC");
                }
                else
                {
                    for (int i = 1; i < 200; ++i)
                    {
                        dou_a14 = Math.Ceiling(double.Parse(s_D30) / 24 / 0.01 * 0.7) / i;
                        if (dou_a14 > double.Parse(pd_sx_a14))
                        {
                            i_a14 = i;

                        }
                        else
                        {
                            i_a14 = i_a14 + 1;

                            dtx_a14 = Helper.GetDataTableFromDB("SELECT  TOP 1 * " + sql_a14 + "AND ('" + dou_a14 + "'>= [0_SX]) ORDER BY [0_SX] DESC");
                            break;
                        }
                    }
                }
                    // Math.Ceiling(double.Parse(s_D30)/ 24/0.01*0.7)
                #endregion

            #region 设备参数表填充

                    //表7_a3_计算水箱数据
                    try
                    {
                        rowMergeView5.Rows[0].Cells[2].Value = dtx_a3.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[0].Cells[3].Value = dtx_a3.Rows[0][9].ToString();     //参数
                        rowMergeView5.Rows[0].Cells[4].Value = dtx_a3.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[0].Cells[5].Value = "";     //参数值
                        rowMergeView5.Rows[0].Cells[6].Value = i_a3.ToString();   //数量
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a4_计算控制柜
                    try
                    {
                        rowMergeView5.Rows[1].Cells[2].Value = dtx_a4.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[1].Cells[3].Value = dtx_a4.Rows[0][9].ToString();     //参数
                        rowMergeView5.Rows[1].Cells[4].Value = dtx_a4.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[1].Cells[5].Value = "";     //参数值
                        rowMergeView5.Rows[1].Cells[6].Value = i_a4.ToString();   //数量
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a5_计算格栅
                    try
                    {
                        //---------------a5
                        rowMergeView5.Rows[2].Cells[2].Value = dtx_a5.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[2].Cells[3].Value = dtx_a5.Rows[0][9].ToString();     //参数
                        rowMergeView5.Rows[2].Cells[4].Value = dtx_a5.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[2].Cells[5].Value = "";     //参数值
                        rowMergeView5.Rows[2].Cells[6].Value = i_a5.ToString();   //数量
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a6_计算调节池出水泵
                    try
                    {
                        //---------------a6
                        rowMergeView5.Rows[3].Cells[2].Value = dtx_a6.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[3].Cells[3].Value = dtx_a6.Rows[0][9].ToString().Replace("{D1/24}", (double.Parse(s_D1) / 24).ToString("0.00"));     //参数
                        rowMergeView5.Rows[3].Cells[4].Value = dtx_a6.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[3].Cells[5].Value = "";     //参数值
                        if (m_cb5 == "1")
                        {
                            i_a6 = i_a6 + 1;
                        }
                            rowMergeView5.Rows[3].Cells[6].Value = i_a6.ToString();   //数量
                        
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a7_计算风机
                    try
                    {
                        //---------------a7
                        rowMergeView5.Rows[4].Cells[2].Value = dtx_a7.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[4].Cells[3].Value = dtx_a7.Rows[0][9].ToString();     //参数
                        rowMergeView5.Rows[4].Cells[4].Value = dtx_a7.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[4].Cells[5].Value = "";     //参数值
                        
                        if (m_cb5 == "1")
                        {
                            i_a7 = i_a7 + 1;
                        }
                            rowMergeView5.Rows[4].Cells[6].Value = i_a7.ToString();   //数量
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a8_计算自吸泵
                    try
                    {
                        //---------------a8
                        rowMergeView5.Rows[5].Cells[2].Value = dtx_a8.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[5].Cells[3].Value = dtx_a8.Rows[0][9].ToString().Replace("{D1/20}", (double.Parse(s_D1) / 20).ToString("0.00"));      //参数
                        rowMergeView5.Rows[5].Cells[4].Value = dtx_a8.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[5].Cells[5].Value = "";     //参数值

                        if (m_cb5 == "1")
                        {
                            i_a8 = i_a8 + 1;
                        }
                        rowMergeView5.Rows[5].Cells[6].Value = i_a8.ToString();   //数量

                     
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a9_计算回流泵
                    try
                    {
                        //---------------a9
                        rowMergeView5.Rows[6].Cells[2].Value = dtx_a9.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[6].Cells[3].Value = dtx_a9.Rows[0][9].ToString().Replace("{D45}", double.Parse(s_D45).ToString("0.00"));     //参数
                        rowMergeView5.Rows[6].Cells[4].Value = dtx_a9.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[6].Cells[5].Value = "";     //参数值
                        if (m_cb5 == "1")
                        {
                            i_a9 = i_a9 + 1;
                        }
                        rowMergeView5.Rows[6].Cells[6].Value = i_a9.ToString();   //数量
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a10_膜组件
                    try
                    {
                        rowMergeView5.Rows[7].Cells[2].Value = dtx_a10.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[7].Cells[3].Value = dtx_a10.Rows[0][9].ToString().Replace("{D45}",s_D45);     //参数
                        rowMergeView5.Rows[7].Cells[4].Value = "㎡";     //单位
                        rowMergeView5.Rows[7].Cells[5].Value = "";     //参数值
                        rowMergeView5.Rows[7].Cells[6].Value = int.Parse(s_I10)*0.9;   //数量
                    }
                    catch (Exception)
                    {

                    }

                    /*
                    //表7_a11_缺氧池搅拌机
                    try
                    {
                        rowMergeView5.Rows[8].Cells[2].Value = dtx_a6.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[8].Cells[3].Value = dtx_a6.Rows[0][9].ToString();     //参数
                        rowMergeView5.Rows[8].Cells[4].Value = dtx_a6.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[8].Cells[5].Value = "";     //参数值
                        rowMergeView5.Rows[8].Cells[6].Value = i_a6.ToString();   //数量
                    }
                    catch (Exception)
                    {

                    }
                    */
                    //表7_a12_MSTD出水泵
                    try
                    {
                        rowMergeView5.Rows[8].Cells[2].Value = dtx_a12.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[8].Cells[3].Value = dtx_a12.Rows[0][9].ToString().Replace("{D1/20}", (double.Parse(s_D1) / 20).ToString("0.00"));     //参数
                        rowMergeView5.Rows[8].Cells[4].Value = dtx_a12.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[8].Cells[5].Value = "";     //参数值
                        rowMergeView5.Rows[8].Cells[6].Value = i_a12.ToString();   //数量
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a13_排泥泵
                    try
                    {
                        if (m_cb5 == "1")
                        {
                            rowMergeView5.Rows[9].Cells[2].Value = dtx_a13.Rows[0][8].ToString();     //型号
                            rowMergeView5.Rows[9].Cells[3].Value = dtx_a13.Rows[0][9].ToString().Replace("{D1/24}", (double.Parse(s_D1) / 24).ToString("0.00"));     //参数
                            rowMergeView5.Rows[9].Cells[4].Value = dtx_a13.Rows[0][17].ToString();     //单位
                            rowMergeView5.Rows[9].Cells[5].Value = "";     //参数值
                            rowMergeView5.Rows[9].Cells[6].Value = i_a13.ToString();   //数量
                        }
                        else
                        {
                            rowMergeView5.Rows[9].Cells[2].Value = "";
                            rowMergeView5.Rows[9].Cells[3].Value = "与回流泵和用.";     //参数
                            rowMergeView5.Rows[9].Cells[4].Value = "";     //单位
                            rowMergeView5.Rows[9].Cells[5].Value = "";     //参数值
                            rowMergeView5.Rows[9].Cells[6].Value = "";   //数量
                        }
                        
                    }
                    catch (Exception)
                    {

                    }

                    //表7_a14_MSTD膜组件
                    try
                    {
                        rowMergeView5.Rows[10].Cells[2].Value = dtx_a14.Rows[0][8].ToString();     //型号
                        rowMergeView5.Rows[10].Cells[3].Value = dtx_a14.Rows[0][9].ToString();     //参数
                      //  rowMergeView5.Rows[10].Cells[4].Value = dtx_a14.Rows[0][17].ToString();     //单位
                        rowMergeView5.Rows[10].Cells[4].Value = "㎡";                 
                        rowMergeView5.Rows[10].Cells[5].Value = "";     //参数值
                       // rowMergeView5.Rows[10].Cells[6].Value = i_a14.ToString();   //数量
                      // rowMergeView5.Rows[10].Cells[6].Value = dtx_a14.Rows[0][8].ToString().Substring(0, dtx_a14.Rows[0][8].ToString().LastIndexOf("-"));
                      double dstr = double.Parse(dtx_a14.Rows[0][8].ToString().Substring(dtx_a14.Rows[0][8].ToString().LastIndexOf("-") + 1, dtx_a14.Rows[0][8].ToString().Length - dtx_a14.Rows[0][8].ToString().LastIndexOf("-") - 1));
                      rowMergeView5.Rows[10].Cells[6].Value = (dstr*0.9).ToString("0");
                        //  str = str.Substring(0, str.LastIndexOf("/"));
                    }
                    catch (Exception)
                    {

                    }
                    dtwd3 = DataTableHelper.CreateTable("BM,BY1,BY2,BY3,BY4,BZ,TYPE");
                    dtwd3.Rows.Add(new object[] { "编号", "名称", "参数", "数量", "单位", "备注", "B42" });
                    for (int i = 2; i < rowMergeView5.Rows.Count; i++)
                    {
                        string s;
                        if (rowMergeView5.Rows[i].Cells[1].Value.ToString() == "")
                        {
                            s = rowMergeView5.Rows[i].Cells[0].Value.ToString();
                        }
                        else {
                            s = rowMergeView5.Rows[i].Cells[1].Value.ToString();
                        }

                        dtwd3.Rows.Add(new object[] { (i - 1).ToString(), 
                            s, 
                            rowMergeView5.Rows[i].Cells[3].Value, 
                            rowMergeView5.Rows[i].Cells[6].Value, 
                            rowMergeView5.Rows[i].Cells[4].Value, 
                            "", "B42" });
                    }
                   
                    
            //        dtwd3.Rows.Add(new object[] { "1", rowMergeView6.Rows[1].Cells[1].Value, "参数3", "座", rowMergeView6.Rows[1].Cells[4].Value.ToString(), "", "B42" });
            //        dtwd3.Rows.Add(new object[] { "2", rowMergeView6.Rows[2].Cells[1].Value, "参数3", "座", rowMergeView6.Rows[2].Cells[4].Value.ToString(), "", "B42" });
            //        dtwd3.Rows.Add(new object[] { "3", rowMergeView6.Rows[3].Cells[1].Value, "参数3", "座", rowMergeView6.Rows[3].Cells[4].Value.ToString(), "", "B42" });
            //        dtwd3.Rows.Add(new object[] { "4", rowMergeView6.Rows[4].Cells[1].Value, "参数3", "座", rowMergeView6.Rows[4].Cells[4].Value.ToString(), "", "B42" });
            //        dtwd3.Rows.Add(new object[] { "5", rowMergeView6.Rows[5].Cells[1].Value, "参数3", "座", rowMergeView6.Rows[5].Cells[4].Value.ToString(), "", "B42" });
            //        dtwd3.Rows.Add(new object[] { "6", rowMergeView7.Rows[1].Cells[1].Value, "参数3", "座", rowMergeView7.Rows[1].Cells[4].Value.ToString(), "", "B43" });
        

                    #endregion

            #region 设备参数表填充
                    
            #endregion
                    rowMergeView6.Rows.Clear();
                    rowMergeView6.DataSource = null;
                    rowMergeView7.Rows.Clear();
                    rowMergeView7.DataSource = null;
                    #region 初始化表6
                    Column37.HeaderText = "反应器";
                    Column38.HeaderText = "参数";
                    Column39.HeaderText = "L（长）";
                    Column40.HeaderText = "B（宽）";
                    Column41.HeaderText = "H（高）";
                    Column42.HeaderText = "H1（有效水深）";
                    Column75.HeaderText = "V1（有效容积）";

                    rowMergeView6.Rows.Add();
                    rowMergeView6.Rows[0].Cells[0].Value = "单位";
                    rowMergeView6.Rows[0].Cells[1].Value = "";
                    rowMergeView6.Rows[0].Cells[2].Value = "m";
                    rowMergeView6.Rows[0].Cells[3].Value = "m";
                    rowMergeView6.Rows[0].Cells[4].Value = "m";
                    rowMergeView6.Rows[0].Cells[5].Value = "m3";
                    rowMergeView6.Rows[0].Cells[6].Value = "m3";

                    rowMergeView6.Rows.Add();
                    rowMergeView6.Rows[1].Cells[0].Value = "反应器";
                    rowMergeView6.Rows[1].Cells[1].Value = "总尺寸";
                    rowMergeView6.Rows[1].Cells[2].Value = "";
                    rowMergeView6.Rows[1].Cells[3].Value = "";
                    rowMergeView6.Rows[1].Cells[4].Value = "";
                    rowMergeView6.Rows[1].Cells[5].Value = "";
                    rowMergeView6.Rows[1].Cells[6].Value = "";

                    rowMergeView6.Rows.Add();
                    rowMergeView6.Rows[2].Cells[0].Value = "反应器";
                    rowMergeView6.Rows[2].Cells[1].Value = "调节池";
                    rowMergeView6.Rows[2].Cells[2].Value = "";
                    rowMergeView6.Rows[2].Cells[3].Value = "";
                    rowMergeView6.Rows[2].Cells[4].Value = "";
                    rowMergeView6.Rows[2].Cells[5].Value = "";
                    rowMergeView6.Rows[2].Cells[6].Value = "";

                    rowMergeView6.Rows.Add();
                    rowMergeView6.Rows[3].Cells[0].Value = "反应器";
                    rowMergeView6.Rows[3].Cells[1].Value = "缺氧池";
                    rowMergeView6.Rows[3].Cells[2].Value = "";
                    rowMergeView6.Rows[3].Cells[3].Value = "";
                    rowMergeView6.Rows[3].Cells[4].Value = "";
                    rowMergeView6.Rows[3].Cells[5].Value = "";
                    rowMergeView6.Rows[3].Cells[6].Value = "";

                    rowMergeView6.Rows.Add();
                    rowMergeView6.Rows[4].Cells[0].Value = "反应器";
                    rowMergeView6.Rows[4].Cells[1].Value = "好氧池";
                    rowMergeView6.Rows[4].Cells[2].Value = "";
                    rowMergeView6.Rows[4].Cells[3].Value = "";
                    rowMergeView6.Rows[4].Cells[4].Value = "";
                    rowMergeView6.Rows[4].Cells[5].Value = "";
                    rowMergeView6.Rows[4].Cells[6].Value = "";

                    rowMergeView6.Rows.Add();
                    rowMergeView6.Rows[5].Cells[0].Value = "反应器";
                    rowMergeView6.Rows[5].Cells[1].Value = "MSTD池";
                    rowMergeView6.Rows[5].Cells[2].Value = "";
                    rowMergeView6.Rows[5].Cells[3].Value = "";
                    rowMergeView6.Rows[5].Cells[4].Value = "";
                    rowMergeView6.Rows[5].Cells[5].Value = "";
                    rowMergeView6.Rows[5].Cells[6].Value = "";
                    #endregion

                    #region 设备形式初始化表7
                    if (sbjf == "2") //设备箱
                    {
                        Column43.HeaderText = "设备机房形式";
                        Column44.HeaderText = "参数";
                        Column45.HeaderText = "L（长）";
                        Column46.HeaderText = "B（宽）";
                        Column47.HeaderText = "H（高）";
                        Column76.HeaderText = "M（净重）";

                        rowMergeView7.Rows.Add();
                        rowMergeView7.Rows[0].Cells[0].Value = "设备箱";
                        rowMergeView7.Rows[0].Cells[1].Value = "单位";
                        rowMergeView7.Rows[0].Cells[2].Value = "m";
                        rowMergeView7.Rows[0].Cells[3].Value = "m";
                        rowMergeView7.Rows[0].Cells[4].Value = "m";
                        rowMergeView7.Rows[0].Cells[5].Value = "kg";

                        rowMergeView7.Rows.Add();
                        rowMergeView7.Rows[1].Cells[0].Value = "设备箱";
                        rowMergeView7.Rows[1].Cells[1].Value = "数值";
                        rowMergeView7.Rows[1].Cells[2].Value = "";
                        rowMergeView7.Rows[1].Cells[3].Value = "";
                        rowMergeView7.Rows[1].Cells[4].Value = "";
                        rowMergeView7.Rows[1].Cells[5].Value = "";
                    }
                    else //设备机房
                    {

                        Column43.HeaderText = "设备机房形式";
                        Column44.HeaderText = "参数";
                        Column45.HeaderText = "L（长）";
                        Column46.HeaderText = "B（宽）";
                        Column47.HeaderText = "H（高）";
                        Column76.HeaderText = "M（净重）";


                        rowMergeView7.Rows.Add();
                        rowMergeView7.Rows[0].Cells[0].Value = "设备机房";
                        rowMergeView7.Rows[0].Cells[1].Value = "单位";
                        rowMergeView7.Rows[0].Cells[2].Value = "m";
                        rowMergeView7.Rows[0].Cells[3].Value = "m";
                        rowMergeView7.Rows[0].Cells[4].Value = "m";
                        rowMergeView7.Rows[0].Cells[5].Value = "kg";

                        rowMergeView7.Rows.Add();
                        rowMergeView7.Rows[1].Cells[0].Value = "设备机房";
                        rowMergeView7.Rows[1].Cells[1].Value = "数值";
                        rowMergeView7.Rows[1].Cells[2].Value = "";
                        rowMergeView7.Rows[1].Cells[3].Value = "";
                        rowMergeView7.Rows[1].Cells[4].Value = "";
                        rowMergeView7.Rows[1].Cells[5].Value = "";
                    }
                    #endregion

                    #region 设备形式表重置表头
                    
                    if (sbxs == "1") //设备形式为：土建
                    {
                        Column41.Visible = true;
                        Column37.HeaderText = "反应器";
                        Column38.HeaderText = "参数";
                        Column39.HeaderText = "L（长）";
                        Column40.HeaderText = "B（宽）";
                        Column41.HeaderText = "H（高）";
                        Column42.HeaderText = "H1（有效水深）";
                        Column75.HeaderText = "V1（有效容积）";
                    }
                    else if (sbxs == "2")
                    {
                        //碳钢+防腐：1 ，不锈钢：2 ，玻璃钢成套设备：3 ,玻璃钢拼装水箱:4，PP:5
                        //1,2,4   -   3,5
                        switch (sbcz)
                        {
                            case "1":
                                Column41.Visible = true;
                                Column37.HeaderText = "反应器";
                                Column38.HeaderText = "参数";
                                Column39.HeaderText = "L（长）";
                                Column40.HeaderText = "B（宽）";
                                Column41.HeaderText = "H（高）";
                                Column42.HeaderText = "H1（有效水深）";
                                Column75.HeaderText = "V1（有效容积）";
                                break;
                            case "2":
                                Column41.Visible = true;
                                Column37.HeaderText = "反应器";
                                Column38.HeaderText = "参数";
                                Column39.HeaderText = "L（长）";
                                Column40.HeaderText = "B（宽）";
                                Column41.HeaderText = "H（高）";
                                Column42.HeaderText = "H1（有效水深）";
                                Column75.HeaderText = "V1（有效容积）";
                                break;
                            case "3":
                                Column41.Visible = false;
                                Column37.HeaderText = "反应器";
                                Column38.HeaderText = "参数";
                                Column39.HeaderText = "L（长）";
                                Column40.HeaderText = "Φ（直径）";
                                Column41.HeaderText = "";
                                Column42.HeaderText = "H1（有效水深）";
                                Column75.HeaderText = "V1（有效容积）";    
                                break;
                            case "4":
                                Column41.Visible = true;
                                Column37.HeaderText = "反应器";
                                Column38.HeaderText = "参数";
                                Column39.HeaderText = "L（长）";
                                Column40.HeaderText = "B（宽）";
                                Column41.HeaderText = "H（高）";
                                Column42.HeaderText = "H1（有效水深）";
                                Column75.HeaderText = "V1（有效容积）";
                                break;
                            case "5":
                                Column41.Visible = false;
                                Column37.HeaderText = "反应器";
                                Column38.HeaderText = "参数";
                                Column39.HeaderText = "L（长）";
                                Column40.HeaderText = "Φ（直径）";
                                Column41.HeaderText = "";
                                Column42.HeaderText = "H1（有效水深）";
                                Column75.HeaderText = "V1（有效容积）";     
                             break;
                        }
                        #endregion
                    }
                    #region 设备表尺寸计算
                    const double PI = 3.14159;      //π
                    double R = 0.00;  //直径
                    double r = R / 2;  //半径
                    double H1 = 0.00; //有效水深
                    double V1 = 0.00; //有效容积
                    double L = 0.00; //长
                    double B = 0.00; //宽
                    double H = 0.00; //高

                    if (sbxs == "1") //土建
                    {
                        Column42.Visible = true;
                        L = double.Parse(dtx_a3.Rows[0][28].ToString());
                        B = double.Parse(dtx_a3.Rows[0][29].ToString());
                        H = double.Parse(dtx_a3.Rows[0][30].ToString());
                        H1 = double.Parse(dtx_a3.Rows[0][31].ToString());
                        V1 = double.Parse(dtx_a3.Rows[0][32].ToString());

                        rowMergeView6.Rows[1].Cells[0].Value = "反应器";
                        rowMergeView6.Rows[1].Cells[1].Value = "总尺寸";
                        rowMergeView6.Rows[1].Cells[2].Value = L.ToString("0.0");
                        rowMergeView6.Rows[1].Cells[3].Value = B.ToString("0.0");
                        rowMergeView6.Rows[1].Cells[4].Value = H.ToString("0.0");
                        rowMergeView6.Rows[1].Cells[5].Value = H1.ToString("0.0");
                        rowMergeView6.Rows[1].Cells[6].Value = V1.ToString("0.0");
                        this.ZDZZB = L * B;

                        rowMergeView6.Rows[2].Cells[0].Value = "反应器";
                        rowMergeView6.Rows[2].Cells[1].Value = "调节池";
                        double t1_l1 = 0.00; //求宽
                        double t1_v1 = 0.00;
                        if (s_D42 == "0")
                        {
                            t1_l1 = (double.Parse(s_D45) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45)))*(B-0.6);
                        }
                        else
                        {
                            t1_l1 = (double.Parse(s_D45) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45))) * (B - 0.6);

                        }
                        t1_v1 = (L - 0.4) * t1_l1 * H1;
                        //rowMergeView6.Rows[2].Cells[2].Value = t1_l1.ToString("0.0")+"(L1)";    //D45*（总尺寸长-1）/（I19+D42+D45）;
                        rowMergeView6.Rows[2].Cells[2].Value = (L-0.4).ToString() + "(L1)";    //D45*（总尺寸长-1）/（I19+D42+D45）;

                        rowMergeView6.Rows[2].Cells[3].Value = t1_l1.ToString("0.0") + "(B1)";
                        rowMergeView6.Rows[2].Cells[4].Value = H.ToString("0.0");
                        rowMergeView6.Rows[2].Cells[5].Value = H1.ToString("0.0");
                        rowMergeView6.Rows[2].Cells[6].Value = t1_v1.ToString("0.0");



                        rowMergeView6.Rows[3].Cells[0].Value = "反应器";
                        rowMergeView6.Rows[3].Cells[1].Value = "缺氧池";
                        double t1_l2 = 0.00;
                        double t1_v2 = 0.00;
                        if (s_D42 == "0")
                        {
                            t1_l2 = 0.00;
                            rowMergeView6.Rows[3].Cells[2].Value = "0";    //D42*（总尺寸长-1）/（I19+D42+D45）;
                            rowMergeView6.Rows[3].Cells[3].Value = "0";
                            rowMergeView6.Rows[3].Cells[4].Value = "0";
                            rowMergeView6.Rows[3].Cells[5].Value = "0";
                            rowMergeView6.Rows[3].Cells[6].Value = "0";
                        }
                        else
                        {
                            t1_l2 = ((double.Parse(s_D42) + double.Parse(s_I19)) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45))) * (B - 0.6);
                            t1_v2 = t1_l2 * ((L - 0.6 - 1) * double.Parse(s_D42) / (double.Parse(s_I19) + double.Parse(s_D42))) * H1;
                            rowMergeView6.Rows[3].Cells[2].Value = ((L - 0.6 -1)*double.Parse(s_D42) /(double.Parse(s_I19) + double.Parse(s_D42))).ToString("0.0") + "(L2)";
                            rowMergeView6.Rows[3].Cells[3].Value = t1_l2.ToString("0.0") + "(B2)"; ;
                            rowMergeView6.Rows[3].Cells[4].Value = H.ToString("0.0");
                            rowMergeView6.Rows[3].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[3].Cells[6].Value = t1_v2.ToString("0.0");
                        }



                        //double t1_l3 = (double.Parse(s_I19) * (L - 1) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45)));
                        double t1_l3 = 0.00;
                        double t1_v3 = 0.00;
                        if (s_D42 == "0") //求宽
                        {
                            t1_l3 = B - t1_l1;
                        }
                        else
                        {
                            t1_l3 = ((double.Parse(s_D42) + double.Parse(s_I19)) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45))) * (B - 0.6);
                        }
                        t1_v3 = (L - 0.6 - 1) * double.Parse(s_I19) / (double.Parse(s_I19) + double.Parse(s_D42)) * t1_l3 * H1;
                        rowMergeView6.Rows[4].Cells[0].Value = "反应器";
                        rowMergeView6.Rows[4].Cells[1].Value = "好氧池"; 
                        rowMergeView6.Rows[4].Cells[2].Value = ((L - 0.6 - 1) * double.Parse(s_I19) / (double.Parse(s_I19) + double.Parse(s_D42))).ToString("0.0") + "(L3)";
                        rowMergeView6.Rows[4].Cells[3].Value = t1_l3.ToString("0.0") + "(B2)"; ;
                        rowMergeView6.Rows[4].Cells[4].Value = H.ToString("0.0");
                        rowMergeView6.Rows[4].Cells[5].Value = H1.ToString("0.0");
                        rowMergeView6.Rows[4].Cells[6].Value = t1_v3.ToString("0.0");


                        double t1_l4 = 0.00;
                        // float.Parse(((t1_l1 * B * H).ToString("0.0"))) -
                        // float.Parse(((t1_l2 * B * H).ToString("0.0"))));

                        if (s_D42 == "0") //求宽
                        {
                            t1_l4 = t1_l3;
                        }
                        else
                        {
                            t1_l4 = ((double.Parse(s_D42) + double.Parse(s_I19)) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45))) * (B - 0.6);
                        }
                 
                        rowMergeView6.Rows[5].Cells[0].Value = "反应器";
                        rowMergeView6.Rows[5].Cells[1].Value = "MSTD池";
                        rowMergeView6.Rows[5].Cells[2].Value = "1"+"(L4)";
                        rowMergeView6.Rows[5].Cells[3].Value = t1_l4.ToString("0.0") + "(B2)"; ;
                        rowMergeView6.Rows[5].Cells[4].Value = H.ToString("0.0");
                        rowMergeView6.Rows[5].Cells[5].Value = H1.ToString("0.0");
                        rowMergeView6.Rows[5].Cells[6].Value = (1 * t1_l4 * H1).ToString("0.0");

                        rowMergeView6.Rows[1].Cells[6].Value = (
                              double.Parse(rowMergeView6.Rows[2].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[3].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[4].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[5].Cells[6].Value.ToString())).ToString();

                    }
                    else if (sbxs == "2") //一体化设备
                    {

                        //1.碳钢+防腐，2.不锈钢，3.玻璃钢成套设备 ,4.玻璃钢拼装水箱，5.PP      
                        if (sbcz == "1" || sbcz == "2" || sbcz == "4") //1.碳钢成套设备,2.不锈钢成套设备,4.玻璃钢拼装水箱
                        {
                            L = double.Parse(dtx_a3.Rows[0][19].ToString())* i_a3; //乘以设备数
                            B = double.Parse(dtx_a3.Rows[0][20].ToString());
                            H = double.Parse(dtx_a3.Rows[0][21].ToString());
                            H1 = double.Parse(dtx_a3.Rows[0][22].ToString());
                            V1 = double.Parse(dtx_a3.Rows[0][23].ToString());

                            rowMergeView6.Rows[1].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[1].Cells[1].Value = "总尺寸";
                            rowMergeView6.Rows[1].Cells[2].Value = L.ToString("0.0");
                            rowMergeView6.Rows[1].Cells[3].Value = B.ToString("0.0");
                            rowMergeView6.Rows[1].Cells[4].Value = H.ToString("0.0");
                            rowMergeView6.Rows[1].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[1].Cells[6].Value = V1.ToString("0.0");

                            this.ZDZZB = L * B;

                            rowMergeView6.Rows[2].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[2].Cells[1].Value = "调节池";
                            double t1_l1 = (double.Parse(s_D45) * (L - 1) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45)));
                            //t1_l1 = t1_l1 * i_a3;
                            rowMergeView6.Rows[2].Cells[2].Value = t1_l1.ToString("0.0")+"(L1)";    //D45*（总尺寸长-1）/（I19+D42+D45）;
                            rowMergeView6.Rows[2].Cells[3].Value = B.ToString("0.0");
                            rowMergeView6.Rows[2].Cells[4].Value = H.ToString("0.0");
                            rowMergeView6.Rows[2].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[2].Cells[6].Value = (t1_l1 * B * H1).ToString("0.0");

                            rowMergeView6.Rows[3].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[3].Cells[1].Value = "缺氧池";
                            double t1_l2 = 0.00;
                            if (s_D42 == "0")
                            {
                                t1_l2 = 0.00;
                                rowMergeView6.Rows[3].Cells[2].Value = "0.00";    //D42*（总尺寸长-1）/（I19+D42+D45）;
                                rowMergeView6.Rows[3].Cells[3].Value = "0.00";
                                rowMergeView6.Rows[3].Cells[4].Value = "0.00";
                                rowMergeView6.Rows[3].Cells[5].Value = "0.00";
                                rowMergeView6.Rows[3].Cells[6].Value = "0.00";
                            }
                            else
                            {
                                t1_l2 = (double.Parse(s_D42) * (L - 1) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45)));
                              //  t1_l2 = t1_l2 * i_a3;
                                rowMergeView6.Rows[3].Cells[2].Value = t1_l2.ToString("0.0") + "(L2)";    //D42*（总尺寸长-1）/（I19+D42+D45）;
                                rowMergeView6.Rows[3].Cells[3].Value = B.ToString("0.0");
                                rowMergeView6.Rows[3].Cells[4].Value = H.ToString("0.0");
                                rowMergeView6.Rows[3].Cells[5].Value = H1.ToString("0.0");
                                rowMergeView6.Rows[3].Cells[6].Value = (t1_l2 * B * H1).ToString("0.0");
                            }


                            double t1_l3 = float.Parse(L.ToString("0.0")) - float.Parse(t1_l1.ToString("0.0")) - float.Parse(t1_l2.ToString("0.0"));
                            //t1_l3 = t1_l3 * i_a3;
                            rowMergeView6.Rows[4].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[4].Cells[1].Value = "好氧池";
                            rowMergeView6.Rows[4].Cells[2].Value = t1_l3.ToString("0.0")+"(L3)";
                            rowMergeView6.Rows[4].Cells[3].Value = B.ToString("0.0");
                            rowMergeView6.Rows[4].Cells[4].Value = H.ToString("0.0");
                            rowMergeView6.Rows[4].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[4].Cells[6].Value = (t1_l3 * B * H1).ToString("0.0");

                            rowMergeView6.Rows[5].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[5].Cells[1].Value = "MSTD池";
                            rowMergeView6.Rows[5].Cells[2].Value = 1;
                            rowMergeView6.Rows[5].Cells[3].Value = B.ToString("0.0");
                            rowMergeView6.Rows[5].Cells[4].Value = H.ToString("0.0");
                            rowMergeView6.Rows[5].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[5].Cells[6].Value = (1 * B * H1).ToString("0.0");

                            rowMergeView6.Rows[1].Cells[6].Value = (
                              double.Parse(rowMergeView6.Rows[2].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[3].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[4].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[5].Cells[6].Value.ToString())).ToString();
                        }
                        else if (sbcz == "3" || sbcz == "5")//3.玻璃钢成套设备,5.PP，同玻璃钢成套设备
                        {
                            R = double.Parse(dtx_a3.Rows[0][24].ToString());
                            r = R / 2;
                            L = double.Parse(dtx_a3.Rows[0][25].ToString()) * i_a3;
                            H1 = double.Parse(dtx_a3.Rows[0][26].ToString());
                            V1 = double.Parse(dtx_a3.Rows[0][27].ToString());
                            rowMergeView6.Rows[1].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[1].Cells[1].Value = "总尺寸";
                            rowMergeView6.Rows[1].Cells[2].Value = L.ToString("0.0");
                            rowMergeView6.Rows[1].Cells[3].Value = R.ToString("0.0");
                            rowMergeView6.Rows[1].Cells[4].Value = "";
                            rowMergeView6.Rows[1].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[1].Cells[6].Value = V1.ToString("0.0");

                            this.ZDZZB = L * R;

                            rowMergeView6.Rows[2].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[2].Cells[1].Value = "调节池";
                            double t1_l1 = (double.Parse(s_D45) * (L - 1) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45)));
                            double v1 =
                                     (
                                     ((2 * PI - 2 * Math.Acos((H1 - r) / r))/(2 * PI) * (PI * Math.Pow(r, 2)))
                                     +
                                     (1 / 2 * (H1 - r) * Math.Pow((Math.Pow(r, 2) - Math.Pow(H1 - r, 2)), 1 / 2))
                                     );
                            
                            rowMergeView6.Rows[2].Cells[2].Value = t1_l1.ToString("0.0")+"(L1)";    //D45*（总尺寸长-1）/（I19+D42+D45）;
                            rowMergeView6.Rows[2].Cells[3].Value = R.ToString("0.0");
                            rowMergeView6.Rows[2].Cells[4].Value = "";
                            rowMergeView6.Rows[2].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[2].Cells[6].Value = (v1 * t1_l1).ToString("0.0");


                            //---------------------------------
                            rowMergeView6.Rows[3].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[3].Cells[1].Value = "缺氧池";
                            double t1_l2 = 0.00;
                            if (s_D42 == "0")
                            {
                                t1_l2 = 0.00;
                                rowMergeView6.Rows[3].Cells[2].Value = "";    //D42*（总尺寸长-1）/（I19+D42+D45）;
                                rowMergeView6.Rows[3].Cells[3].Value = "";
                                rowMergeView6.Rows[3].Cells[4].Value = "";
                                rowMergeView6.Rows[3].Cells[5].Value = "";
                                rowMergeView6.Rows[3].Cells[6].Value = "";
                            }
                            else
                            {
                                t1_l2 = (double.Parse(s_D42) * (L - 1) / (double.Parse(s_I19) + double.Parse(s_D42) + double.Parse(s_D45)));
                                rowMergeView6.Rows[3].Cells[2].Value = t1_l2.ToString("0.0")+"(L2)";    //D42*（总尺寸长-1）/（I19+D42+D45）;
                                rowMergeView6.Rows[3].Cells[3].Value = R.ToString("0.0");
                                rowMergeView6.Rows[3].Cells[4].Value = "";
                                rowMergeView6.Rows[3].Cells[5].Value = H1.ToString("0.0");
                                rowMergeView6.Rows[3].Cells[6].Value = (v1 * t1_l2).ToString("0.0");
                            }
                            //-------------------------
                            


                            double t1_l3 = float.Parse(L.ToString("0.0")) - float.Parse(t1_l1.ToString("0.0")) - float.Parse(t1_l2.ToString("0.0"));
                            rowMergeView6.Rows[4].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[4].Cells[1].Value = "好氧池";
                            rowMergeView6.Rows[4].Cells[2].Value = t1_l3.ToString("0.0")+"(L3)";
                            rowMergeView6.Rows[4].Cells[3].Value = R.ToString("0.0");
                            rowMergeView6.Rows[4].Cells[4].Value = "";
                            rowMergeView6.Rows[4].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[4].Cells[6].Value = (v1 * t1_l3).ToString("0.0"); ;

                            rowMergeView6.Rows[5].Cells[0].Value = "反应器";
                            rowMergeView6.Rows[5].Cells[1].Value = "MSTD池";
                            rowMergeView6.Rows[5].Cells[2].Value = 1;
                            rowMergeView6.Rows[5].Cells[3].Value = R.ToString("0.0");
                            rowMergeView6.Rows[5].Cells[4].Value = "";
                            rowMergeView6.Rows[5].Cells[5].Value = H1.ToString("0.0");
                            rowMergeView6.Rows[5].Cells[6].Value = (v1 * 1).ToString("0.0");


                            rowMergeView6.Rows[1].Cells[6].Value = (
                              double.Parse(rowMergeView6.Rows[2].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[3].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[4].Cells[6].Value.ToString())
                            + double.Parse(rowMergeView6.Rows[5].Cells[6].Value.ToString())).ToString();
                        }
                    }
                    else
                    {

                    }
                    #endregion
                    
                    #region //图片加载

                    Image img_sb = new Bitmap(System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-OG01.jpg");//参数是路径（支持相对路径和绝对路径）
                    
                    Image img_lc = new Bitmap(System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-OG01.jpg");//参数是路径（支持相对路径和绝对路径）
                    String img_ssb = "";
                    String img_lsb = "";

                    //判断缺氧池是否为0
                    if (rowMergeView1.Rows[1].Cells[4].Value.ToString() == "0")
                    {
                        pictureBox9.Image = ZIZHENG.Properties.Resources.无缺氧池工艺流程介绍;
                        //判断m_cb4   设备类型    1.地上      2.半地埋     3.地下
                        switch (m_cb4)
                        {
                            case "1": //地上
                                //判断m_cb3   设备形式    1.土建      2.一体化设备
                                if (m_cb3 == "1") //土建
                                {
                                    img_ssb = System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-OG01.jpg";
                                    img_lsb = System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-OG01.jpg";
                                    img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                    
                                }
                                else if(m_cb3 == "2")//一体化设备
                                {
                                    //判断m_cb6   设备材质    1.碳钢      2.不锈钢     3.成套 4.拼装 5.PP
                                    switch (m_cb6)
                                    {
                                        case "1": //碳钢
                                            img_ssb = System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-OG03.jpg";
                                            img_lsb = System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-OG03.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                            img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "2": //不锈钢
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-OG02.jpg";
                                            img_lsb = System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-OG02.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "3": //成套
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-OG05.jpg";
                                            img_lsb = System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-OG05.jpg";
                                         img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "4": //拼装
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-OG04.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-OG04.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "5": //PP
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-OG06.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-OG06.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                    } 
                                }
                                
                                break;
                            case "2": //半地埋
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-HB01.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-HB01.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                break;
                            case "3": //地下
                                //判断m_cb3   设备形式    1.土建      2.一体化设备
                                if (m_cb3 == "1") //土建
                                {
                                    img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-UG01.jpg";
                                    img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-UG01.jpg";
                                    img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                }
                                else if (m_cb3 == "2")//一体化设备
                                {
                                    //判断m_cb6   设备材质    1.碳钢      2.不锈钢     3.成套 4.拼装 5.PP
                                    switch (m_cb6)
                                    {
                                        case "1": //碳钢
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-UG03.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-UG03.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "2": //不锈钢
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-UG02.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-UG02.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "3": //成套
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-UG05.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-UG05.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "4": //拼装
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-UG04.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-UG04.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "5": //PP
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-O-UG06.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-O-UG06.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                    }
                                }
                                break;
                        } 
                    }
                    else //有缺氧池
                    {
                        pictureBox9.Image = ZIZHENG.Properties.Resources.有缺氧池工艺流程介绍;
                        //判断m_cb4   设备类型    1.地上      2.半地埋     3.地下
                        switch (m_cb4)
                        {
                            case "1": //地上
                                //判断m_cb3   设备形式    1.土建      2.一体化设备
                                if (m_cb3 == "1") //土建
                                {
                                    img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-OG01.jpg";
                                    img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-OG01.jpg";
                                    img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                }
                                else if (m_cb3 == "2")//一体化设备
                                {
                                    //判断m_cb6   设备材质    1.碳钢      2.不锈钢     3.成套 4.拼装 5.PP
                                    switch (m_cb6)
                                    {
                                        case "1": //碳钢
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-OG03.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-OG03.jpg";
                                        img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "2": //不锈钢
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-OG02.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-OG02.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "3": //成套
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-OG05.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-OG05.jpg";
                                         img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "4": //拼装
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-OG04.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-OG04.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "5": //PP
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-OG06.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-OG06.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                    }
                                }

                                break;
                            case "2": //半地埋
                                img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-HB01.jpg";
                                img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-HB01.jpg";
                                img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                break;
                            case "3": //地下
                                //判断m_cb3   设备形式    1.土建      2.一体化设备
                                if (m_cb3 == "1") //土建
                                {
                                    img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-UG01.jpg";
                                     img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-UG01.jpg";
                                   img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                }
                                else if (m_cb3 == "2")//一体化设备
                                {
                                    //判断m_cb6   设备材质    1.碳钢      2.不锈钢     3.成套 4.拼装 5.PP
                                    switch (m_cb6)
                                    {
                                        case "1": //碳钢
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-UG03.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-UG03.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "2": //不锈钢
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-UG02.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-UG02.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "3": //成套
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-UG05.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-UG05.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "4": //拼装
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-UG04.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-UG04.jpg";
                                           img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                        case "5": //PP
                                            img_ssb =System.Windows.Forms.Application.StartupPath + "\\FLOW\\F-AO-UG06.jpg";
                                            img_lsb =System.Windows.Forms.Application.StartupPath + "\\SIZE\\S-AO-UG06.jpg";
                                            img_sb = new Bitmap(img_ssb);
                                    img_lc = new Bitmap(img_lsb);
                                            break;
                                    }
                                }
                                break;
                        }
                        
                    }
                    pictureBox4.Image = img_lc;
                    pictureBox1.Image = img_sb;

                   
                    dtwd12 = DataTableHelper.CreateTable("BH,MC,LJ,BS");
                    dtwd12.Rows.Add(new object[] { "1", "图片1", img_ssb, "p1" });
                    dtwd12.Rows.Add(new object[] { "2", "图片4", img_lsb, "p4" });
                      


                    //m_cb3   设备形式    1.土建      2.一体化设备
                    //m_cb4   设备类型    1.地上      2.半地埋     3.地下
                    //m_cb5   是否备用    1.是        2.否
                    //m_cb6   设备材质    1.碳钢      2.不锈钢     3.成套 4.拼装 5.PP
                    //m_cb8   膜组件层数  1.一层      2.二层       3.三层
                    //m_cb9   机房形式    1.设备机房  2.设备箱
                    
                         
            
        
                    
                    #endregion

                    #region //填充设备信息
                    double L_SB = 0.00; //长
                    double B_SB = 0.00; //宽
                    double H_SB = 0.00; //高
                    double BZ_SB = 0.00; //占地面积or净重
                    if (sbjf == "2") //控制箱
                    {
                        L_SB = double.Parse(dtx_a4.Rows[0][37].ToString());
                        B_SB = double.Parse(dtx_a4.Rows[0][38].ToString());
                        H_SB = double.Parse(dtx_a4.Rows[0][39].ToString());
                        try
                        {
                            BZ_SB = double.Parse(dtx_a4.Rows[0][40].ToString());
                        }
                        catch(Exception e)
                        {
                            BZ_SB = 0;
                        }
                        
                        Column43.HeaderText = "设备机房形式";
                        Column44.HeaderText = "参数";
                        Column45.HeaderText = "L（长）";
                        Column46.HeaderText = "B（宽）";
                        Column47.HeaderText = "H（高）";
                        Column76.HeaderText = "M（净重）";

                        rowMergeView7.Rows[0].Cells[0].Value = "设备箱";
                        rowMergeView7.Rows[0].Cells[1].Value = "单位";
                        rowMergeView7.Rows[0].Cells[2].Value = "m";
                        rowMergeView7.Rows[0].Cells[3].Value = "m";
                        rowMergeView7.Rows[0].Cells[4].Value = "m";
                        rowMergeView7.Rows[0].Cells[5].Value = "kg";

                        rowMergeView7.Rows[1].Cells[0].Value = "设备箱";
                        rowMergeView7.Rows[1].Cells[1].Value = "数值";
                        rowMergeView7.Rows[1].Cells[2].Value = L_SB.ToString("0.0");
                        rowMergeView7.Rows[1].Cells[3].Value = B_SB.ToString("0.0");
                        rowMergeView7.Rows[1].Cells[4].Value = H_SB.ToString("0.0");
                        rowMergeView7.Rows[1].Cells[5].Value = BZ_SB.ToString("0.0");
                    }
                    else //设备机房
                    {
                        Column43.HeaderText = "设备机房形式";
                        Column44.HeaderText = "参数";
                        Column45.HeaderText = "L（长）";
                        Column46.HeaderText = "B（宽）";
                        Column47.HeaderText = "H（高）";
                        Column76.HeaderText = "S(占地面积)";

                        L_SB = double.Parse(dtx_a4.Rows[0][33].ToString());
                        B_SB = double.Parse(dtx_a4.Rows[0][34].ToString());
                        H_SB = double.Parse(dtx_a4.Rows[0][35].ToString());
                        BZ_SB = double.Parse(dtx_a4.Rows[0][36].ToString());

                        rowMergeView7.Rows[0].Cells[0].Value = "设备机房";
                        rowMergeView7.Rows[0].Cells[1].Value = "单位";
                        rowMergeView7.Rows[0].Cells[2].Value = "m";
                        rowMergeView7.Rows[0].Cells[3].Value = "m";
                        rowMergeView7.Rows[0].Cells[4].Value = "m";
                        rowMergeView7.Rows[0].Cells[5].Value = "㎡";

                        rowMergeView7.Rows[1].Cells[0].Value = "设备机房";
                        rowMergeView7.Rows[1].Cells[1].Value = "数值";
                        rowMergeView7.Rows[1].Cells[2].Value = L_SB.ToString("0.0");
                        rowMergeView7.Rows[1].Cells[3].Value = B_SB.ToString("0.0");
                        rowMergeView7.Rows[1].Cells[4].Value = H_SB.ToString("0.0");
                        rowMergeView7.Rows[1].Cells[5].Value = BZ_SB.ToString("0.0");
                    }
            #endregion

                    #region 表8计算                    
                    rowMergeView8.Rows[0].Cells[0].Value = "单位";
                    rowMergeView8.Rows[0].Cells[1].Value = "";
                    rowMergeView8.Rows[0].Cells[2].Value = "--";
                    rowMergeView8.Rows[0].Cells[3].Value = "kw";
                    rowMergeView8.Rows[0].Cells[4].Value = "--";
                    rowMergeView8.Rows[0].Cells[5].Value = "--";
                    rowMergeView8.Rows[0].Cells[6].Value = "kw";
                    rowMergeView8.Rows[0].Cells[7].Value = "--";
                    rowMergeView8.Rows[0].Cells[8].Value = "kwh";

                    //a6 调节池进水泵
                    string xh_8_1 = dtx_a6.Rows[0][8].ToString();
                    double djgl_8_1 = double.Parse(dtx_a6.Rows[0][13].ToString());
                    double sl_8_1 = i_a6;
                    string dw_8_1 = dtx_a6.Rows[0][17].ToString();
                    double sx_8_1 = double.Parse(dtx_a6.Rows[0][7].ToString());
                    double ys_8_1 = double.Parse(dtx_a6.Rows[0][7].ToString());
                    if (sl_8_1 <= 1)
                    { ys_8_1 = 1 * double.Parse(s_D1) / 24 / sx_8_1; }
                    else
                    { ys_8_1 = (sl_8_1 - 1) / sl_8_1 * double.Parse(s_D1) / 24 / sx_8_1; }
        
                    rowMergeView8.Rows[1].Cells[0].Value = "预处理单元";
                    rowMergeView8.Rows[1].Cells[1].Value = "调节池进水泵";
                    rowMergeView8.Rows[1].Cells[2].Value = xh_8_1;
                    rowMergeView8.Rows[1].Cells[3].Value = djgl_8_1.ToString("0.00");
                    rowMergeView8.Rows[1].Cells[4].Value = sl_8_1.ToString("0");
                    rowMergeView8.Rows[1].Cells[5].Value = dw_8_1;
                    rowMergeView8.Rows[1].Cells[6].Value = (sl_8_1*djgl_8_1).ToString("0.00");
                    rowMergeView8.Rows[1].Cells[7].Value = ys_8_1.ToString("0.00");
                    rowMergeView8.Rows[1].Cells[8].Value = (sl_8_1 * djgl_8_1*ys_8_1*24).ToString("0.000");

                    //a7 鼓风机
                    string xh_8_2 = dtx_a7.Rows[0][8].ToString();
                    double djgl_8_2 = double.Parse(dtx_a7.Rows[0][13].ToString());
                    double sl_8_2 = i_a7;
                    string dw_8_2 = dtx_a7.Rows[0][17].ToString();
                    double sx_8_2 = double.Parse(dtx_a7.Rows[0][7].ToString());
                    double ys_8_2 = double.Parse(dtx_a7.Rows[0][7].ToString());
                    if (sl_8_2 <= 1)
                    { ys_8_2 = 1 / sl_8_2; }
                    else
                    { ys_8_2 = (sl_8_2 - 1) / sl_8_2; }

                    rowMergeView8.Rows[2].Cells[0].Value = "污水处理单元";
                    rowMergeView8.Rows[2].Cells[1].Value = "鼓风机";
                    rowMergeView8.Rows[2].Cells[2].Value = xh_8_2;
                    rowMergeView8.Rows[2].Cells[3].Value = djgl_8_2.ToString("0.00");
                    rowMergeView8.Rows[2].Cells[4].Value = sl_8_2.ToString("0");
                    rowMergeView8.Rows[2].Cells[5].Value = dw_8_2;
                    rowMergeView8.Rows[2].Cells[6].Value = (sl_8_2 * djgl_8_2).ToString("0.00");
                    rowMergeView8.Rows[2].Cells[7].Value = ys_8_2.ToString("0.00");
                    rowMergeView8.Rows[2].Cells[8].Value = (sl_8_2 * djgl_8_2 * ys_8_2 * 24).ToString("0.000");

                    //a8 膜出水泵
                    string xh_8_3 = dtx_a8.Rows[0][8].ToString();
                    double djgl_8_3 = double.Parse(dtx_a8.Rows[0][13].ToString());
                    double sl_8_3 = i_a8;
                    string dw_8_3 = dtx_a8.Rows[0][17].ToString();
                    double sx_8_3 = double.Parse(dtx_a8.Rows[0][7].ToString());
                    double ys_8_3 = double.Parse(dtx_a8.Rows[0][7].ToString());
                    if (sl_8_3 <= 1)
                    { ys_8_3 = 1 / sl_8_3 * 20 / 24; }
                    else
                    { ys_8_3 = (sl_8_3 - 1) / sl_8_3 * 20 / 24; }
             
                    rowMergeView8.Rows[3].Cells[0].Value = "污水处理单元";
                    rowMergeView8.Rows[3].Cells[1].Value = "膜出水泵";
                    rowMergeView8.Rows[3].Cells[2].Value = xh_8_3;
                    rowMergeView8.Rows[3].Cells[3].Value = djgl_8_3.ToString("0.00");
                    rowMergeView8.Rows[3].Cells[4].Value = sl_8_3.ToString("0");
                    rowMergeView8.Rows[3].Cells[5].Value = dw_8_3;
                    rowMergeView8.Rows[3].Cells[6].Value = (sl_8_3 * djgl_8_3).ToString("0.00");
                    rowMergeView8.Rows[3].Cells[7].Value = ys_8_3.ToString("0.00");
                    rowMergeView8.Rows[3].Cells[8].Value = (sl_8_3 * djgl_8_3 * ys_8_3 * 24).ToString("0.000");

                    //a9 回流泵
                    string xh_8_4 = dtx_a9.Rows[0][8].ToString();
                    double djgl_8_4 = double.Parse(dtx_a9.Rows[0][13].ToString());
                    double sl_8_4 = i_a9;
                    string dw_8_4 = dtx_a9.Rows[0][17].ToString();
                    double sx_8_4 = double.Parse(dtx_a9.Rows[0][7].ToString());
                    double ys_8_4 = double.Parse(dtx_a9.Rows[0][7].ToString());
                    if (sl_8_4 <= 1)
                    { ys_8_4 = 1 * double.Parse(s_D45)/sx_8_4; }
                    else
                    { ys_8_4 = (sl_8_4 - 1) / sl_8_4 * double.Parse(s_D45) / sx_8_1; }
                    
                    rowMergeView8.Rows[4].Cells[0].Value = "污水处理单元";
                    rowMergeView8.Rows[4].Cells[1].Value = "回流泵";
                    rowMergeView8.Rows[4].Cells[2].Value = xh_8_4;
                    rowMergeView8.Rows[4].Cells[3].Value = djgl_8_4.ToString("0.00");
                    rowMergeView8.Rows[4].Cells[4].Value = sl_8_4.ToString("0");
                    rowMergeView8.Rows[4].Cells[5].Value = dw_8_4;
                    rowMergeView8.Rows[4].Cells[6].Value = (sl_8_4 * djgl_8_4).ToString("0.00");
                    rowMergeView8.Rows[4].Cells[7].Value = ys_8_4.ToString("0.00");
                    rowMergeView8.Rows[4].Cells[8].Value = (sl_8_4 * djgl_8_4 * ys_8_4 * 24).ToString("0.000");

                    //a12 MSTD膜出水泵
                    string xh_8_5 = dtx_a12.Rows[0][8].ToString();
                    double djgl_8_5 = double.Parse(dtx_a12.Rows[0][13].ToString());
                    double sl_8_5 = i_a12;
                    string dw_8_5 = dtx_a12.Rows[0][17].ToString();
                    double sx_8_5 = double.Parse(dtx_a12.Rows[0][7].ToString());
                    double ys_8_5 = double.Parse(dtx_a12.Rows[0][7].ToString());
                    if (sl_8_5 <= 1)
                    { ys_8_5 = 20.0/24.0; }
                    else
                    { ys_8_5 = 20.0/24.0; }

                    rowMergeView8.Rows[5].Cells[0].Value = "污泥处理单元";
                    rowMergeView8.Rows[5].Cells[1].Value = "MSTD出水泵";
                    rowMergeView8.Rows[5].Cells[2].Value = xh_8_5;
                    rowMergeView8.Rows[5].Cells[3].Value = djgl_8_5.ToString("0.00");
                    rowMergeView8.Rows[5].Cells[4].Value = sl_8_5.ToString("0");
                    rowMergeView8.Rows[5].Cells[5].Value = dw_8_5;
                    rowMergeView8.Rows[5].Cells[6].Value = (sl_8_5 * djgl_8_5).ToString("0.00");
                    rowMergeView8.Rows[5].Cells[7].Value = ys_8_5.ToString("0.00");
                    rowMergeView8.Rows[5].Cells[8].Value = (sl_8_5 * djgl_8_5 * ys_8_5 * 24).ToString("0.000");

                    //a13 排泥泵 
                    string xh_8_6 = dtx_a13.Rows[0][8].ToString();
                    double djgl_8_6 = double.Parse(dtx_a13.Rows[0][13].ToString());
                    double sl_8_6 = i_a13;
                    string dw_8_6 = dtx_a13.Rows[0][17].ToString();
                    double sx_8_6 = double.Parse(dtx_a13.Rows[0][7].ToString());
                    double ys_8_6 = double.Parse(dtx_a13.Rows[0][7].ToString());
                    if (sl_8_6 <= 1)
                    { ys_8_6 = double.Parse(s_D30)/24/sx_8_6; }
                    else
                    { ys_8_6 = double.Parse(s_D30) / 24 / sx_8_6; }

                    rowMergeView8.Rows[6].Cells[0].Value = "污泥处理单元";
                    rowMergeView8.Rows[6].Cells[1].Value = "排泥泵";
                    rowMergeView8.Rows[6].Cells[2].Value = xh_8_6;
                    rowMergeView8.Rows[6].Cells[3].Value = djgl_8_6.ToString("0.00");
                    rowMergeView8.Rows[6].Cells[4].Value = sl_8_6.ToString("0");
                    rowMergeView8.Rows[6].Cells[5].Value = dw_8_6;
                    rowMergeView8.Rows[6].Cells[6].Value = (sl_8_6 * djgl_8_6).ToString("0.00");
                    rowMergeView8.Rows[6].Cells[7].Value = ys_8_6.ToString("0.00");
                    rowMergeView8.Rows[6].Cells[8].Value = (sl_8_6 * djgl_8_6 * ys_8_6 * 24).ToString("0.000");

                    double zgl =
                                    (sl_8_1 * djgl_8_1) +
                                    (sl_8_2 * djgl_8_2) +
                                    (sl_8_3 * djgl_8_3) +
                                    (sl_8_4 * djgl_8_4) +
                                    (sl_8_5 * djgl_8_5) +
                                    (sl_8_6 * djgl_8_6); //总功率
            

                    double zhn =
                            (sl_8_1 * djgl_8_1 * ys_8_1 * 24) +
                            (sl_8_2 * djgl_8_2 * ys_8_2 * 24) +
                            (sl_8_3 * djgl_8_3 * ys_8_3 * 24) +
                            (sl_8_4 * djgl_8_4 * ys_8_4 * 24) +
                            (sl_8_5 * djgl_8_5 * ys_8_5 * 24) +
                            (sl_8_6 * djgl_8_6 * ys_8_6 * 24); //总能耗
                    this.SBNHZB = zhn;

                    rowMergeView8.Rows.Add();
                    rowMergeView8.Rows[7].Cells[0].Value = "合计";
                    rowMergeView8.Rows[7].Cells[1].Value = "";
                    rowMergeView8.Rows[7].Cells[2].Value = "";
                    rowMergeView8.Rows[7].Cells[3].Value = "";
                    rowMergeView8.Rows[7].Cells[4].Value = "";
                    rowMergeView8.Rows[7].Cells[5].Value = "总功率合计：";
                    rowMergeView8.Rows[7].Cells[6].Value = zgl.ToString("0.00");
                    rowMergeView8.Rows[7].Cells[7].Value = "运行能耗合计：";
                    rowMergeView8.Rows[7].Cells[8].Value = zhn.ToString("0.000");

                    
                    rowMergeView8.Rows[8].Cells[0].Value = "吨水处理能耗";
                    rowMergeView8.Rows[8].Cells[1].Value = "(KWh)";
                    rowMergeView8.Rows[8].Cells[2].Value = "";
                    rowMergeView8.Rows[8].Cells[3].Value = "";
                    rowMergeView8.Rows[8].Cells[4].Value = "";
                    rowMergeView8.Rows[8].Cells[5].Value = "";
                    rowMergeView8.Rows[8].Cells[6].Value = "";
                    rowMergeView8.Rows[8].Cells[7].Value = "";
                    rowMergeView8.Rows[8].Cells[8].Value = (zhn/double.Parse(s_D1)).ToString("0.00");

                    rowMergeView8.Rows[9].Cells[0].Value = "吨水处理电费";
                    rowMergeView8.Rows[9].Cells[1].Value = "";
                    rowMergeView8.Rows[9].Cells[2].Value = "";
                    rowMergeView8.Rows[9].Cells[3].Value = "";
                    rowMergeView8.Rows[9].Cells[4].Value = "";
                    rowMergeView8.Rows[9].Cells[5].Value = "";
                    rowMergeView8.Rows[9].Cells[6].Value = "";
                    rowMergeView8.Rows[9].Cells[7].Value = "";
                    rowMergeView8.Rows[9].Cells[8].Value = (zhn / double.Parse(s_D1)*0.6).ToString("0.00");

                    #endregion

                    #region 表9计算
            //--------------------------------------------异常开始     
        //    try
        //            {
                    string xh_9_0 = dtx_a3.Rows[0][8].ToString();
                    double sl_9_0 = i_a3;
                    string dw_9_0 = dtx_a3.Rows[0][17].ToString();
                    double dj_9_0 = double.Parse(dtx_a3.Rows[0][44].ToString());

                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[0].Cells[0].Value = "水箱/水池";
                    rowMergeView9.Rows[0].Cells[1].Value = "";
                    rowMergeView9.Rows[0].Cells[2].Value = xh_9_0;
                    rowMergeView9.Rows[0].Cells[3].Value = sl_9_0.ToString("0.00");
                    rowMergeView9.Rows[0].Cells[4].Value = dw_9_0;
                    rowMergeView9.Rows[0].Cells[5].Value = dj_9_0.ToString("0.00");
                    rowMergeView9.Rows[0].Cells[6].Value = (dj_9_0 * sl_9_0).ToString("0.00");

                    string xh_9_1 = dtx_a4.Rows[0][8].ToString();
                    double sl_9_1 = i_a4;
                    string dw_9_1 = dtx_a4.Rows[0][17].ToString();
                    double dj_9_1 = double.Parse(dtx_a4.Rows[0][44].ToString());
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[1].Cells[0].Value = "设备箱";
                    rowMergeView9.Rows[1].Cells[1].Value = "";
                    rowMergeView9.Rows[1].Cells[2].Value = xh_9_1;
                    rowMergeView9.Rows[1].Cells[3].Value = sl_9_1.ToString("0.00");
                    rowMergeView9.Rows[1].Cells[4].Value = dw_9_1;
                    rowMergeView9.Rows[1].Cells[5].Value = dj_9_1.ToString("0.00");
                    rowMergeView9.Rows[1].Cells[6].Value = (dj_9_1 * sl_9_1).ToString("0.00");

                    string xh_9_2 = dtx_a5.Rows[0][8].ToString();
                    double sl_9_2 = i_a5;
                    string dw_9_2 = dtx_a5.Rows[0][17].ToString();
                    double dj_9_2 = double.Parse(dtx_a5.Rows[0][44].ToString());

                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[2].Cells[0].Value = "预处理单元";
                    rowMergeView9.Rows[2].Cells[1].Value = "格栅";
                    rowMergeView9.Rows[2].Cells[2].Value = xh_9_2;
                    rowMergeView9.Rows[2].Cells[3].Value = sl_9_2.ToString("0.00");
                    rowMergeView9.Rows[2].Cells[4].Value = dw_9_2;
                    rowMergeView9.Rows[2].Cells[5].Value = dj_9_2.ToString("0.00");
                    rowMergeView9.Rows[2].Cells[6].Value = (dj_9_2 * sl_9_2).ToString("0.00");

                    string xh_9_3 = dtx_a6.Rows[0][8].ToString();
                    double sl_9_3 = i_a6;
                    string dw_9_3 = dtx_a6.Rows[0][17].ToString();
                    double dj_9_3 = double.Parse(dtx_a6.Rows[0][44].ToString());
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[3].Cells[0].Value = "预处理单元";
                    rowMergeView9.Rows[3].Cells[1].Value = "调节池进水泵";
                    rowMergeView9.Rows[3].Cells[2].Value = xh_9_3;
                    rowMergeView9.Rows[3].Cells[3].Value = sl_9_3.ToString("0.00");
                    rowMergeView9.Rows[3].Cells[4].Value = dw_9_3;
                    rowMergeView9.Rows[3].Cells[5].Value = dj_9_3.ToString("0.00");
                    rowMergeView9.Rows[3].Cells[6].Value = (dj_9_3 * sl_9_3).ToString("0.00");

                    string xh_9_4 = dtx_a7.Rows[0][8].ToString();
                    double sl_9_4 = i_a7;
                    string dw_9_4 = dtx_a7.Rows[0][17].ToString();
                    double dj_9_4 = double.Parse(dtx_a7.Rows[0][44].ToString());
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[4].Cells[0].Value = "污水处理单元";
                    rowMergeView9.Rows[4].Cells[1].Value = "鼓风机";
                    rowMergeView9.Rows[4].Cells[2].Value = xh_9_4;
                    rowMergeView9.Rows[4].Cells[3].Value = sl_9_4.ToString("0.00");
                    rowMergeView9.Rows[4].Cells[4].Value = dw_9_4;
                    rowMergeView9.Rows[4].Cells[5].Value = dj_9_4.ToString("0.00");
                    rowMergeView9.Rows[4].Cells[6].Value = (dj_9_4 * sl_9_4).ToString("0.00");

                    string xh_9_5 = dtx_a8.Rows[0][8].ToString();
                    double sl_9_5 = i_a8;
                    string dw_9_5 = dtx_a8.Rows[0][17].ToString();
                    double dj_9_5 = double.Parse(dtx_a8.Rows[0][44].ToString());
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[5].Cells[0].Value = "污水处理单元";
                    rowMergeView9.Rows[5].Cells[1].Value = "膜出水泵";
                    rowMergeView9.Rows[5].Cells[2].Value = xh_9_5;
                    rowMergeView9.Rows[5].Cells[3].Value = sl_9_5.ToString("0.00");
                    rowMergeView9.Rows[5].Cells[4].Value = dw_9_5;
                    rowMergeView9.Rows[5].Cells[5].Value = dj_9_5.ToString("0.00");
                    rowMergeView9.Rows[5].Cells[6].Value = (dj_9_5 * sl_9_5).ToString("0.00");

                    string xh_9_6 = dtx_a9.Rows[0][8].ToString();
                    double sl_9_6 = i_a9;
                    string dw_9_6 = dtx_a9.Rows[0][17].ToString();
                    double dj_9_6 = double.Parse(dtx_a9.Rows[0][44].ToString());

                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[6].Cells[0].Value = "污水处理单元";
                    rowMergeView9.Rows[6].Cells[1].Value = "回流泵";
                    rowMergeView9.Rows[6].Cells[2].Value = xh_9_6;
                    rowMergeView9.Rows[6].Cells[3].Value = sl_9_6.ToString("0.00");
                    rowMergeView9.Rows[6].Cells[4].Value = dw_9_6;
                    rowMergeView9.Rows[6].Cells[5].Value = dj_9_6.ToString("0.00");
                    rowMergeView9.Rows[6].Cells[6].Value = (dj_9_6 * sl_9_6).ToString("0.00");

                    string xh_9_7 = dtx_a10.Rows[0][8].ToString();
                    double sl_9_7 = i_a10;
                    string dw_9_7 = dtx_a10.Rows[0][17].ToString();
                    double dj_9_7 = double.Parse(dtx_a10.Rows[0][44].ToString());

                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[7].Cells[0].Value = "污水处理单元";
                    rowMergeView9.Rows[7].Cells[1].Value = "膜组件";
                    rowMergeView9.Rows[7].Cells[2].Value = xh_9_7;
                    rowMergeView9.Rows[7].Cells[3].Value = sl_9_7.ToString("0.00");
                    rowMergeView9.Rows[7].Cells[4].Value = dw_9_7;
                    rowMergeView9.Rows[7].Cells[5].Value = dj_9_7.ToString("0.00");
                    rowMergeView9.Rows[7].Cells[6].Value = (dj_9_7 * sl_9_7).ToString("0.00");

                    string xh_9_8 = dtx_a12.Rows[0][8].ToString();
                    double sl_9_8 = i_a12;
                    string dw_9_8 = dtx_a12.Rows[0][17].ToString();
                    double dj_9_8 = double.Parse(dtx_a12.Rows[0][44].ToString());
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[8].Cells[0].Value = "污泥处理单元";
                    rowMergeView9.Rows[8].Cells[1].Value = "MSTD出水泵";
                    rowMergeView9.Rows[8].Cells[2].Value = xh_9_8;
                    rowMergeView9.Rows[8].Cells[3].Value = sl_9_8.ToString("0.00");
                    rowMergeView9.Rows[8].Cells[4].Value = dw_9_8;
                    rowMergeView9.Rows[8].Cells[5].Value = dj_9_8.ToString("0.00");
                    rowMergeView9.Rows[8].Cells[6].Value = (dj_9_8 * sl_9_8).ToString("0.00");
                   
                        string xh_9_9 = dtx_a14.Rows[0][8].ToString();
                        double sl_9_9 = i_a14;
                        string dw_9_9 = dtx_a14.Rows[0][17].ToString();
                        double dj_9_9 = double.Parse(dtx_a14.Rows[0][44].ToString());
                    
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[9].Cells[0].Value = "污泥处理单元";
                    rowMergeView9.Rows[9].Cells[1].Value = "MSTD膜组件";
                    rowMergeView9.Rows[9].Cells[2].Value = xh_9_9;
                    rowMergeView9.Rows[9].Cells[3].Value = sl_9_9.ToString("0.00");
                    rowMergeView9.Rows[9].Cells[4].Value = dw_9_9;
                    rowMergeView9.Rows[9].Cells[5].Value = dj_9_9.ToString("0.00");
                    rowMergeView9.Rows[9].Cells[6].Value = (dj_9_9 * sl_9_9).ToString("0.00");

                    string xh_9_10 = dtx_a13.Rows[0][8].ToString();
                    double sl_9_10 = i_a13;
                    string dw_9_10 = dtx_a13.Rows[0][17].ToString();
                    double dj_9_10 = double.Parse(dtx_a13.Rows[0][44].ToString());
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[10].Cells[0].Value = "污泥处理单元";
                    rowMergeView9.Rows[10].Cells[1].Value = "排泥泵";
                    rowMergeView9.Rows[10].Cells[2].Value = xh_9_10;
                    rowMergeView9.Rows[10].Cells[3].Value = sl_9_10.ToString("0.00");
                    rowMergeView9.Rows[10].Cells[4].Value = dw_9_10;
                    rowMergeView9.Rows[10].Cells[5].Value = dj_9_10.ToString("0.00");
                    rowMergeView9.Rows[10].Cells[6].Value = (dj_9_10 * sl_9_10).ToString("0.00");

                    string xh_9_11 = "";
                    double sl_9_11 = 1.00;
                    string dw_9_11 = "批";
                    DataTable PJ1 = Helper.GetDataTableFromDB("SELECT TOP 1 PJ.JE FROM PJ WHERE  " + s_D1 + " >=PJ.XS AND " + s_D1 + " <= PJ.SX AND PJ.PJ='GPJ'");
                    double dj_9_11 = double.Parse(PJ1.Rows[0][0].ToString());
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[11].Cells[0].Value = "附件";
                    rowMergeView9.Rows[11].Cells[1].Value = "管配件";
                    rowMergeView9.Rows[11].Cells[2].Value = xh_9_11;
                    rowMergeView9.Rows[11].Cells[3].Value = sl_9_11.ToString("0.00");
                    rowMergeView9.Rows[11].Cells[4].Value = dw_9_11;
                    rowMergeView9.Rows[11].Cells[5].Value = dj_9_11.ToString("0.00");
                    rowMergeView9.Rows[11].Cells[6].Value = (dj_9_11 * sl_9_11).ToString("0.00");

                    string xh_9_12 = "";
                    double sl_9_12 = 1;
                    string dw_9_12 = "批";
                    DataTable PJ2 = Helper.GetDataTableFromDB("SELECT TOP 1 PJ.JE FROM PJ WHERE   " + s_D1 + " >=PJ.XS AND " + s_D1 + " <= PJ.SX AND PJ.PJ='DXDL'");
                    double dj_9_12 = double.Parse(PJ2.Rows[0][0].ToString());

                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[12].Cells[0].Value = "附件";
                    rowMergeView9.Rows[12].Cells[1].Value = "电线电缆";
                    rowMergeView9.Rows[12].Cells[2].Value = xh_9_12;
                    rowMergeView9.Rows[12].Cells[3].Value = sl_9_12.ToString("0.00");
                    rowMergeView9.Rows[12].Cells[4].Value = dw_9_12;
                    rowMergeView9.Rows[12].Cells[5].Value = dj_9_12.ToString("0.00");
                    rowMergeView9.Rows[12].Cells[6].Value = (dj_9_12 * sl_9_12).ToString("0.00");

                    //rowMergeView9.Rows.Add();
                   double ysxj1 =(dj_9_0 * sl_9_0)
                                + (dj_9_1 * sl_9_1)
                                + (dj_9_2 * sl_9_2)
                                + (dj_9_3 * sl_9_3)
                                + (dj_9_4 * sl_9_4)
                                + (dj_9_5 * sl_9_5)
                                + (dj_9_6 * sl_9_6)
                                + (dj_9_7 * sl_9_7)
                                + (dj_9_8 * sl_9_8)
                                + (dj_9_9 * sl_9_9)
                                + (dj_9_10 * sl_9_10)
                                + (dj_9_11 * sl_9_11)
                                + (dj_9_12 * sl_9_12);
                    rowMergeView9.Rows[13].Cells[0].Value = "以上";
                    rowMergeView9.Rows[13].Cells[1].Value = "小计";
                    rowMergeView9.Rows[13].Cells[2].Value = "";
                    rowMergeView9.Rows[13].Cells[3].Value = "";
                    rowMergeView9.Rows[13].Cells[4].Value = "";
                    rowMergeView9.Rows[13].Cells[5].Value = "";
                    rowMergeView9.Rows[13].Cells[6].Value =ysxj1.ToString("0.00");

                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[14].Cells[0].Value = "";
                    rowMergeView9.Rows[14].Cells[1].Value = "安装费";
                    rowMergeView9.Rows[14].Cells[2].Value = "";
                    rowMergeView9.Rows[14].Cells[3].Value = "";
                    rowMergeView9.Rows[14].Cells[4].Value = "";
                    rowMergeView9.Rows[14].Cells[5].Value = "";
                    rowMergeView9.Rows[14].Cells[6].Value = (ysxj1*0.05).ToString("0.00");

                    
                    //rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[15].Cells[0].Value = "";
                    rowMergeView9.Rows[15].Cells[1].Value = "调试费";
                    rowMergeView9.Rows[15].Cells[2].Value = "";
                    rowMergeView9.Rows[15].Cells[3].Value = "";
                    rowMergeView9.Rows[15].Cells[4].Value = "";
                    rowMergeView9.Rows[15].Cells[5].Value = "";
                    rowMergeView9.Rows[15].Cells[6].Value = (ysxj1 * 0.05).ToString("0.00");

                    double ysxj2 = (ysxj1 * 0.05) + (ysxj1 * 0.05);
                   // rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[16].Cells[0].Value = "以上";
                    rowMergeView9.Rows[16].Cells[1].Value = "合计";
                    rowMergeView9.Rows[16].Cells[2].Value = "";
                    rowMergeView9.Rows[16].Cells[3].Value = "";
                    rowMergeView9.Rows[16].Cells[4].Value = "";
                    rowMergeView9.Rows[16].Cells[5].Value = "";
                    rowMergeView9.Rows[16].Cells[6].Value = ysxj2.ToString("0.00");

                    // rowMergeView9.Rows.Add();
                    rowMergeView9.Rows[17].Cells[0].Value = "总合计";
                    rowMergeView9.Rows[17].Cells[1].Value = "";
                    rowMergeView9.Rows[17].Cells[2].Value = "";
                    rowMergeView9.Rows[17].Cells[3].Value = "";
                    rowMergeView9.Rows[17].Cells[4].Value = "";
                    rowMergeView9.Rows[17].Cells[5].Value = "";
                    rowMergeView9.Rows[17].Cells[6].Value = (ysxj1 + ysxj2).ToString("0.00");
                    this.sl_c_10_0 = sl_9_0;
                    this.dw_c_10_0 = dw_9_0;
                    this.dj_c_10_0 = dj_9_0;
                    this.xh_c_10_1 = xh_9_1;
                    this.sl_c_10_1 = sl_9_1;
                    this.dw_c_10_1 = dw_9_1;
                    this.dj_c_10_1 = dj_9_1;
                    this.xh_c_10_2 = xh_9_2;
                    this.sl_c_10_2 = sl_9_2;
                    this.dw_c_10_2 = dw_9_2;
                    this.dj_c_10_2 = dj_9_2;
                    this.xh_c_10_3 = xh_9_3;
                    this.sl_c_10_3 = sl_9_3;
                    this.dw_c_10_3 = dw_9_3;
                    this.dj_c_10_3 = dj_9_3;
                    this.xh_c_10_4 = xh_9_4;
                    this.sl_c_10_4 = sl_9_4;
                    this.xh_c_10_0 = xh_9_0;
                    this.dw_c_10_4 = dw_9_4;
                    this.dj_c_10_4 = dj_9_4;
                    this.xh_c_10_5 = xh_9_5;
                    this.sl_c_10_5 = sl_9_5;
                    this.dw_c_10_5 = dw_9_5;
                    this.dj_c_10_5 = dj_9_5;
                    this.xh_c_10_6 = xh_9_6;
                    this.sl_c_10_6 = sl_9_6;
                    this.dw_c_10_6 = dw_9_6;
                    this.dj_c_10_6 = dj_9_6;
                    this.xh_c_10_7 = xh_9_7;
                    this.sl_c_10_7 = sl_9_7;
                    this.dw_c_10_7 = dw_9_7;
                    this.dj_c_10_7 = dj_9_7;
                    this.xh_c_10_8 = xh_9_8;
                    this.sl_c_10_8 = sl_9_8;
                    this.dw_c_10_8 = dw_9_8;
                    this.dj_c_10_8 = dj_9_8;
                    this.xh_c_10_9 = xh_9_9;
                    this.sl_c_10_9 = sl_9_9;
                    this.dw_c_10_9 = dw_9_9;
                    this.dj_c_10_9 = dj_9_9;
                    this.xh_c_10_10 = xh_9_10;
                    this.sl_c_10_10 = sl_9_10;
                    this.dw_c_10_10 = dw_9_10;
                    this.dj_c_10_10 = dj_9_10;
                    this.xh_c_10_11 = xh_9_11;
                    this.sl_c_10_11 = sl_9_11;
                    this.dw_c_10_11 = dw_9_11;
                    this.dj_c_10_11 = dj_9_11;
                    this.xh_c_10_12 = xh_9_12;
                    this.sl_c_10_12 = sl_9_12;
                    this.dw_c_10_12 = dw_9_12;
                    this.dj_c_10_12 = dj_9_12;
                    #endregion
   //------------------------------------------------异常结束
       //             }
       //             catch (Exception ex)
       //             {
       //                 MessageBox.Show("计算过程中发生异常，请重主页面重新计算");
       //             }
                    dtwd4 = DataTableHelper.CreateTable("BM,BY1,BY2,BY3,BY4,BZ,TYPE");
            /*
                    dtwd4.Rows.Add(new object[] { "编号", "名称", "数量", "单位","内部尺寸（m）","备注", "B42" });
                    dtwd4.Rows.Add(new object[] { "1", rowMergeView6.Rows[1].Cells[1].Value, 1, "座", rowMergeView6.Rows[1].Cells[2].Value.ToString().Remove(rowMergeView6.Rows[1].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[1].Cells[3].Value.ToString().Remove(rowMergeView6.Rows[1].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[1].Cells[4].Value.ToString() + "m","", "B42" });
                    dtwd4.Rows.Add(new object[] { "2", rowMergeView6.Rows[2].Cells[1].Value, 1, "座", rowMergeView6.Rows[2].Cells[2].Value.ToString().Remove(rowMergeView6.Rows[2].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[2].Cells[3].Value.ToString().Remove(rowMergeView6.Rows[2].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[2].Cells[4].Value.ToString() + "m","", "B42" });
                    dtwd4.Rows.Add(new object[] { "3", rowMergeView6.Rows[3].Cells[1].Value, 1, "座", rowMergeView6.Rows[3].Cells[2].Value.ToString().Remove(rowMergeView6.Rows[3].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[3].Cells[3].Value.ToString().Remove(rowMergeView6.Rows[3].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[3].Cells[4].Value.ToString() + "m", "","B42" });
                    dtwd4.Rows.Add(new object[] { "4", rowMergeView6.Rows[4].Cells[1].Value, 1, "座", rowMergeView6.Rows[4].Cells[2].Value.ToString().Remove(rowMergeView6.Rows[4].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[4].Cells[3].Value.ToString().Remove(rowMergeView6.Rows[4].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[4].Cells[4].Value.ToString() + "m", "","B42" });
                    dtwd4.Rows.Add(new object[] { "5", rowMergeView6.Rows[5].Cells[1].Value, 1, "座", rowMergeView6.Rows[5].Cells[2].Value.ToString().Remove(rowMergeView6.Rows[5].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[5].Cells[3].Value.ToString().Remove(rowMergeView6.Rows[5].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView6.Rows[5].Cells[4].Value.ToString() + "m", "","B42" });
                    dtwd4.Rows.Add(new object[] { "6", rowMergeView7.Rows[1].Cells[1].Value, 1, "座", rowMergeView7.Rows[1].Cells[2].Value.ToString().Remove(rowMergeView7.Rows[1].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView7.Rows[1].Cells[3].Value.ToString().Remove(rowMergeView6.Rows[1].Cells[2].Value.ToString().Length - 4, 4) + "X" + rowMergeView7.Rows[1].Cells[4].Value.ToString() + "m","", "B43" });
            */

                    dtwd4.Rows.Add(new object[] { "编号", "名称", "数量", "单位", "内部尺寸（m）", "备注", "B42" });
                    dtwd4.Rows.Add(new object[] { "1", rowMergeView6.Rows[1].Cells[1].Value, 1, "座", rowMergeView6.Rows[1].Cells[2].Value.ToString() + "×" + rowMergeView6.Rows[1].Cells[3].Value.ToString() + "×" + rowMergeView6.Rows[1].Cells[4].Value.ToString() + "m", "LxBxH", "B42" });
                    dtwd4.Rows.Add(new object[] { "2", rowMergeView6.Rows[2].Cells[1].Value, 1, "座", rowMergeView6.Rows[2].Cells[2].Value.ToString() + "×" + rowMergeView6.Rows[2].Cells[3].Value.ToString() + "×" + rowMergeView6.Rows[2].Cells[4].Value.ToString() + "m", "L1xB1xH", "B42" });
                    dtwd4.Rows.Add(new object[] { "3", rowMergeView6.Rows[3].Cells[1].Value, 1, "座", rowMergeView6.Rows[3].Cells[2].Value.ToString() + "×" + rowMergeView6.Rows[3].Cells[3].Value.ToString() + "×" + rowMergeView6.Rows[3].Cells[4].Value.ToString() + "m", "L2xB2xH", "B42" });
                    dtwd4.Rows.Add(new object[] { "4", rowMergeView6.Rows[4].Cells[1].Value, 1, "座", rowMergeView6.Rows[4].Cells[2].Value.ToString() + "×" + rowMergeView6.Rows[4].Cells[3].Value.ToString() + "×" + rowMergeView6.Rows[4].Cells[4].Value.ToString() + "m", "L3xB2xH", "B42" });
                    dtwd4.Rows.Add(new object[] { "5", rowMergeView6.Rows[5].Cells[1].Value, 1, "座", rowMergeView6.Rows[5].Cells[2].Value.ToString() + "×" + rowMergeView6.Rows[5].Cells[3].Value.ToString() + "×" + rowMergeView6.Rows[5].Cells[4].Value.ToString() + "m", "L4xB2xH", "B42" });
                    dtwd4.Rows.Add(new object[] { "6", rowMergeView7.Rows[0].Cells[0].Value, 1, "座", rowMergeView7.Rows[1].Cells[2].Value.ToString() + "×" + rowMergeView7.Rows[1].Cells[3].Value.ToString() + "×" + rowMergeView7.Rows[1].Cells[4].Value.ToString() + "m", "LxBxH", "B43" });

                    
        
        }

        public void Dtwd_DT(int type,DataTable Dtd)
        {
            if (type == 1)
            {
                dtwd5 = DataTableHelper.CreateTable("BY0,BY1,BY2,BY3,BY4,BY5,BY6,TYPE");
                for (int i = 0; i < rowMergeView11.Rows.Count; i++)
                {
                    dtwd5.Rows.Add(new object[] { 
                    rowMergeView11.Rows[i].Cells[0].Value,
                    rowMergeView11.Rows[i].Cells[1].Value,
                    rowMergeView11.Rows[i].Cells[2].Value,
                    rowMergeView11.Rows[i].Cells[3].Value,
                    "","","","11"});
                }
                for (int j = 0; j < rowMergeView10.Rows.Count; j++)
                {
                    dtwd5.Rows.Add(new object[] { 
                    rowMergeView10.Rows[j].Cells[0].Value,
                    rowMergeView10.Rows[j].Cells[1].Value,
                    rowMergeView10.Rows[j].Cells[2].Value,
                    rowMergeView10.Rows[j].Cells[3].Value,
                    rowMergeView10.Rows[j].Cells[4].Value,
                    rowMergeView10.Rows[j].Cells[5].Value,
                    rowMergeView10.Rows[j].Cells[6].Value,
                    "10"});
                }
            }
            if (type == 2) 
            {
            dtwd2 = DataTableHelper.CreateTable("BM,BY1,BY2,BZ,TYPE");
            dtwd2.Rows.Add(new object[] { "1", "", rowMergeView1.Rows[1].Cells[1].Value, "", "bg" });//Z_A41_B_13
            dtwd2.Rows.Add(new object[] { "2", "", rowMergeView1.Rows[1].Cells[2].Value, "", "bg" });//Z_A41_B_23
            dtwd2.Rows.Add(new object[] { "3", "", rowMergeView1.Rows[1].Cells[3].Value, "", "bg" });//Z_A41_B_33
            dtwd2.Rows.Add(new object[] { "4", "", rowMergeView1.Rows[1].Cells[4].Value, "", "bg" }); //Z_A41_B_43
            dtwd2.Rows.Add(new object[] { "5", "", rowMergeView1.Rows[1].Cells[5].Value, "", "bg" }); //Z_A41_B_53
            dtwd2.Rows.Add(new object[] { "6", "", rowMergeView1.Rows[1].Cells[6].Value, "", "bg" }); //Z_A41_B_63
            dtwd2.Rows.Add(new object[] { "5", "", rowMergeView6.Rows[1].Cells[2].Value.ToString() + "×" + rowMergeView6.Rows[1].Cells[3].Value.ToString() + "×" + rowMergeView6.Rows[1].Cells[4].Value.ToString(), "", "bg" }); //Z_A41_B_73

            dtwd2.Rows.Add(new object[] { "0", "D42", Dtd.Select("BS='SJ' AND WZ='D42'")[0][2], "", "JS" });
            dtwd2.Rows.Add(new object[] { "1", "D19", Dtd.Select("BS='SJ' AND WZ='D19'")[0][2], "", "JS" });
            dtwd2.Rows.Add(new object[] { "2", "D16", Dtd.Select("BS='SJ' AND WZ='D16'")[0][2], "", "JS" });
            dtwd2.Rows.Add(new object[] { "3", "D17", Dtd.Select("BS='SJ' AND WZ='D17'")[0][2], "", "JS" });
            dtwd2.Rows.Add(new object[] { "4", "I9", Dtd.Select("BS='SJ' AND WZ='I9'")[0][2], "", "JS" }); //替换i10
            dtwd2.Rows.Add(new object[] { "5", "D25", Dtd.Select("BS='SJ' AND WZ='D25'")[0][2], "", "JS" });
            dtwd2.Rows.Add(new object[] { "6", "D34", Dtd.Select("BS='SJ' AND WZ='D34'")[0][2], "", "JS" });

            //  -------------------------------------------------------------------------------------------------------------
            }
            if (type == 3)
            { 

                dtwd6 = DataTableHelper.CreateTable("BY0,BY1,BY2,BY3,BY4,BY5,BY6,BY7");
                dtwd6.Rows.Add(new object[]{" 编号","名称","参数","数量","单位","单价","总价","备注"});
                for (var i = 0; i < rowMergeView10.Rows.Count; i++)
                {
                    string s;
                    if (rowMergeView10.Rows[i].Cells[1].Value.ToString() == "")
                    {
                        s = rowMergeView10.Rows[i].Cells[0].Value.ToString();
                    }
                    else
                    {
                        s = rowMergeView10.Rows[i].Cells[1].Value.ToString();
                    }
                    dtwd6.Rows.Add(new object[] { 
                    i+1,
                    s,
                    rowMergeView10.Rows[i].Cells[2].Value,
                    rowMergeView10.Rows[i].Cells[3].Value, //数量
                    rowMergeView10.Rows[i].Cells[4].Value,//单位
                    rowMergeView10.Rows[i].Cells[5].Value,//单价
                    rowMergeView10.Rows[i].Cells[6].Value,//总价
                    ""
                    });
                }

         //   rowMergeView10
            
            }

            if (type == 7)
            {
                dtwd7 = DataTableHelper.CreateTable("BY0,BY1,BY2,BY3,BY4,BY5,BY6,BY7,BY8");
                dtwd7.Rows.Add(new object[] { " 编号", "名称", "单机功率", "数量", "单位", "总功率", "功率因数","能耗" });
                for (var i = 0; i < rowMergeView8.Rows.Count; i++)
                {
                    string s1 = "";
                    if (i >= 7)
                    {
                        if (rowMergeView8.Rows[i].Cells[0].Value == null)
                        {
                            s1 = "";
                        }
                        else { 
                        s1 = rowMergeView8.Rows[i].Cells[0].Value.ToString();
                        }
                    }
                    else
                    {
                        if (rowMergeView8.Rows[i].Cells[1].Value == null) { s1 = ""; } else { s1 = rowMergeView8.Rows[i].Cells[1].Value.ToString(); }
                        
                    }

                    if (s1 != "")
                    {
                    dtwd7.Rows.Add(new object[] { 
                    i, //编号
                    s1,  //名称
           //         rowMergeView8.Rows[i].Cells[2].Value, //型号
                    rowMergeView8.Rows[i].Cells[3].Value, //单机功率
                    rowMergeView8.Rows[i].Cells[4].Value,//数量
                    rowMergeView8.Rows[i].Cells[5].Value,//单位
                    rowMergeView8.Rows[i].Cells[6].Value,//总功率
                    rowMergeView8.Rows[i].Cells[7].Value,//功率因数
                    rowMergeView8.Rows[i].Cells[8].Value//运行能耗
                    });
                    }
                }
              }
            if (type == 8)
            {
                dtwd8 = DataTableHelper.CreateTable("BY0,BY1,BY2,BY3,BY4,BY5");
                dtwd8.Rows.Add(new object[] { " 编号", "指标", "单位", "总体指标", "吨水指标", "备注" });
                for (var i = 0; i < rowMergeView11.Rows.Count; i++)
                {
                    dtwd8.Rows.Add(new object[] { 
                    i, //编号
                    rowMergeView11.Rows[i].Cells[0].Value,   //指标
                    rowMergeView11.Rows[i].Cells[1].Value,   //单位
                    rowMergeView11.Rows[i].Cells[2].Value,  //总体指标
                    rowMergeView11.Rows[i].Cells[3].Value,  //吨水指标
                    ""   //备注
                    });
                }

            }
        }

        private void BaseFrom_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“zIZHENGDataSet.SL”中。您可以根据需要移动或删除它。
            this.sLTableAdapter.Fill(this.zIZHENGDataSet.SL);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if ((((System.Data.DataRowView)(comboBox1.SelectedItem)).Row).ItemArray[1].ToString() == "")
                {
                    MessageBox.Show("税率不能为空");
                    return;
                }
            }
            catch (Exception ex1) 
            {
                MessageBox.Show("税率不能为空");
                return;
            }
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("报价系数不能为空");
                    return;
                }

                if (double.Parse(textBox4.Text) > 10 || double.Parse(textBox4.Text) < 1)
                {
                    MessageBox.Show("报价系数超出范围");
                    return;
                }
            }
            catch (Exception ex2)
            {
                    MessageBox.Show("报价系数错误");
                    return;
            }
            try
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show("膜组件价格不能为空");
                    return;
                }

                if (double.Parse(textBox5.Text) > 50000 || double.Parse(textBox5.Text) < 0)
                {
                    MessageBox.Show("膜组件价格超出范围");
                    return;
                }
            }
            catch (Exception ex3)
            {
                    MessageBox.Show("膜组件价格错误");
                    return;
            }
            #region 表9计算
            
            double dj_10_0 = dj_c_10_0 * double.Parse(textBox4.Text);
            double dj_10_1 = dj_c_10_1 * double.Parse(textBox4.Text);
            double dj_10_2 = dj_c_10_2 * double.Parse(textBox4.Text);
            double dj_10_3 = dj_c_10_3 * double.Parse(textBox4.Text);
            double dj_10_4 = dj_c_10_4 * double.Parse(textBox4.Text);
            double dj_10_5 = dj_c_10_5 * double.Parse(textBox4.Text);
            double dj_10_6 = dj_c_10_6 * double.Parse(textBox4.Text);
            double dj_10_7 = double.Parse(textBox5.Text); //取膜价格
            double dj_10_8 = dj_c_10_8 * double.Parse(textBox4.Text);
            double dj_10_9 = double.Parse(textBox5.Text); //取膜价格
            double dj_10_10 = dj_c_10_10 * double.Parse(textBox4.Text);
            double dj_10_11 = dj_c_10_11 * double.Parse(textBox4.Text);
            double dj_10_12 = dj_c_10_12 * double.Parse(textBox4.Text);

            this.rowMergeView10.Rows.Clear();
            this.rowMergeView11.Rows.Clear();


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[0].Cells[0].Value = "水箱/水池";
            rowMergeView10.Rows[0].Cells[1].Value = "";
            rowMergeView10.Rows[0].Cells[2].Value = xh_c_10_0;
            rowMergeView10.Rows[0].Cells[3].Value = sl_c_10_0.ToString("0.00");
            rowMergeView10.Rows[0].Cells[4].Value = dw_c_10_0;
            rowMergeView10.Rows[0].Cells[5].Value = dj_10_0.ToString("0.00");
            rowMergeView10.Rows[0].Cells[6].Value = (dj_10_0 * sl_c_10_0).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[1].Cells[0].Value = "设备箱";
            rowMergeView10.Rows[1].Cells[1].Value = "";
            rowMergeView10.Rows[1].Cells[2].Value = xh_c_10_1;
            rowMergeView10.Rows[1].Cells[3].Value = sl_c_10_1.ToString("0.00");
            rowMergeView10.Rows[1].Cells[4].Value = dw_c_10_1;
            rowMergeView10.Rows[1].Cells[5].Value = dj_c_10_1.ToString("0.00");
            rowMergeView10.Rows[1].Cells[6].Value = (dj_10_1 * sl_c_10_1).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[2].Cells[0].Value = "预处理单元";
            rowMergeView10.Rows[2].Cells[1].Value = "格栅";
            rowMergeView10.Rows[2].Cells[2].Value = xh_c_10_2;
            rowMergeView10.Rows[2].Cells[3].Value = sl_c_10_2.ToString("0.00");
            rowMergeView10.Rows[2].Cells[4].Value = dw_c_10_2;
            rowMergeView10.Rows[2].Cells[5].Value = dj_c_10_2.ToString("0.00");
            rowMergeView10.Rows[2].Cells[6].Value = (dj_10_2 * sl_c_10_2).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[3].Cells[0].Value = "预处理单元";
            rowMergeView10.Rows[3].Cells[1].Value = "调节池进水泵";
            rowMergeView10.Rows[3].Cells[2].Value = xh_c_10_3;
            rowMergeView10.Rows[3].Cells[3].Value = sl_c_10_3.ToString("0.00");
            rowMergeView10.Rows[3].Cells[4].Value = dw_c_10_3;
            rowMergeView10.Rows[3].Cells[5].Value = dj_c_10_3.ToString("0.00");
            rowMergeView10.Rows[3].Cells[6].Value = (dj_10_3 * sl_c_10_3).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[4].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[4].Cells[1].Value = "鼓风机";
            rowMergeView10.Rows[4].Cells[2].Value = xh_c_10_4;
            rowMergeView10.Rows[4].Cells[3].Value = sl_c_10_4.ToString("0.00");
            rowMergeView10.Rows[4].Cells[4].Value = dw_c_10_4;
            rowMergeView10.Rows[4].Cells[5].Value = dj_10_4.ToString("0.00");
            rowMergeView10.Rows[4].Cells[6].Value = (dj_10_4 * sl_c_10_4).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[5].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[5].Cells[1].Value = "膜出水泵";
            rowMergeView10.Rows[5].Cells[2].Value = xh_c_10_5;
            rowMergeView10.Rows[5].Cells[3].Value = sl_c_10_5.ToString("0.00");
            rowMergeView10.Rows[5].Cells[4].Value = dw_c_10_5;
            rowMergeView10.Rows[5].Cells[5].Value = dj_10_5.ToString("0.00");
            rowMergeView10.Rows[5].Cells[6].Value = (dj_10_5 * sl_c_10_5).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[6].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[6].Cells[1].Value = "回流泵";
            rowMergeView10.Rows[6].Cells[2].Value = xh_c_10_6;
            rowMergeView10.Rows[6].Cells[3].Value = sl_c_10_6.ToString("0.00");
            rowMergeView10.Rows[6].Cells[4].Value = dw_c_10_6;
            rowMergeView10.Rows[6].Cells[5].Value = dj_10_6.ToString("0.00");
            rowMergeView10.Rows[6].Cells[6].Value = (dj_10_6 * sl_c_10_6).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[7].Cells[0].Value = "污水处理单元";
            rowMergeView10.Rows[7].Cells[1].Value = "膜组件";
            rowMergeView10.Rows[7].Cells[2].Value = xh_c_10_7;
            rowMergeView10.Rows[7].Cells[3].Value = sl_c_10_7.ToString("0.00");
            rowMergeView10.Rows[7].Cells[4].Value = dw_c_10_7;
            rowMergeView10.Rows[7].Cells[5].Value = dj_10_7.ToString("0.00");
            rowMergeView10.Rows[7].Cells[6].Value = (dj_10_7 * sl_c_10_7).ToString("0.00");


            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[8].Cells[0].Value = "污泥处理单元";
            rowMergeView10.Rows[8].Cells[1].Value = "MSTD出水泵";
            rowMergeView10.Rows[8].Cells[2].Value = xh_c_10_8;
            rowMergeView10.Rows[8].Cells[3].Value = sl_c_10_8.ToString("0.00");
            rowMergeView10.Rows[8].Cells[4].Value = dw_c_10_8;
            rowMergeView10.Rows[8].Cells[5].Value = dj_10_8.ToString("0.00");
            rowMergeView10.Rows[8].Cells[6].Value = (dj_10_8 * sl_c_10_8).ToString("0.00");

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[9].Cells[0].Value = "污泥处理单元";
            rowMergeView10.Rows[9].Cells[1].Value = "MSTD膜组件";
            rowMergeView10.Rows[9].Cells[2].Value = xh_c_10_9;
            rowMergeView10.Rows[9].Cells[3].Value = sl_c_10_9.ToString("0.00");
            rowMergeView10.Rows[9].Cells[4].Value = dw_c_10_9;
            rowMergeView10.Rows[9].Cells[5].Value = dj_10_9.ToString("0.00");
            rowMergeView10.Rows[9].Cells[6].Value = (dj_10_9 * sl_c_10_9).ToString("0.00");

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[10].Cells[0].Value = "污泥处理单元";
            rowMergeView10.Rows[10].Cells[1].Value = "排泥泵";
            rowMergeView10.Rows[10].Cells[2].Value = xh_c_10_10;
            rowMergeView10.Rows[10].Cells[3].Value = sl_c_10_10.ToString("0.00");
            rowMergeView10.Rows[10].Cells[4].Value = dw_c_10_10;
            rowMergeView10.Rows[10].Cells[5].Value = dj_10_10.ToString("0.00");
            rowMergeView10.Rows[10].Cells[6].Value = (dj_10_10 * sl_c_10_10).ToString("0.00");

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[11].Cells[0].Value = "附件";
            rowMergeView10.Rows[11].Cells[1].Value = "管配件";
            rowMergeView10.Rows[11].Cells[2].Value = xh_c_10_11;
            rowMergeView10.Rows[11].Cells[3].Value = sl_c_10_11.ToString("0.00");
            rowMergeView10.Rows[11].Cells[4].Value = dw_c_10_11;
            rowMergeView10.Rows[11].Cells[5].Value = dj_10_11.ToString("0.00");
            rowMergeView10.Rows[11].Cells[6].Value = (dj_10_11 * sl_c_10_11).ToString("0.00");

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[12].Cells[0].Value = "附件";
            rowMergeView10.Rows[12].Cells[1].Value = "电线电缆";
            rowMergeView10.Rows[12].Cells[2].Value = xh_c_10_12;
            rowMergeView10.Rows[12].Cells[3].Value = sl_c_10_12.ToString("0.00");
            rowMergeView10.Rows[12].Cells[4].Value = dw_c_10_12;
            rowMergeView10.Rows[12].Cells[5].Value = dj_10_12.ToString("0.00");
            rowMergeView10.Rows[12].Cells[6].Value = (dj_10_12 * sl_c_10_12).ToString("0.00");

            double ysxj1_10 = (dj_10_0 * sl_c_10_0)
                                + (dj_10_1 * sl_c_10_1)
                                + (dj_10_2 * sl_c_10_2)
                                + (dj_10_3 * sl_c_10_3)
                                + (dj_10_4 * sl_c_10_4)
                                + (dj_10_5 * sl_c_10_5)
                                + (dj_10_6 * sl_c_10_6)
                                + (dj_10_7 * sl_c_10_7)
                                + (dj_10_8 * sl_c_10_8)
                                + (dj_10_9 * sl_c_10_9)
                                + (dj_10_10 * sl_c_10_10)
                                + (dj_10_11 * sl_c_10_11)
                                + (dj_10_12 * sl_c_10_12);
            

           
            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[13].Cells[0].Value = "以上";
            rowMergeView10.Rows[13].Cells[1].Value = "小计";
            rowMergeView10.Rows[13].Cells[2].Value = "";
            rowMergeView10.Rows[13].Cells[3].Value = "";
            rowMergeView10.Rows[13].Cells[4].Value = "";
            rowMergeView10.Rows[13].Cells[5].Value = "";
            rowMergeView10.Rows[13].Cells[6].Value = ysxj1_10;

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[14].Cells[0].Value = "";
            rowMergeView10.Rows[14].Cells[1].Value = "安装费";
            rowMergeView10.Rows[14].Cells[2].Value = "";
            rowMergeView10.Rows[14].Cells[3].Value = "";
            rowMergeView10.Rows[14].Cells[4].Value = "";
            rowMergeView10.Rows[14].Cells[5].Value = "";
            rowMergeView10.Rows[14].Cells[6].Value = (ysxj1_10 * 0.12).ToString("0.00");

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[15].Cells[0].Value = "";
            rowMergeView10.Rows[15].Cells[1].Value = "调试费";
            rowMergeView10.Rows[15].Cells[2].Value = "";
            rowMergeView10.Rows[15].Cells[3].Value = "";
            rowMergeView10.Rows[15].Cells[4].Value = "";
            rowMergeView10.Rows[15].Cells[5].Value = "";
            rowMergeView10.Rows[15].Cells[6].Value = (ysxj1_10 * 0.12).ToString("0.00"); ;
            double ysxj2_10 = (ysxj1_10 * 0.12) + (ysxj1_10 * 0.12);
            
            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[16].Cells[0].Value = "以上";
            rowMergeView10.Rows[16].Cells[1].Value = "小计";
            rowMergeView10.Rows[16].Cells[2].Value = "";
            rowMergeView10.Rows[16].Cells[3].Value = "";
            rowMergeView10.Rows[16].Cells[4].Value = "";
            rowMergeView10.Rows[16].Cells[5].Value = "";
            rowMergeView10.Rows[16].Cells[6].Value = (ysxj1_10 + ysxj2_10).ToString("0.00"); ;

            double ysxj3_10 = (ysxj2_10 + ysxj2_10) *
            double.Parse((((System.Data.DataRowView)(comboBox1.SelectedItem)).Row).ItemArray[1].ToString());
            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[17].Cells[0].Value = "";
            rowMergeView10.Rows[17].Cells[1].Value = "税额";
            rowMergeView10.Rows[17].Cells[2].Value = "";
            rowMergeView10.Rows[17].Cells[3].Value = "";
            rowMergeView10.Rows[17].Cells[4].Value = "";
            rowMergeView10.Rows[17].Cells[5].Value = "";
            rowMergeView10.Rows[17].Cells[6].Value = ysxj3_10.ToString("0.00");

            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[18].Cells[0].Value = "税额";
            rowMergeView10.Rows[18].Cells[1].Value = "小计";
            rowMergeView10.Rows[18].Cells[2].Value = "";
            rowMergeView10.Rows[18].Cells[3].Value = "";
            rowMergeView10.Rows[18].Cells[4].Value = "";
            rowMergeView10.Rows[18].Cells[5].Value = "";
            rowMergeView10.Rows[18].Cells[6].Value = ysxj3_10.ToString("0.00");

            double bjzj = (ysxj1_10 + ysxj2_10 + ysxj3_10);
            rowMergeView10.Rows.Add();
            rowMergeView10.Rows[19].Cells[0].Value = "";
            rowMergeView10.Rows[19].Cells[1].Value = "总合计";
            rowMergeView10.Rows[19].Cells[2].Value = "";
            rowMergeView10.Rows[19].Cells[3].Value = "";
            rowMergeView10.Rows[19].Cells[4].Value = "";
            rowMergeView10.Rows[19].Cells[5].Value = "";
            rowMergeView10.Rows[19].Cells[6].Value = bjzj.ToString("0.00");
            #endregion

            #region //经济指标计算
            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[0].Cells[0].Value = "设备投资";
            rowMergeView11.Rows[0].Cells[1].Value = "元";
            rowMergeView11.Rows[0].Cells[2].Value = bjzj.ToString("0.00");
            rowMergeView11.Rows[0].Cells[3].Value = (bjzj / double.Parse(B_D1)).ToString("0.00");

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[1].Cells[0].Value = "设备占地";
            rowMergeView11.Rows[1].Cells[1].Value = "㎡";
            rowMergeView11.Rows[1].Cells[2].Value = ZDZZB.ToString("0.00");
            rowMergeView11.Rows[1].Cells[3].Value = (ZDZZB / double.Parse(B_D1)).ToString("0.00");

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[2].Cells[0].Value = "设备能耗";
            rowMergeView11.Rows[2].Cells[1].Value = "kWh";
            rowMergeView11.Rows[2].Cells[2].Value = SBNHZB.ToString("0.00");
            rowMergeView11.Rows[2].Cells[3].Value = (SBNHZB / double.Parse(B_D1)).ToString("0.00");

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[3].Cells[0].Value = "运行电费";
            rowMergeView11.Rows[3].Cells[1].Value = "元/年";
            rowMergeView11.Rows[3].Cells[2].Value = (SBNHZB * 0.6 * 365).ToString("0.00");
            rowMergeView11.Rows[3].Cells[3].Value = "-";
            
            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[4].Cells[0].Value = "运行电费";
            rowMergeView11.Rows[4].Cells[1].Value = "元";
            rowMergeView11.Rows[4].Cells[2].Value = "-";
            rowMergeView11.Rows[4].Cells[3].Value = (SBNHZB / double.Parse(B_D1) * 0.6).ToString("0.00");

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[5].Cells[0].Value = "药剂费";
            rowMergeView11.Rows[5].Cells[1].Value = "元/年";
            rowMergeView11.Rows[5].Cells[2].Value = (double.Parse(B_D25) * 1.8 * 365).ToString("0.00");
            rowMergeView11.Rows[5].Cells[3].Value = "-";

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[6].Cells[0].Value = "药剂费";
            rowMergeView11.Rows[6].Cells[1].Value = "元";
            rowMergeView11.Rows[6].Cells[2].Value = "-";
            rowMergeView11.Rows[6].Cells[3].Value = (double.Parse(B_D25) * 1.8 / double.Parse(B_D1)).ToString("0.00");

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[7].Cells[0].Value = "年减排量";
            rowMergeView11.Rows[7].Cells[1].Value = "kgCOD";
            rowMergeView11.Rows[7].Cells[2].Value = ((double.Parse(B_C4) - double.Parse(B_C7)) * double.Parse(B_D1) * 365 / 1000).ToString("0.00");
            rowMergeView11.Rows[7].Cells[3].Value = "-";

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[8].Cells[0].Value = "年减排量";
            rowMergeView11.Rows[8].Cells[1].Value = "kgBOD5";
            rowMergeView11.Rows[8].Cells[2].Value = ((double.Parse(B_D4) - double.Parse(B_D7)) * double.Parse(B_D1) * 365 / 1000).ToString("0.00");
            rowMergeView11.Rows[8].Cells[3].Value = "-";

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[9].Cells[0].Value = "年减排量";
            rowMergeView11.Rows[9].Cells[1].Value = "kgSS";
            rowMergeView11.Rows[9].Cells[2].Value = ((double.Parse(B_E4) - double.Parse(B_E7)) * double.Parse(B_D1) * 365 / 1000).ToString("0.00");
            rowMergeView11.Rows[9].Cells[3].Value = "-";

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[10].Cells[0].Value = "年减排量";
            rowMergeView11.Rows[10].Cells[1].Value = "kgTN";
            rowMergeView11.Rows[10].Cells[2].Value = ((double.Parse(B_F4) - double.Parse(B_F7)) * double.Parse(B_D1) * 365 / 1000).ToString("0.00");
            rowMergeView11.Rows[10].Cells[3].Value = "-";

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[11].Cells[0].Value = "年减排量";
            rowMergeView11.Rows[11].Cells[1].Value = "kgNH3-N";
            rowMergeView11.Rows[11].Cells[2].Value = ((double.Parse(B_G4) - double.Parse(B_G7)) * double.Parse(B_D1) * 365 / 1000).ToString("0.00");
            rowMergeView11.Rows[11].Cells[3].Value = "-";

            rowMergeView11.Rows.Add();
            rowMergeView11.Rows[12].Cells[0].Value = "年减排量";
            rowMergeView11.Rows[12].Cells[1].Value = "kgTP";
            rowMergeView11.Rows[12].Cells[2].Value = ((double.Parse(B_H4) - double.Parse(B_H7)) * double.Parse(B_D1) * 365 / 1000).ToString("0.00");
            rowMergeView11.Rows[12].Cells[3].Value = "-";
            #endregion
            Dtwd_DT(1, null);
            Dtwd_DT(3, null);
            Dtwd_DT(7, null);
            Dtwd_DT(8, null);

            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //允许输入数字、小数点、删除键和负号  
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != (char)('.'))
            {
                MessageBox.Show("请输入正确的数字");
                this.textBox4.Text = "";
                e.Handled = true;
            }
            if (e.KeyChar == (char)('-'))
            {
                if (textBox4.Text != "")
                {
                    MessageBox.Show("请输入正确的数字");
                    this.textBox4.Text = "";
                    e.Handled = true;
                }
            }
            //小数点只能输入一次  
            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text.IndexOf('.') != -1)
            {
                MessageBox.Show("请输入正确的数字");
                this.textBox4.Text = "";
                e.Handled = true;
            }
            //第一位不能为小数点  
            if (e.KeyChar == (char)('.') && ((TextBox)sender).Text == "")
            {
                MessageBox.Show("请输入正确的数字");
                this.textBox4.Text = "";
                e.Handled = true;
            }
            //第一位是0，第二位必须为小数点  
            if (e.KeyChar != (char)('.') && ((TextBox)sender).Text == "0")
            {
                MessageBox.Show("请输入正确的数字");
                this.textBox4.Text = "";
                e.Handled = true;
            }
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            } 
        }

        private void lab25_Click(object sender, EventArgs e)
        {

        }

        private void lab5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
   


        #region 表10计算
        #endregion

        public void System_sj(DataTable dt)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
            dataGridView5.DataSource = null;

            DataRow[] dr1 = 
                dt.Select("BS='SJ' and (WZ = 'C4' or WZ = 'D4' or WZ = 'E4' or WZ = 'F4' or WZ = 'G4' or WZ = 'H4' or WZ = 'C7' or WZ = 'D7' or WZ = 'E7' or WZ = 'F7' or WZ = 'G7' or WZ = 'H7' or WZ = 'D8')", "WZ");
            DataRow[] dr2 = dt.Select("BS='SJ' and WZ like 'D%' and WZ not like '%4' and WZ not like '%7' and WZ <> 'D8'", "WZ");
            DataRow[] dr3 = dt.Select("BS='SJ' and WZ like 'I%' and WZ not like '%4' and WZ not like '%7' and WZ <> 'D8'", "WZ");
            DataRow[] dr4 = dt.Select("BS='SJ' and WZ like 'K%' and WZ not like '%4' and WZ not like '%7' and WZ <> 'D8'", "WZ");
            DataRow[] dr5 = dt.Select("BS='BQ'", "WZ");

            DataTable copytable1 = dt.Clone();
            DataTable copytable2 = dt.Clone();
            DataTable copytable3 = dt.Clone();
            DataTable copytable4 = dt.Clone();
            DataTable copytable5 = dt.Clone();
            for (int i = 0; i < dr1.Length; i++)
            {
                copytable1.ImportRow(dr1[i]);
            }
            for (int i = 0; i < dr2.Length; i++)
            {
                copytable2.ImportRow(dr2[i]);
            }
            for (int i = 0; i < dr3.Length; i++)
            {
                copytable3.ImportRow(dr3[i]);
            }
            for (int i = 0; i < dr4.Length; i++)
            {
                copytable4.ImportRow(dr4[i]);
            }
            for (int i = 0; i < dr5.Length; i++)
            {
                copytable5.ImportRow(dr5[i]);
            }
            dataGridView1.DataSource = copytable1;
            dataGridView2.DataSource = copytable2;
            dataGridView3.DataSource = copytable3;
            dataGridView4.DataSource = copytable4;
            dataGridView5.DataSource = copytable5;
           // dataGridView1.Columns[0].Visible = false;
           // dataGridView2.Columns[0].Visible = false;
           // dataGridView3.Columns[0].Visible = false;
           // dataGridView4.Columns[0].Visible = false;
           // dataGridView5.Columns[0].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (rowMergeView10.Rows.Count == 0 || rowMergeView11.Rows.Count == 0)
            {
                MessageUtil.ShowWarning("请先成计算报价后再进行方案导出!");
            }
            else
            {
                new ExpWord().ExpWD(dtwd1, dtwd2, dtwd3, dtwd4, dtwd5, dtwd6, dtwd7, dtwd8, dtwd9, dtwd10, dtwd11, dtwd12);
            }
            
        }
    }
        }