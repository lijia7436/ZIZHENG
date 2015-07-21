using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace ZIZHENG
{
    /// <summary>
    /// 设计计算逻辑
    /// </summary>
    class JS
    {
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

        //好氧区
        public double D9 = 0.23;
        public double D10;
        public double D11 = 1.5;
        public double D12;
        public double D13;
        public double D14;
        public double D15;
        public double D16;
        public string D17;
        public double D18;
        public double D19;
        public double I9;
        public double I10;
        public double I13;
        public double I16;
        public double I17;
        public double I18 = 100;//初始100
        public double I19;

        public double K9 = 400;
        public double K10;
        public double K11 = 20;
        public double K12;
        public double K13;
        public double K14;
        public double K15;
        public double I26;
        public double I27;
        public double I28;
        public double D26;
        public double D30;
        public double D32 = 0.4;
        public double D31 = 0.25;
        public double D33;
        public double I33 = 0.08;
        public double D29;
        public double D41 = 100;//初始100
        public double D24;
        public double D20 = 1.5;
        public double I21 = 56;
        public double I22 = 1.91;
        public double I23 = 4.87;
        public double I24 = 1.81;
        public double D21 = 0.03;//03.17
        public double D37 = 0.12;
        public double D38;
        public double D39;
        public double D22;
        public double D23;
        public double D34;

        public double D25 = 0.00;
        public double J21 = 27;
        public double J22 = 2.89;
        public double J23 = 3.94;
        public double J24 = 0.87;

        public double I35 = 0.03;
        public double D35 = 0;
        public double D44 = 0;
        public double D43 = 0;
        public double D36 = 0;
        public double D40 = 0;
        public double D42 = 0;

        public double D45 = 0;
        public double D46 = 0;
        public double D47 = 0;
        public double D48 = 0;
        public double D49 = 0;
        public double H49 = 1;
        public double K49 = 0;
        public double D50 = 0.6;
        private double D45_2 = 0;
        private double D41_2 = 0;
        private double I18_2 = 0;
        private double K9_2 = 0;
        private double K39_2 = 0;
        private double D11_2 = 0;
        private double D9_2 = 0;
        private double I35_2 = 0;
        private double I33_2 = 0;
        private double D29_2 = 0;
       // private double D27_2 = 0;
       // private double D58_2 = 0;
        private double D33_2 = 0;
        private double D50_2 = 0;
        private double D39_2 = 0;
        private double I10_2 = 0;
        public int D17_FLAG =0;
        public int D18_FLAG = 0;


        public DataTable SS_DT(string p1, string p2, string p3,
            double D1, double F1, double D8,
            double C4, double D4, double E4, double F4, double G4, double H4,
            double C7, double D7, double E7, double F7, double G7, double H7,
            double D45,
            double I9, double H49, double K11, double K12)
        {
            this.D1 = D1;
            this.F1 = F1;
            this.D8 = D8;
            this.C4 = C4;
            this.D4 = D4;
            this.E4 = E4;
            this.F4 = F4;
            this.G4 = G4;
            this.H4 = H4;
            this.C7 = C7;
            this.D7 = D7;
            this.E7 = E7;
            this.F7 = F7;
            this.G7 = G7;
            this.H7 = H7;
            this.K12 = K12;
            ArrayList mjsList = new ArrayList();     
            DataTable jsdt = new DataTable();
            jsdt = SS();       //初始化第一次运算   

            //膜计算
            mjsList = new MJS().MLJS(K10, K12, D1, K9);
            this.I10 = double.Parse(mjsList[2].ToString());
            this.I13 = double.Parse(mjsList[1].ToString());
            this.K11 = double.Parse(mjsList[0].ToString());
            

            for (int j =0 ;j < 50;j++)
            {
                if (Math.Abs(I17 - I18) / I17 > 0.01)
                {
                    I18 = I17;
                    jsdt = SSVo(I18,0);  //第一次试算Vo
                }
                else
                {
                    break;
                }
            }for (int j = 0; j < 50; j++)
            {
                if (Math.Abs(D40 - D41)/D40 > 0.01)
                {
                    this.D41 = this.D40;
                    jsdt = SSVn(D41); //第一次试算Vn
                    }
                else
                {
                    break;
                }
            }return jsdt;
        }
 
        /// <summary>
        /// 初始化计算
        /// </summary>
        public DataTable SS()
        {
            //好氧区
            I26 = Math.Round(0.47 * System.Math.Exp(0.098 * (D8 - 15)) * G7 / (G7 + 1),5);
            I27 = Math.Round(1 / I26,5);
            I28 = Math.Round(3 * I27,5);
            if (I28 > 25)
            {
                D26 = System.Math.Ceiling(I28);
            }
            else
            {
                D26 = 25;
            }
            D30 = Math.Round(I18 / D26,5);
            D29 = Math.Round(D26 / I18 * (I18 + D41),5);
            D10 = Math.Round(D1 * (G4 - G7) / 1000 / D9,5);
            D33 = Math.Round(I33 * System.Math.Pow(1.04, D8 - 20),5);
            D12 = Math.Round(D32 / (1 + D33 * D29),5);
            if (2.86 * (G4 - F7) / (1 - 1.42 * D12) > 0) { D13 = Math.Round(2.86 * (G4 - F7) / (1 - 1.42 * D12),5); }
            else { D13 = 0; }
            if (C4 <= 500)
            {
                D11 = 1.5;
            }
            else if (C4 > 500 && C4 <= 1000)
            {
                D11 = 2;
            }
            else
            {
                D11 = 3;
            }

            D14 = Math.Round(D1 * (C4 - D13 - C7) / 1000 / D11,5);
            D15 = Math.Round((C4) / 2 * D1 / 1000 / (I18),5);
            if (D1 * (C4 - C7 - D13) / I18 / 1000 > 0)
            {
            D17 = Math.Round((D1 * (C4 - C7 - D13) / I18 / 1000),5).ToString();}
            else
            {
            D17 = "需投加碳源";
            }
            D18 = Math.Round(D1 * (G4 - G7) / I18 / 1000,5);
          //  D9 = D18; // 试算
            D38 = Math.Round(D32 * D1 * (C4 - C7) / (1 + D33 * D29) / 1000,5);
            D39 = Math.Round(D37 * D38,5);
            D22 = Math.Round(D21 * D39 / D1 * 1000 / D37,5);
            D23 = Math.Round(D20 * I21 * (H4 - H7 - D22) / 31,5);
            if (D23 <= 0) { D23 = 0; }
            if (D23 == 0)
            {
                D24 = 0;
            }
            else
            {
            D24 = Math.Round(D1 * (I22 * D23 + (I23 - I22 * I24) * (H4 - H7)) / 1000,5);
            }
            D34 = Math.Round(D1 * D31 * (E4 - E7) / 1000 + D1 * D32 * (C4 - C7) / (1 + D33 * D29) / 1000 + D24,5);
            D19 = Math.Round(D34 / D30,5);
            D16 = Math.Round(D15 / D19,5);
            K10 = Math.Round(D1 / K9 * 1000 / 0.9,5);
           // I13 = Math.Round(System.Math.Ceiling(K10 / K12 / K11),5);
            K13 = Math.Round(I13 * K12,5);
           // K14 = Math.Round(0.018 * K11 * I13 + 1,5);
            K14 = Math.Round((0.018 * K11 + 0.6) * I13, 5);
           // I10 = Math.Round(K11 * I13 * K12,5);
            I9 = Math.Round(D1 / I10 / 0.9 * 1000,5);
            I19 = Math.Round(I18 / D1 * 24,5);
            if (K12 == 1)
            {
            K15 = 2.2;
            }
            else if (K12 == 2)
            {
            K15 = 3.5;
            }
            else
            {
            K15 = 4.5;
            }
            I16 = Math.Round(K14 * K15,5);
            I17 = System.Math.Max(System.Math.Max(D10, D14), I16);//MAX(D10,D14,I16);
            //D25 = 0.00;
            if (D23 * D1 / 1000 / 0.18 < 0)
            D25 = 0;
            else
            D25 = Math.Round(D23 * D1 / 1000 / 0.18,5);
            D35 = Math.Round(I35 * System.Math.Pow(1.08, D8 - 20),5);
            D44 = Math.Round(1000 * D41 * D35 * D19 / (F7 - G7) / 24,5);
            D43 = Math.Round(D44 / D1 * 24,5);
            D36 = Math.Round(D19 * (D43) / (D43 + 1),5);
            //D40 = 0;
            if ((0.001*D1*(G4 - F7) - D39)/D35/D19 > 0)
            {
            D40 = Math.Round((0.001*D1*(G4 - F7) - D39)/D35/D19,5);
            }
            else
            {
            D40 = 0;
            }
            D42 = Math.Round(D41 * 24 / D1,5);
            if (D1 > 1000)
            {
            D45 = 0;
            }
            else
            {
            D45 = 10;
            }
            D46 = Math.Round(D1 * D45 / 24,5);
            D50 = 0.6;
            D47 = Math.Round(D46 * D50,5);
            D48 = D46 + I18 + D41;
            K49 = Math.Round(D49 / H49,5);

            DataTable dt = new DataTable("TB_SJ");
            dt.Columns.Add("BS", System.Type.GetType("System.String"));
            dt.Columns.Add("WZ", System.Type.GetType("System.String"));
            dt.Columns.Add("SZ", System.Type.GetType("System.String"));
            dt.Rows.Add("SJ", "D1", D1);
            dt.Rows.Add("SJ", "F1", F1);
            dt.Rows.Add("SJ", "D8", D8);
            dt.Rows.Add("SJ", "C4", C4);
            dt.Rows.Add("SJ", "D4", D4);
            dt.Rows.Add("SJ", "E4", E4);
            dt.Rows.Add("SJ", "F4", F4);
            dt.Rows.Add("SJ", "G4", G4);
            dt.Rows.Add("SJ", "H4", H4);
            dt.Rows.Add("SJ", "C7", C7);
            dt.Rows.Add("SJ", "D7", D7);
            dt.Rows.Add("SJ", "E7", E7);
            dt.Rows.Add("SJ", "F7", F7);
            dt.Rows.Add("SJ", "G7", G7);
            dt.Rows.Add("SJ", "H7", H7);
            dt.Rows.Add("SJ", "D9", D9);
            dt.Rows.Add("SJ", "D11", D11);
  
            dt.Rows.Add("SJ", "I18", I18);
            dt.Rows.Add("SJ", "I26", I26);
            dt.Rows.Add("SJ", "I27", I27);
            dt.Rows.Add("SJ", "I28", I28);
            dt.Rows.Add("SJ", "D26", D26);
            dt.Rows.Add("SJ", "D30", D30);
            dt.Rows.Add("SJ", "D32", D32);
            dt.Rows.Add("SJ", "D31", D31);
            dt.Rows.Add("SJ", "D41", D41);
            dt.Rows.Add("SJ", "D29", D29);
            dt.Rows.Add("SJ", "D10", D10);
            dt.Rows.Add("SJ", "I33", I33);
            dt.Rows.Add("SJ", "D33", D33);
            dt.Rows.Add("SJ", "D12", D12);
            dt.Rows.Add("SJ", "D14", D14);
            dt.Rows.Add("SJ", "D15", D15);
            dt.Rows.Add("SJ", "D17", D17);
            dt.Rows.Add("SJ", "D18", D18);
            dt.Rows.Add("SJ", "D20", D20);
            dt.Rows.Add("SJ", "I21", I21);
            dt.Rows.Add("SJ", "I22", I22);
            dt.Rows.Add("SJ", "I23", I23);
            dt.Rows.Add("SJ", "I24", I24);
            dt.Rows.Add("SJ", "D21", D21);
            dt.Rows.Add("SJ", "D37", D37);
            dt.Rows.Add("SJ", "D38", D38);
            dt.Rows.Add("SJ", "D39", D39);
            dt.Rows.Add("SJ", "D22", D22);
            dt.Rows.Add("SJ", "D23", D23);
            dt.Rows.Add("SJ", "D24", D24);
            dt.Rows.Add("SJ", "D34", D34);
            dt.Rows.Add("SJ", "D19", D19);
            dt.Rows.Add("SJ", "D16", D16);
            dt.Rows.Add("SJ", "K9 ", K9);
            dt.Rows.Add("SJ", "K10", K10);
            dt.Rows.Add("SJ", "K11", K11);
            dt.Rows.Add("SJ", "K12", K12);
            dt.Rows.Add("SJ", "I13", I13);
            dt.Rows.Add("SJ", "K13", K13);
            dt.Rows.Add("SJ", "K14", K14);
            dt.Rows.Add("SJ", "I10", I10);
            dt.Rows.Add("SJ", "I9 ", I9);
            dt.Rows.Add("SJ", "I19", I19);
            dt.Rows.Add("SJ", "K15", K15);
            dt.Rows.Add("SJ", "I16", I16);
            dt.Rows.Add("SJ", "I17", I17);
            dt.Rows.Add("SJ", "D25", D25);
            dt.Rows.Add("SJ", "J21", J21);
            dt.Rows.Add("SJ", "J22", J22);
            dt.Rows.Add("SJ", "J23", J23);
            dt.Rows.Add("SJ", "J24", J24);
            dt.Rows.Add("SJ", "I35", I35);
            dt.Rows.Add("SJ", "D35", D35);
            dt.Rows.Add("SJ", "D44", D44);
            dt.Rows.Add("SJ", "D43", D43);
            dt.Rows.Add("SJ", "D36", D36);
            dt.Rows.Add("SJ", "D40", D40);
            dt.Rows.Add("SJ", "D42", D42);
            dt.Rows.Add("SJ", "D45", D45);
            dt.Rows.Add("SJ", "D46", D46);
            dt.Rows.Add("SJ", "D47", D47);
            dt.Rows.Add("SJ", "D48", D48);
           // dt.Rows.Add("SJ", "D49", D49);
            dt.Rows.Add("SJ", "H49", H49);
            //dt.Rows.Add("SJ", "D50", D50);
            DataTable dt_bq = new BQJS().BQJS_2(D1, D4, E7, D38, G4, F4, F7, G7, K12, D8, D47,D19,D50,I13,K11);
            D49 = Convert.ToDouble(dt_bq.Select("BS='BQ' AND WZ='D67'")[0][2]);
            dt.Rows.Add("SJ", "D49", D49);
            D50 = D49;
            dt.Rows.Add("SJ", "D50", D50);
            object[] obj = new object[dt.Columns.Count];
            for (int i = 0; i < dt_bq.Rows.Count; i++)
            {
                dt_bq.Rows[i].ItemArray.CopyTo(obj, 0);
                dt.Rows.Add(obj);
            }
            D49 = Convert.ToDouble(dt_bq.Select("BS='BQ' AND WZ='D67'")[0][2]);
            return dt;
        }

        /// <summary> 试算
        /// </summary>
        public DataTable SSVo(double I18Vo,double mtl)
        {
          
            //好氧区
            //D9 = 0.23;
            I18 = I18Vo;//9.36;//预估
            I26 = Math.Round(0.47 * System.Math.Exp(0.098 * (D8 - 15)) * G7 / (G7 + 1),5);
            I27 = Math.Round(1 / I26,5);
            I28 = Math.Round(3 * I27,5);
            if(I28 > 25)
            {
                D26 = System.Math.Ceiling(I28);
            }
            else
            {
                D26 = 25;
            }
            
            D30 = Math.Round(I18 / D26,5);
            //D32 = 0.4;
            //D31 = 0.25;
            //D41 = 36.31;
            D29 = Math.Round(D26 / I18 * (I18 + D41),5);
            D10 = Math.Round(D1 * (G4 - G7) / 1000 / D9,5);
            //D11 = 1.5;
            //I33 = 0.08;
            D33 = Math.Round(I33 * System.Math.Pow(1.04, D8 - 20),5);
            D12 = Math.Round(D32 / (1 + D33 * D29),5);
            if (2.86 * (G4 - F7) / (1 - 1.42 * D12) > 0) { D13 = Math.Round(2.86 * (G4 - F7) / (1 - 1.42 * D12),5); }
            else { D13 = 0; }
            if (C4 <= 500)
            {
                D11 = 1.5;
            }
            else if (C4 > 500 && C4 <= 1000)
            {
                D11 = 2;
            }
            else
            {
                D11 = 3;
            }
            D14 = Math.Round(D1 * (C4 - D13 - C7) / 1000 / D11,5);
            D15 = Math.Round((C4) / 2 * D1 / 1000 / (I18),5);
            if (D1 * (C4 - C7 - D13) / I18 / 1000 > 0)
            {
                D17 = Math.Round((D1 * (C4 - C7 - D13) / I18 / 1000),5).ToString();
            }
            else
            {
                D17 = "需投加碳源";
            }
            D18 = Math.Round(D1 * (G4 - G7) / I18 / 1000,5);
            //D20 = 1.5;
            //I21 = 56;
            //I22 = 1.91;
            //I23 = 4.87;
            //I24 = 1.81;
            //D21 = 0.02;
            //D37 = 0.12;
            D38 = Math.Round(D32 * D1 * (C4 - C7) / (1 + D33 * D29) / 1000,5);
            D39 = Math.Round(D37 * D38,5);
            D22 = Math.Round(D21 * D39 / D1 * 1000 / D37,5);
            D23 = Math.Round(D20 * I21 * (H4 - H7 - D22) / 31,5);
            if (D23 <= 0) { D23 = 0; }
            if (D23 == 0)
            {
                D24 = 0;
            }
            else
            {
                D24 = Math.Round(D1 * (I22 * D23 + (I23 - I22 * I24) * (H4 - H7)) / 1000,5);
            }
            D34 = Math.Round(D1 * D31 * (E4 - E7) / 1000 + D1 * D32 * (C4 - C7) / (1 + D33 * D29) / 1000 + D24,5);
            D19 = Math.Round(D34 / D30,5);
            D16 = Math.Round(D15 / D19,5);
            //K9 = 400;
            K10 = Math.Round(D1 / K9 * 1000 / 0.9,5);
            //K11 = 20;
            //K12 = 3;
           // I13 = Math.Round(System.Math.Ceiling(K10 / K12 / K11),5);
            K13 = Math.Round(I13 * K12,5);
           // K14 = Math.Round(0.018 * K11 * I13 + 1,5);
            K14 = Math.Round((0.018 * K11 + 0.6) * I13, 5);
           // I10 = Math.Round(K11 * I13 * K12,5);
            if (mtl != 0)
            {
                K9 = mtl;
                I9 = mtl;
            }else
            {
                I9 = Math.Round(D1 / I10 / 0.9 * 1000, 5);
            }

            
            I19 = Math.Round(I18 / D1 * 24,5);
            if (K12 == 1)
            {
                K15 = 2.2;
            }
            else if (K12 == 2)
            {
                K15 = 3.5;
            }
            else
            {
                K15 = 4.5;
            }
            I16 = Math.Round(K14 * K15,5);
            I17 = System.Math.Max(System.Math.Max(D10, D14), I16);//MAX(D10,D14,I16);
           // D25 = 0.00;
            if (D23 * D1 / 1000 / 0.18 < 0)
                D25 = 0;
            else
                D25 = Math.Round(D23 * D1 / 1000 / 0.18,5);
           // J21 = 27;
           // J22 = 2.89;
           // J23 = 3.94;
           // J24 = 0.87;
           // I35 = 0.03;
            D35 = Math.Round(I35 * System.Math.Pow(1.08, D8 - 20),5);
            D44 = Math.Round(1000 * D41 * D35 * D19 / (F7 - G7) / 24,5);
            D43 = Math.Round(D44 / D1 * 24,5);
            D36 = Math.Round(D19 * (D43) / (D43 + 1),5);
            //D40 = 0;
            if ((0.001 * D1 * (G4 - F7) - D39) / D35 / D19 > 0)
            {
                D40 = Math.Round((0.001 * D1 * (G4 - F7) - D39) / D35 / D19,5);
            }
            else
            {
                D40 = 0;
            }
            D42 = Math.Round(D41 * 24 / D1,5);
           // D45 = 0;
            if (D1 > 1000)
            {
                D45 = 0;
            }
            else
            {
                D45 = 10;
            }
            D46 = Math.Round(D1 * D45 / 24,5);
            D50 = 0.6;
            D47 = Math.Round(D46 * D50,5);
            D48 = D46 + I18 + D41;
            //D49 = 0;//曝气量计算!D67
            //H49 = 1; 
            //D49 = D47 + I19 + D42;
            K49 = Math.Round(D49 / H49,5);

            DataTable dt = new DataTable("TB_SJ");
            dt.Columns.Add("BS", System.Type.GetType("System.String"));
            dt.Columns.Add("WZ", System.Type.GetType("System.String"));
            dt.Columns.Add("SZ", System.Type.GetType("System.String"));

            dt.Rows.Add("SJ", "D1", D1);
            dt.Rows.Add("SJ", "F1", F1);
            dt.Rows.Add("SJ", "D8", D8);
            dt.Rows.Add("SJ", "C4", C4);
            dt.Rows.Add("SJ", "D4", D4);
            dt.Rows.Add("SJ", "E4", E4);
            dt.Rows.Add("SJ", "F4", F4);
            dt.Rows.Add("SJ", "G4", G4);
            dt.Rows.Add("SJ", "H4", H4);
            dt.Rows.Add("SJ", "C7", C7);
            dt.Rows.Add("SJ", "D7", D7);
            dt.Rows.Add("SJ", "E7", E7);
            dt.Rows.Add("SJ", "F7", F7);
            dt.Rows.Add("SJ", "G7", G7);
            dt.Rows.Add("SJ", "H7", H7);
            dt.Rows.Add("SJ", "D9", D9);
            dt.Rows.Add("SJ", "D11", D11);
            
    
            dt.Rows.Add("SJ", "I18", I18);
            dt.Rows.Add("SJ", "I26", I26);
            dt.Rows.Add("SJ", "I27", I27);
            dt.Rows.Add("SJ", "I28", I28);
            dt.Rows.Add("SJ", "D26", D26);
            dt.Rows.Add("SJ", "D30", D30);
            dt.Rows.Add("SJ", "D32", D32);
            dt.Rows.Add("SJ", "D31", D31);
            dt.Rows.Add("SJ", "D41", D41);
            dt.Rows.Add("SJ", "D29", D29);
            dt.Rows.Add("SJ", "D10", D10);
            
            dt.Rows.Add("SJ", "I33", I33);
            dt.Rows.Add("SJ", "D33", D33);
            dt.Rows.Add("SJ", "D12", D12);
            dt.Rows.Add("SJ", "D14", D14);
            dt.Rows.Add("SJ", "D15", D15);
            dt.Rows.Add("SJ", "D17", D17);
            dt.Rows.Add("SJ", "D18", D18);
            dt.Rows.Add("SJ", "D20", D20);
            dt.Rows.Add("SJ", "I21", I21);
            dt.Rows.Add("SJ", "I22", I22);
            dt.Rows.Add("SJ", "I23", I23);
            dt.Rows.Add("SJ", "I24", I24);
            dt.Rows.Add("SJ", "D21", D21);
            dt.Rows.Add("SJ", "D37", D37);
            dt.Rows.Add("SJ", "D38", D38);
            dt.Rows.Add("SJ", "D39", D39);
            dt.Rows.Add("SJ", "D22", D22);
            dt.Rows.Add("SJ", "D23", D23);
            dt.Rows.Add("SJ", "D24", D24);
            dt.Rows.Add("SJ", "D34", D34);
            dt.Rows.Add("SJ", "D19", D19);
            dt.Rows.Add("SJ", "D16", D16);
            dt.Rows.Add("SJ", "K9 ", K9);
            dt.Rows.Add("SJ", "K10", K10);
            dt.Rows.Add("SJ", "K11", K11);
            dt.Rows.Add("SJ", "K12", K12);
            dt.Rows.Add("SJ", "I13", I13);
            dt.Rows.Add("SJ", "K13", K13);
            dt.Rows.Add("SJ", "K14", K14);
            dt.Rows.Add("SJ", "I10", I10);
            dt.Rows.Add("SJ", "I9 ", I9);
            dt.Rows.Add("SJ", "I19", I19);
            dt.Rows.Add("SJ", "K15", K15);
            dt.Rows.Add("SJ", "I16", I16);
            dt.Rows.Add("SJ", "I17", I17);
            dt.Rows.Add("SJ", "D25", D25);
            dt.Rows.Add("SJ", "J21", J21);
            dt.Rows.Add("SJ", "J22", J22);
            dt.Rows.Add("SJ", "J23", J23);
            dt.Rows.Add("SJ", "J24", J24);
            dt.Rows.Add("SJ", "I35", I35);
            dt.Rows.Add("SJ", "D35", D35);
            dt.Rows.Add("SJ", "D44", D44);
            dt.Rows.Add("SJ", "D43", D43);
            dt.Rows.Add("SJ", "D36", D36);
            dt.Rows.Add("SJ", "D40", D40);
            dt.Rows.Add("SJ", "D42", D42);
            dt.Rows.Add("SJ", "D45", D45);
            dt.Rows.Add("SJ", "D46", D46);
            dt.Rows.Add("SJ", "D47", D47);
            dt.Rows.Add("SJ", "D48", D48);    
            dt.Rows.Add("SJ", "H49", H49);
           // dt.Rows.Add("SJ", "D50", D50);
            DataTable dt_bq = new BQJS().BQJS_2(D1, D4, E7, D38, G4, F4, F7, G7, K12, D8, D47,D19,D50,I13,K11);
            D49 = Convert.ToDouble(dt_bq.Select("BS='BQ' AND WZ='D67'")[0][2]);
            dt.Rows.Add("SJ", "D49", D49);
            D50 = D49;
            dt.Rows.Add("SJ", "D50", D50);
            object[] obj = new object[dt.Columns.Count];
            for (int i = 0; i < dt_bq.Rows.Count; i++)
            {
                dt_bq.Rows[i].ItemArray.CopyTo(obj, 0);
                dt.Rows.Add(obj);
            }
            return dt;
        }

        public DataTable SSVn(double D41Vn)
        {
            //好氧区
            //D9 = 0.23;
            //I18 = I18Vo;//9.36;//预估
            I26 = Math.Round(0.47 * System.Math.Exp(0.098 * (D8 - 15)) * G7 / (G7 + 1),5);
            I27 = Math.Round(1 / I26,5);
            I28 = Math.Round(3 * I27,5);
            if (I28 > 25)
            {
                D26 = System.Math.Ceiling(I28);
            }
            else
            {
                D26 = 25;
            }
            D30 = Math.Round(I18 / D26,5);
            //D32 = 0.4;
            //D31 = 0.25;
            D41 = D41Vn;
            D29 = Math.Round(D26 / I18 * (I18 + D41),5);
            D10 = Math.Round(D1 * (G4 - G7) / 1000 / D9,5);
            //D11 = 1.5;
            //I33 = 0.08;
            D33 = Math.Round(I33 * System.Math.Pow(1.04, D8 - 20),5);
            D12 = Math.Round(D32 / (1 + D33 * D29),5);
            if (2.86 * (G4 - F7) / (1 - 1.42 * D12) > 0) { D13 = Math.Round(2.86 * (G4 - F7) / (1 - 1.42 * D12),5); }
            else { D13 = 0; }
            if (C4 <= 500)
            {
                D11 = 1.5;
            }
            else if (C4 > 500 && C4 <= 1000)
            {
                D11 = 2;
            }
            else
            {
                D11 = 3;
            }
            D14 = Math.Round(D1 * (C4 - D13 - C7) / 1000 / D11,5);
            D15 = Math.Round((C4) / 2 * D1 / 1000 / (I18),5);
            if (D1 * (C4 - C7 - D13) / I18 / 1000 > 0){
                D17 = Math.Round((D1 * (C4 - C7 - D13) / I18 / 1000),5).ToString();
            }
            else
            {
                D17 = "需投加碳源";
            }
            D18 = Math.Round(D1 * (G4 - G7) / I18 / 1000,5);
            //D20 = 1.5;
            //I21 = 56;
            //I22 = 1.91;
            //I23 = 4.87;
            //I24 = 1.81;
            //D21 = 0.02;
            //D37 = 0.12;
            D38 = Math.Round(D32 * D1 * (C4 - C7) / (1 + D33 * D29) / 1000,5);
            D39 = Math.Round(D37 * D38,5);
            D22 = Math.Round(D21 * D39 / D1 * 1000 / D37,5);
            D23 = Math.Round(D20 * I21 * (H4 - H7 - D22) / 31,5); 
            if (D23 <= 0) { D23 = 0; }

            if (D23 == 0)
            {
                D24 = 0;
            }
            else
            {
                D24 = Math.Round(D1 * (I22 * D23 + (I23 - I22 * I24) * (H4 - H7)) / 1000,5);
            }
            D34 = Math.Round(D1 * D31 * (E4 - E7) / 1000 + D1 * D32 * (C4 - C7) / (1 + D33 * D29) / 1000 + D24,5);
            D19 = Math.Round(D34 / D30,5);
            D16 = Math.Round(D15 / D19,5);
            //K9 = 400;
            K10 = Math.Round(D1 / K9 * 1000 / 0.9,5);
            //K11 = 20;
            //K12 = 3;
           // I13 = Math.Round(System.Math.Ceiling(K10 / K12 / K11),5);
            K13 = Math.Round(I13 * K12,5);
            //K14 = Math.Round(0.018 * K11 * I13 + 1,5);
            K14 = Math.Round((0.018 * K11 + 0.6) * I13, 5);
           // I10 = Math.Round(K11 * I13 * K12,5);
            I9 = Math.Round(D1 / I10 / 0.9 * 1000,5);
            I19 = Math.Round(I18 / D1 * 24,5);
            if (K12 == 1)
            {
                K15 = 2.2;
            }
            else if (K12 == 2)
            {
                K15 = 3.5;
            }
            else
            {
                K15 = 4.5;
            }
            I16 = Math.Round(K14 * K15,5);
            I17 = System.Math.Max(System.Math.Max(D10, D14), I16);//MAX(D10,D14,I16);
            // D25 = 0.00;
            if (D23 * D1 / 1000 / 0.18 < 0)
                D25 = 0;
            else
                D25 = Math.Round(D23 * D1 / 1000 / 0.18,5);
            // J21 = 27;
            // J22 = 2.89;
            // J23 = 3.94;
            // J24 = 0.87;
            // I35 = 0.03;
            D35 = Math.Round(I35 * System.Math.Pow(1.08, D8 - 20),5);
            D44 = Math.Round(1000 * D41 * D35 * D19 / (F7 - G7) / 24,5);
            D43 = Math.Round(D44 / D1 * 24,5);
            D36 = Math.Round(D19 * (D43) / (D43 + 1),5);
            //D40 = 0;
            if ((0.001 * D1 * (G4 - F7) - D39) / D35 / D19 > 0)
            {
                D40 = Math.Round((0.001 * D1 * (G4 - F7) - D39) / D35 / D19,5);
            }
            else
            {
                D40 = 0;
            }
            D42 = Math.Round(D41 * 24 / D1,5);
            // D45 = 0;
            if (D1 > 1000)
            {
                D45 = 0;
            }
            else
            {
                D45 = 10;
            }
            D46 = Math.Round(D1 * D45 / 24,5);
            D50 = 0.6;
            D47 = Math.Round(D46 * 0.6,5);
            D48 = D46 + I18 + D41;
            //D49 = 0;//曝气量计算!D67
            //H49 = 1; 
            //D49 = D47 + I19 + D42;
            K49 = Math.Round(D49 / H49,5);

            DataTable dt = new DataTable("TB_SJ");
            dt.Columns.Add("BS", System.Type.GetType("System.String"));
            dt.Columns.Add("WZ", System.Type.GetType("System.String"));
            dt.Columns.Add("SZ", System.Type.GetType("System.String"));

            dt.Rows.Add("SJ", "D1", D1);
            dt.Rows.Add("SJ", "F1", F1);
            dt.Rows.Add("SJ", "D8", D8);
            dt.Rows.Add("SJ", "C4", C4);
            dt.Rows.Add("SJ", "D4", D4);
            dt.Rows.Add("SJ", "E4", E4);
            dt.Rows.Add("SJ", "F4", F4);
            dt.Rows.Add("SJ", "G4", G4);
            dt.Rows.Add("SJ", "H4", H4);
            dt.Rows.Add("SJ", "C7", C7);
            dt.Rows.Add("SJ", "D7", D7);
            dt.Rows.Add("SJ", "E7", E7);
            dt.Rows.Add("SJ", "F7", F7);
            dt.Rows.Add("SJ", "G7", G7);
            dt.Rows.Add("SJ", "H7", H7);
            dt.Rows.Add("SJ", "D9", D9);
            dt.Rows.Add("SJ", "D11", D11);
              
            dt.Rows.Add("SJ", "I18", I18);
            dt.Rows.Add("SJ", "I26", I26);
            dt.Rows.Add("SJ", "I27", I27);
            dt.Rows.Add("SJ", "I28", I28);
            dt.Rows.Add("SJ", "D26", D26);
            dt.Rows.Add("SJ", "D30", D30);
            dt.Rows.Add("SJ", "D32", D32);
            dt.Rows.Add("SJ", "D31", D31);
            dt.Rows.Add("SJ", "D41", D41);
            dt.Rows.Add("SJ", "D29", D29);
            dt.Rows.Add("SJ", "D10", D10);
            
            dt.Rows.Add("SJ", "I33", I33);
            dt.Rows.Add("SJ", "D33", D33);
            dt.Rows.Add("SJ", "D12", D12);
            dt.Rows.Add("SJ", "D14", D14);
            dt.Rows.Add("SJ", "D15", D15);
            dt.Rows.Add("SJ", "D17", D17);
            dt.Rows.Add("SJ", "D18", D18);
            dt.Rows.Add("SJ", "D20", D20);
            dt.Rows.Add("SJ", "I21", I21);
            dt.Rows.Add("SJ", "I22", I22);
            dt.Rows.Add("SJ", "I23", I23);
            dt.Rows.Add("SJ", "I24", I24);
            dt.Rows.Add("SJ", "D21", D21);
            dt.Rows.Add("SJ", "D37", D37);
            dt.Rows.Add("SJ", "D38", D38);
            dt.Rows.Add("SJ", "D39", D39);
            dt.Rows.Add("SJ", "D22", D22);
            dt.Rows.Add("SJ", "D23", D23);
            dt.Rows.Add("SJ", "D24", D24);
            dt.Rows.Add("SJ", "D34", D34);
            dt.Rows.Add("SJ", "D19", D19);
            dt.Rows.Add("SJ", "D16", D16);
            dt.Rows.Add("SJ", "K9 ", K9);
            dt.Rows.Add("SJ", "K10", K10);
            dt.Rows.Add("SJ", "K11", K11);
            dt.Rows.Add("SJ", "K12", K12);
            dt.Rows.Add("SJ", "I13", I13);
            dt.Rows.Add("SJ", "K13", K13);
            dt.Rows.Add("SJ", "K14", K14);
            dt.Rows.Add("SJ", "I10", I10);
            dt.Rows.Add("SJ", "I9 ", I9);
            dt.Rows.Add("SJ", "I19", I19);
            dt.Rows.Add("SJ", "K15", K15);
            dt.Rows.Add("SJ", "I16", I16);
            dt.Rows.Add("SJ", "I17", I17);
            dt.Rows.Add("SJ", "D25", D25);
            dt.Rows.Add("SJ", "J21", J21);
            dt.Rows.Add("SJ", "J22", J22);
            dt.Rows.Add("SJ", "J23", J23);
            dt.Rows.Add("SJ", "J24", J24);
            dt.Rows.Add("SJ", "I35", I35);
            dt.Rows.Add("SJ", "D35", D35);
            dt.Rows.Add("SJ", "D44", D44);
            dt.Rows.Add("SJ", "D43", D43);
            dt.Rows.Add("SJ", "D36", D36);
            dt.Rows.Add("SJ", "D40", D40);
            dt.Rows.Add("SJ", "D42", D42);
            dt.Rows.Add("SJ", "D45", D45);
            dt.Rows.Add("SJ", "D46", D46);
            dt.Rows.Add("SJ", "D47", D47);
            dt.Rows.Add("SJ", "D48", D48);
            //dt.Rows.Add("SJ", "D49", D49);
            dt.Rows.Add("SJ", "H49", H49);
            //dt.Rows.Add("SJ", "D50", D50);
            DataTable dt_bq = new BQJS().BQJS_2(D1, D4, E7, D38, G4, F4, F7, G7, K12, D8, D47,D19,D50,I13,K11);
            D49 = Convert.ToDouble(dt_bq.Select("BS='BQ' AND WZ='D67'")[0][2]);
            dt.Rows.Add("SJ", "D49", D49);
            D50 = D49;
            dt.Rows.Add("SJ", "D50", D50);
            object[] obj = new object[dt.Columns.Count];
            for (int i = 0; i < dt_bq.Rows.Count; i++)
            {
                dt_bq.Rows[i].ItemArray.CopyTo(obj, 0);
                dt.Rows.Add(obj);
            }
            return dt;
        }

        public DataTable SS_DT_2(string j_p1, string j_p2, string j_p3,
            double j_D1, double j_F1, double j_D8,
            double j_C4, double j_D4, double j_E4, double j_F4, double j_G4, double j_H4,
            double j_C7, double j_D7, double j_E7, double j_F7, double j_G7, double j_H7,
            double j_D9, double j_D11, double j_D45,
            double j_I9, double j_H49, double j_K11, double j_K12,
            double j_D45_2, double j_D41_2, double j_I18_2, double j_K9_2, double j_K39_2,
            double j_D11_2, double j_D9_2, double j_I35_2, double j_I33_2, double j_D29_2,
            double j_BQ_D27_2, double j_BQ_D58_2, double j_D33_2, double j_D50_2, double j_D39_2, double j_I10_2, double j_I13_2, double j_K11_2, DataTable dt_2, int I18_FLAG)
        {
            
            this.D1 = j_D1;
            this.F1 = j_F1;
            this.D8 = j_D8;
            this.C4 = j_C4;
            this.D4 = j_D4;
            this.E4 = j_E4;
            this.F4 = j_F4;
            this.G4 = j_G4;
            this.H4 = j_H4;
            this.C7 = j_C7;
            this.D7 = j_D7;
            this.E7 = j_E7;
            this.F7 = j_F7;
            this.G7 = j_G7;
            this.H7 = j_H7;
            this.D9 = j_D9;
            this.D11 = j_D11;
            this.D45 = j_D45;
            this.I9 = j_I9;
            this.H49 = j_H49;
            this.K11 = j_K11;
            this.K12 = j_K12;
            //--------------修正值
            this.D45_2 = j_D45_2;
            this.D41_2 = j_D41_2;
            this.I18_2 = j_I18_2;
            this.K9_2  = j_K9_2; //K9和I9都是膜通量
            this.I9 = j_K9_2; //K9和I9都是膜通量
            this.K39_2 = j_K39_2;
            this.D11_2 = j_D11_2;
            this.D9_2  = j_D9_2;
            this.I35_2 = j_I35_2;
            this.I33_2 = j_I33_2;
            this.D29_2 = j_D29_2;
            //this.D27_2 = j_D27_2;
            //this.D58_2 = j_D58_2;
            this.D33_2 = j_D33_2;
            this.D50_2 = j_D50_2;
            this.D39_2 = j_D39_2;
            this.I10_2 = j_I10_2;
            string I17_2_test = dt_2.Select("BS='SJ' AND WZ='I17'")[0][2].ToString();
            string I18_2_test = dt_2.Select("BS='SJ' AND WZ='I18'")[0][2].ToString();

            if (I18_FLAG == 0)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (Math.Abs(I17 - I18) / I17 > 0.01)
                    {
                        I18 = I17;
                        j_I18_2 = double.Parse(SSVo(I18, K9_2).Select("BS='SJ' AND WZ='I18'")[0][2].ToString());  //第一次试算Vo
                    }
                    else
                    {
                        break;
                    }
                }
                this.I18_2 = j_I18_2;

            }
            else {
                this.I18_2 = j_I18_2;
            }
           
            ArrayList mjsList_2 = new ArrayList();
            DataTable jsdt_2 = new DataTable();
            jsdt_2 = SS_2(j_D45_2, j_D41_2, j_I18_2, j_K9_2, j_K39_2, j_D11_2, j_D9_2, j_I35_2, j_I33_2, j_D29_2, j_BQ_D27_2, j_BQ_D58_2, j_D33_2, j_D50_2, j_D39_2, j_I10_2, j_I13_2, j_K11_2, I18_FLAG, D17_FLAG,D18_FLAG);       //初始化第一次运算   
            //膜计算
            this.K10 = D1 / K9_2 * 1000 / 0.9;
            mjsList_2 = new MJS().MLJS(K10, K12, D1, K9_2);
            I10 = double.Parse(mjsList_2[2].ToString());
            I13 = double.Parse(mjsList_2[1].ToString());
            K11 = double.Parse(mjsList_2[0].ToString());

            jsdt_2.Select("BS='SJ' AND WZ='I10'")[0][2] = I10;
            jsdt_2.Select("BS='SJ' AND WZ='I13'")[0][2] = I13;
            jsdt_2.Select("BS='SJ' AND WZ='K11'")[0][2] = K11;
            j_I10_2 = I10;
            j_I13_2 = I13;
            j_K11_2 = K11;
            jsdt_2 = SS_2(j_D45_2, j_D41_2, j_I18_2, j_K9_2, j_K39_2, j_D11_2, j_D9_2, j_I35_2, j_I33_2, j_D29_2, j_BQ_D27_2, j_BQ_D58_2, j_D33_2, j_D50_2, j_D39_2, j_I10_2, j_I13_2, j_K11_2, I18_FLAG, D17_FLAG, D18_FLAG);       //初始化第一次运算   
         //   jsdt_2 = SS_2(j_D45_2, j_D41_2, j_I18_2, j_K9_2, j_K39_2, j_D11_2, j_D9_2, j_I35_2, j_I33_2, j_D29_2, j_BQ_D27_2, j_BQ_D58_2, j_D33_2, j_D50_2, j_D39_2, j_I10_2, j_I13_2, j_K11_2, I18_FLAG, D17_FLAG, D18_FLAG);       //初始化第一次运算   
            if(I18_FLAG == 0)
            { 
            jsdt_2.Select("BS='SJ' AND WZ='I18'")[0][2] = jsdt_2.Select("BS='SJ' AND WZ='I17'")[0][2];
            }
            else
            {
                jsdt_2.Select("BS='SJ' AND WZ='I17'")[0][2] = jsdt_2.Select("BS='SJ' AND WZ='I18'")[0][2];
            }
                /*
            for (int j = 0; j < 50; j++)
            {
                if (Math.Abs(I17 - I18) / I17 > 0.01)
                {
                    I18 = I17;
                    jsdt_2 = SSVo(I18);  //第一次试算Vo
                }
                else
                {
                    break;
                }
            } for (int j = 0; j < 50; j++)
            {
                if (Math.Abs(D40 - D41) / D40 > 0.01)
                {
                    this.D41 = this.D40;
                    jsdt_2 = SSVn(D41); //第一次试算Vn

                }
                else
                {
                    break;
                }
            }
             */
           D17_FLAG = 0;
           D18_FLAG = 0;
            return jsdt_2;
        }
        public DataTable SS_2(double j_D45_2, double j_D41_2, double j_I18_2, double j_K9_2, double j_K39_2, double j_D11_2, double j_D9_2, double j_I35_2, double j_I33_2, double j_D29_2, double j_BQ_D27_2, double j_BQ_D58_2, double j_D33_2, double j_D50_2, double j_D39_2, double j_I10_2, double j_I13_2, double j_K11_2, int I18_FLAG,int d17_FLAG,int d18_FLAG)
        {
            D11 = j_D11_2;  //2
            D41 = j_D41_2;  //2
            I18 = j_I18_2;  //2
            I17 = j_I18_2;  //2
            K9  = j_K9_2;    //2
       // D18 = j_D9_2;   //2
            D9  = j_D9_2;    //2
            I35 = j_I35_2;  //2
            I33 = j_I33_2;  //2
            I9  = j_K9_2;    //2
            K9  = j_K9_2;    //2
       //     D17 = j_D11_2.ToString();
            D29 = j_D29_2;
            I10 = j_I10_2;
            I13 = j_I13_2;
            K11 = j_K11_2;

            //D26 = D27_2;

            //D58 = D58_2;
            
            
            //K39
            //D27 = D27_2;
            //D58_2
            //D33_2
            //D50_2

            //好氧区
            I26 = Math.Round(0.47 * System.Math.Exp(0.098 * (D8 - 15)) * G7 / (G7 + 1), 5);
            I27 = Math.Round(1 / I26, 5);
            I28 = Math.Round(3 * I27, 5);
            if (I28 > 25)
            {
                D26 = System.Math.Ceiling(I28);
            }
            else
            {
                D26 = 25;
            }
            D30 = Math.Round(I18 / D26, 5);
            //D29 = Math.Round(D26 / I18 * (I18 + D41), 5);
            D29 = D29_2;
            D10 = Math.Round(D1 * (G4 - G7) / 1000 / D9, 5);
            D33 = Math.Round(I33 * System.Math.Pow(1.04, D8 - 20), 5);
            D12 = Math.Round(D32 / (1 + D33 * D29), 5);
            if (2.86 * (G4 - F7) / (1 - 1.42 * D12) > 0) { D13 = Math.Round(2.86 * (G4 - F7) / (1 - 1.42 * D12), 5); }
            else { D13 = 0; }

            /*
            //----处理关于修正后不对的·问题
            if (C4 <= 500)
            {
                D11 = 1.5;
            }
            else if (C4 > 500 && C4 <= 1000)
            {
                D11 = 2;
            }
            else
            {
                D11 = 3;
            }
             */
            //修正
            

            D14 = Math.Round(D1 * (C4 - D13 - C7) / 1000 / D11, 5);

            ////---------------------
            //---以下移动位置
            K10 = Math.Round(D1 / K9 * 1000 / 0.9, 5);
            K13 = Math.Round(I13 * K12, 5);
            K14 = Math.Round((0.018 * K11 + 0.6) * I13, 5);
            
            if (K12 == 1)
            {
                K15 = 2.2;
            }
            else if (K12 == 2)
            {
                K15 = 3.5;
            }
            else
            {
                K15 = 4.5;
            }
            I16 = Math.Round(K14 * K15, 5);
            if (I18_FLAG == 0)
            {
                I17 = System.Math.Max(System.Math.Max(D10, D14), I16);
                //---以上移动位置
                //----------------------------------------------
                I18 = I17;
            }
            else
            {
                I17 = I18;
            }
            I19 = Math.Round(I18 / D1 * 24, 5);
            D15 = Math.Round((C4) / 2 * D1 / 1000 / (I18), 5);

            if (D17 == null)
            {
                D17 = "0.00";
            }
            if (double.Parse(D17).ToString("0.00") == D11.ToString("0.00"))
            {
                if (d17_FLAG != 1)
                {
                    if (D1 * (C4 - C7 - D13) / I18 / 1000 > 0)
                    {

                        D17 = Math.Round((D1 * (C4 - C7 - D13) / I18 / 1000), 5).ToString();
                    }
                    else
                    {
                        D17 = "需投加碳源";
                    }
                }
                
              
            }
            else
            {
                D17 = D11.ToString("0.00");
                D17_FLAG = 1;
            }

            if (D18 == D9)
            {
                if(d18_FLAG != 1)
                {
                D18 = Math.Round(D1 * (G4 - G7) / I18 / 1000, 5);
                }
                
            }
            else
            {
                D18 = D9;
                D18_FLAG = 1;
            }
                ///--修正，覆盖之前数值
            
            D38 = Math.Round(D32 * D1 * (C4 - C7) / (1 + D33 * D29) / 1000, 5);
            D39 = Math.Round(D37 * D38, 5);
            //D39 = D39_2;
            D22 = Math.Round(D21 * D39 / D1 * 1000 / D37, 5);
            D23 = Math.Round(D20 * I21 * (H4 - H7 - D22) / 31, 5);
            if (D23 <= 0) { D23 = 0; }
            if (D23 == 0)
            {
                D24 = 0;
            }
            else
            {
                D24 = Math.Round(D1 * (I22 * D23 + (I23 - I22 * I24) * (H4 - H7)) / 1000, 5);
            }
            D34 = Math.Round(D1 * D31 * (E4 - E7) / 1000 + D1 * D32 * (C4 - C7) / (1 + D33 * D29) / 1000 + D24, 5);
            D19 = Math.Round(D34 / D30, 5);
            D16 = Math.Round(D15 / D19, 5);

            /****************---以下移动位置
            K10 = Math.Round(D1 / K9 * 1000 / 0.9, 5);
            K13 = Math.Round(I13 * K12, 5);
            K14 = Math.Round((0.018 * K11 + 0.6) * I13, 5);
            I19 = Math.Round(I18 / D1 * 24, 5);
            if (K12 == 1)
            {
                K15 = 2.2;
            }
            else if (K12 == 2)
            {
                K15 = 3.5;
            }
            else
            {
                K15 = 4.5;
            }
            I16 = Math.Round(K14 * K15, 5);
            I17 = System.Math.Max(System.Math.Max(D10, D14), I16);
            //---以上移动位置********************/

            //D25 = 0.00;
            if (D23 * D1 / 1000 / 0.18 < 0)
                D25 = 0;
            else
                D25 = Math.Round(D23 * D1 / 1000 / 0.18, 5);
            D35 = Math.Round(I35 * System.Math.Pow(1.08, D8 - 20), 5);
            D44 = Math.Round(1000 * D41 * D35 * D19 / (F7 - G7) / 24, 5);
            D43 = Math.Round(D44 / D1 * 24, 5);
            D36 = Math.Round(D19 * (D43) / (D43 + 1), 5);
            //D40 = 0;
            if ((0.001 * D1 * (G4 - F7) - D39) / D35 / D19 > 0)
            {
                D40 = Math.Round((0.001 * D1 * (G4 - F7) - D39) / D35 / D19, 5);
            }
            else
            {
                D40 = 0;
            }
            D42 = Math.Round(D41 * 24 / D1, 5);

            /*
            if (D1 > 1000)
            {
                D45 = 0;
            }
            else
            {
                D45 = 10;
            }
             */
            D45 = D45_2;
            D46 = Math.Round(D1 * D45 / 24, 5);
            D50 = 0.6;
            D47 = Math.Round(D46 * D50, 5);
            D48 = D46 + I18 + D41;
            //D49 = D47 + I19 + D42;
            K49 = Math.Round(D49 / H49, 5);
            DataTable dt = new DataTable("TB_SJ");
            dt.Columns.Add("BS", System.Type.GetType("System.String"));
            dt.Columns.Add("WZ", System.Type.GetType("System.String"));
            dt.Columns.Add("SZ", System.Type.GetType("System.String"));

            dt.Rows.Add("SJ", "D1", D1);
            dt.Rows.Add("SJ", "F1", F1);
            dt.Rows.Add("SJ", "D8", D8);
            dt.Rows.Add("SJ", "C4", C4);
            dt.Rows.Add("SJ", "D4", D4);
            dt.Rows.Add("SJ", "E4", E4);
            dt.Rows.Add("SJ", "F4", F4);
            dt.Rows.Add("SJ", "G4", G4);
            dt.Rows.Add("SJ", "H4", H4);
            dt.Rows.Add("SJ", "C7", C7);
            dt.Rows.Add("SJ", "D7", D7);
            dt.Rows.Add("SJ", "E7", E7);
            dt.Rows.Add("SJ", "F7", F7);
            dt.Rows.Add("SJ", "G7", G7);
            dt.Rows.Add("SJ", "H7", H7);
            dt.Rows.Add("SJ", "D9", D9);
            dt.Rows.Add("SJ", "D11", D11);
            dt.Rows.Add("SJ", "I18", I18);
            dt.Rows.Add("SJ", "I26", I26);
            dt.Rows.Add("SJ", "I27", I27);
            dt.Rows.Add("SJ", "I28", I28);
            dt.Rows.Add("SJ", "D26", D26);
            dt.Rows.Add("SJ", "D30", D30);
            dt.Rows.Add("SJ", "D32", D32);
            dt.Rows.Add("SJ", "D31", D31);
            dt.Rows.Add("SJ", "D41", D41);
            dt.Rows.Add("SJ", "D29", D29);
            dt.Rows.Add("SJ", "D10", D10);
            
            dt.Rows.Add("SJ", "I33", I33);
            dt.Rows.Add("SJ", "D33", D33);
            dt.Rows.Add("SJ", "D12", D12);
            dt.Rows.Add("SJ", "D14", D14);
            dt.Rows.Add("SJ", "D15", D15);
            dt.Rows.Add("SJ", "D17", D17);
            dt.Rows.Add("SJ", "D18", D18);
            dt.Rows.Add("SJ", "D20", D20);
            dt.Rows.Add("SJ", "I21", I21);
            dt.Rows.Add("SJ", "I22", I22);
            dt.Rows.Add("SJ", "I23", I23);
            dt.Rows.Add("SJ", "I24", I24);
            dt.Rows.Add("SJ", "D21", D21);
            dt.Rows.Add("SJ", "D37", D37);
            dt.Rows.Add("SJ", "D38", D38);
            dt.Rows.Add("SJ", "D39", D39);
            dt.Rows.Add("SJ", "D22", D22);
            dt.Rows.Add("SJ", "D23", D23);
            dt.Rows.Add("SJ", "D24", D24);
            dt.Rows.Add("SJ", "D34", D34);
            dt.Rows.Add("SJ", "D19", D19);
            dt.Rows.Add("SJ", "D16", D16);
            dt.Rows.Add("SJ", "K9 ", K9);
            dt.Rows.Add("SJ", "K10", K10);
            dt.Rows.Add("SJ", "K11", K11);
            dt.Rows.Add("SJ", "K12", K12);
            dt.Rows.Add("SJ", "I13", I13);
            dt.Rows.Add("SJ", "K13", K13);
            dt.Rows.Add("SJ", "K14", K14);
            dt.Rows.Add("SJ", "I10", I10);
            dt.Rows.Add("SJ", "I9 ", I9);
            dt.Rows.Add("SJ", "I19", I19);
            dt.Rows.Add("SJ", "K15", K15);
            dt.Rows.Add("SJ", "I16", I16);
            dt.Rows.Add("SJ", "I17", I17);
            dt.Rows.Add("SJ", "D25", D25);
            dt.Rows.Add("SJ", "J21", J21);
            dt.Rows.Add("SJ", "J22", J22);
            dt.Rows.Add("SJ", "J23", J23);
            dt.Rows.Add("SJ", "J24", J24);
            dt.Rows.Add("SJ", "I35", I35);
            dt.Rows.Add("SJ", "D35", D35);
            dt.Rows.Add("SJ", "D44", D44);
            dt.Rows.Add("SJ", "D43", D43);
            dt.Rows.Add("SJ", "D36", D36);
            dt.Rows.Add("SJ", "D40", D40);
            dt.Rows.Add("SJ", "D42", D42);
            dt.Rows.Add("SJ", "D45", D45);
            dt.Rows.Add("SJ", "D46", D46);
            dt.Rows.Add("SJ", "D47", D47);
            dt.Rows.Add("SJ", "D48", D48);
          //  dt.Rows.Add("SJ", "D49", D49);
            dt.Rows.Add("SJ", "H49", H49);
            //dt.Rows.Add("SJ", "D50", D50);
            DataTable dt_bq = new BQJS().BQJS_3(D1, D4, E7, D38, G4, F4, F7, G7, K12, D8, D47, D19, D50, j_BQ_D27_2, j_BQ_D58_2, j_I13_2, j_K11_2, j_D39_2);
            D49 = Convert.ToDouble(dt_bq.Select("BS='BQ' AND WZ='D67'")[0][2]);
            D50 = D49;
            dt.Rows.Add("SJ", "D49", D49);
            dt.Rows.Add("SJ", "D50", D50);
            object[] obj = new object[dt.Columns.Count];
            for (int i = 0; i < dt_bq.Rows.Count; i++)
            {
                dt_bq.Rows[i].ItemArray.CopyTo(obj, 0);
                dt.Rows.Add(obj);
            }
            return dt;
        }
    }
}
