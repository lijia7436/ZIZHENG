using System;
using System.Collections.Generic;
using System.Data;

using System.Text;
using System.Windows.Forms;
//using DevExpress.Utils;

namespace ZIZHENG
{
    /// <summary>
    /// 曝气计算公式
    /// </summary>
    class BQJS
    {
        
        public double D1 = 0.00;
        public double D2 = 0.00;
        public double D3 = 0.00;
        public double D4 = 0.00;
        public double D5 = 0.00;
        public double D6 = 0.00;
        public double D7 = 0.00;
        public double D8 = 0.00;
        public double D9 = 0.00;
        public double D10 = 0.00;
        public double D11 = 0.00;
        public double D12 = 0.00;
        public double D13 = 0.00;
        public double D14 = 0.00;
        public double D15 = 0.00;
        public double D16 = 0.00;
        public double D17 = 0.00;
        public double D18 = 0.00;
        public double D19 = 0.00;
        public double D20 = 0.00;
        public double D21 = 0.00;
        public double D22 = 0.00;
        public double D23 = 0.00;
        public double D24 = 0.00;
        public double D25 = 0.00;
        public double D26 = 0.00;
        public double D27 = 0.00;
        public double D28 = 0.00;
        public double D29 = 0.00;
        public double D30 = 0.00;
        public double D31 = 0.00;
        public double D32 = 0.00;
        public double D33 = 0.00;
        public double D34 = 0.00;
        public double D35 = 0.00;
        public double D36 = 0.00;
        public double D37 = 0.00;
        public double D38 = 0.00;
        public double D39 = 0.00;
        public double D40 = 0.00;
        public double D41 = 0.00;
        public double D42 = 0.00;
        public double D43 = 0.00;
        public double D44 = 0.00;
        public double D45 = 0.00;
        public double D46 = 0.00;
        public double D47 = 0.00;
        public double D48 = 0.00;
        public double D49 = 0.00;
        public double D50 = 0.00;
        public double D51 = 0.00;
        public double D52 = 0.00;
        public double D53 = 0.00;
        public double D54 = 0.00;
        public double D55 = 0.00;
        public double D56 = 0.00;
        public double D57 = 0.00;
        public double D58 = 0.00;
        public double D59 = 0.00;
        public double D60 = 0.00;
        public double D61 = 0.00;
        public double D62 = 0.00;
        public double D63 = 0.00;
        public double D64 = 0.00;
        public double D65 = 0.00;
        public double D66 = 0.00;
        public double D67 = 0.00;
        public double D68 = 0.00;
        JS sj = new JS();

        public DataTable BQJS_2(
            double d1, double d4, double e7, double d38, double g4, double f4, double f7, 
            double g7, double k12, double d8, double d47,double d19,double sj_d50,
            double i13,double k11)
        {
            D10 = Math.Round(d4,5);//=设计计算表!D4
            D11 = Math.Round(e7,5);//设计计算表!E7
            D9 = Math.Round(d1,5);//=设计计算表!D1
            D6 = Math.Round(1.47,5);
            D7 = Math.Round(4.57,5);
            D17 = Math.Round(0.8,5);
            D18 = Math.Round(0.95,5);
            D2 = Math.Round(0.001 * D6 * D9 * (D10 - D11),5);
            D8 = Math.Round(1.42,5);
            D12 = Math.Round(d38,5);//设计计算表!D38
            D3 = Math.Round(D8 * D12,5);
            D13 = Math.Round(g4,5);//设计计算表!G4
            D14 = 2;
            D4 = Math.Round(D7 * (0.001 * D9 * (D13 - D14) - 0.12 * D12),5);
            D15 = Math.Round(f4,5);//设计计算表!F4
            D16 = Math.Round(f7 - g7,5);//设计计算表!F7-设计计算表!G7
            D5 = Math.Round(0.62 * D7 * (0.001 * D9 * (D15 - D14 - D16) - 0.12 * D12),5);
            D1 = Math.Round(D2 - D3 + D4 - D5,5);
            if (k12 == 1)
            {
            D24 = 2.2;
            }
            else if (k12 == 2)
            {
            D24 = 3.5;
            }
            else
            {
            D24 = 4.5;
            }
            D25 = Math.Round(D24 - 0.3,5);
            D26 = Math.Round(1.013 * 100000 + 9.8 * 1000 * D25,5);
           // D33 = d8;//d8;//手册设计计算表!C13,输入温度 =d8
            if(d8 > 25)
            {
                D33 = d8;
            }else
            {
                D33 = 25;//恒值25℃
            }
            
            D22 = getwd(D33);//D22 = 11.83;//算
           // D27 = Math.Round(0.057 * 0.84,5); //算
            D27 = getss(D24)/100*getnd(d19);
            D31 = Math.Round(21 * (1 - D27) / (79 + 21 * (1 - D27)) * 100,5);
            D19 = Math.Round(D22 * (D31 / 42 + D26 / 202600),5);
            D20 = 2;
            D21 = 9.17;


            D32 = 1.024;
            
            D34 = 1;
            D35 = Math.Round(D1 * D21 / (D17 * System.Math.Pow(D32, D33 - 20) * (D18 * D19 * D34 - D20)),5);
            D36 = Math.Round(D35 / 24,5);
            D37 = Math.Round(D36 / (0.28 * D27),5);
            D38 = Math.Round(D37 / 60,5);
            D39 = 1;
            D40 = i13;
            D41 = k11;
            D42 = Math.Round(0.5 * 0.018 * D41 * D40,5);
            D43 = Math.Round(D39 * D42,5);
            D44 = Math.Round(D43 * 0.28 * D27,5);
            D45 = Math.Round(D44 * 60 * 24,5);
            D46 = Math.Round(D45 * (D17 * System.Math.Pow(D32, (D33 - 20)) * (D18 * D34 * D19 - D20)) / D21,5); //次方
            if (D1 - D46 > 0)
                D47 = D1 - D46;
            else
                D47 = 0;
            D48 = 0.8;
            D49 = 0.95;

            D51 = 2;
            D52 = 9.17;
            D53 = 11.83;
            D55 = 4.00;
            D56 = D55 - 0.3;
            D57 = Math.Round(1.013 * 100000 + 9.8 * 1000 * D56,5);
            D58 = Convert.ToDouble(12) / 100;
            D59 = Math.Round(21 * (1 - D58) / (79 + 21 * (1 - D58)) * 100,5);
            D50 = Math.Round(D53 * (D59 / 42 + D57 / 202600),5);



            //D60 = 1.013*100000+9.8*1000*D56;
            D60 = 1.024;
            D61 = d8;//手册设计计算表!C13,输入温度 =d8
            D62 = 1;
            D63 = Math.Round(D47 * D52 / (D48 * System.Math.Pow(D60, D61 - 20) * (D49 * D50 * D62 - D51)),5);
            D64 = Math.Round(D63 / 24,5);
            D65 = Math.Round(D64 / (0.28 * D58),5);
            D66 = Math.Round(D65 / 60,5);
            D67 = Math.Round(D66 + D43,5); 
            D68 = Math.Round(d47 / 60,5); //设计计算表!D47/60;

            DataTable dt = new DataTable("TB_BQ");
            dt.Columns.Add("BS", System.Type.GetType("System.String"));
            dt.Columns.Add("WZ", System.Type.GetType("System.String"));
            dt.Columns.Add("SZ", System.Type.GetType("System.String"));
            dt.Rows.Add("BQ", "D1", D1);
            dt.Rows.Add("BQ", "D2", D2);
            dt.Rows.Add("BQ", "D3", D3);
            dt.Rows.Add("BQ", "D4", D4);
            dt.Rows.Add("BQ", "D5", D5);
            dt.Rows.Add("BQ", "D6", D6);dt.Rows.Add("BQ", "D7", D7);
            dt.Rows.Add("BQ", "D8", D8);
            dt.Rows.Add("BQ", "D9", D9);
            dt.Rows.Add("BQ", "D10 ", D10);
            dt.Rows.Add("BQ", "D11 ", D11);
            dt.Rows.Add("BQ", "D12 ", D12);
            dt.Rows.Add("BQ", "D13 ", D13);
            dt.Rows.Add("BQ", "D14 ", D14);
            dt.Rows.Add("BQ", "D15 ", D15);
            dt.Rows.Add("BQ", "D16 ", D16);
            dt.Rows.Add("BQ", "D17 ", D17);
            dt.Rows.Add("BQ", "D18 ", D18);
            dt.Rows.Add("BQ", "D19 ", D19);
            dt.Rows.Add("BQ", "D20 ", D20);
            dt.Rows.Add("BQ", "D21 ", D21);
            dt.Rows.Add("BQ", "D22 ", D22);
            dt.Rows.Add("BQ", "D23 ", D23);
            dt.Rows.Add("BQ", "D24 ", D24);
            dt.Rows.Add("BQ", "D25 ", D25);
            dt.Rows.Add("BQ", "D26 ", D26);
            dt.Rows.Add("BQ", "D27 ", D27);
            dt.Rows.Add("BQ", "D28 ", D28);
            dt.Rows.Add("BQ", "D29 ", D29);
            dt.Rows.Add("BQ", "D30 ", D30);
            dt.Rows.Add("BQ", "D31 ", D31);
            dt.Rows.Add("BQ", "D32 ", D32);
            dt.Rows.Add("BQ", "D33 ", D33);
            dt.Rows.Add("BQ", "D34 ", D34);
            dt.Rows.Add("BQ", "D35 ", D35);
            dt.Rows.Add("BQ", "D36 ", D36);
            dt.Rows.Add("BQ", "D37 ", D37);
            dt.Rows.Add("BQ", "D38 ", D38);
            dt.Rows.Add("BQ", "D39 ", D39);
            dt.Rows.Add("BQ", "D40 ", D40);
            dt.Rows.Add("BQ", "D41 ", D41);
            dt.Rows.Add("BQ", "D42 ", D42);
            dt.Rows.Add("BQ", "D43 ", D43);
            dt.Rows.Add("BQ", "D44 ", D44);
            dt.Rows.Add("BQ", "D45 ", D45);
            dt.Rows.Add("BQ", "D46 ", D46);
            dt.Rows.Add("BQ", "D47 ", D47);
            dt.Rows.Add("BQ", "D48 ", D48);
            dt.Rows.Add("BQ", "D49 ", D49);
            dt.Rows.Add("BQ", "D50 ", D50);
            dt.Rows.Add("BQ", "D51 ", D51);
            dt.Rows.Add("BQ", "D52 ", D52);
            dt.Rows.Add("BQ", "D53 ", D53);
            dt.Rows.Add("BQ", "D54 ", D54);
            dt.Rows.Add("BQ", "D55 ", D55);
            dt.Rows.Add("BQ", "D56 ", D56);
            dt.Rows.Add("BQ", "D57 ", D57);
            dt.Rows.Add("BQ", "D58 ", D58);
            dt.Rows.Add("BQ", "D59 ", D59);
            dt.Rows.Add("BQ", "D60 ", D60);
            dt.Rows.Add("BQ", "D61 ", D61);
            dt.Rows.Add("BQ", "D62 ", D62);
            dt.Rows.Add("BQ", "D63 ", D63);
            dt.Rows.Add("BQ", "D64 ", D64);
            dt.Rows.Add("BQ", "D65 ", D65);
            dt.Rows.Add("BQ", "D66 ", D66);
            dt.Rows.Add("BQ", "D67 ", D67);
            dt.Rows.Add("BQ", "D68 ", D68);

            return dt;
        }

        public DataTable BQJS_3(double j_d1, double j_d4, double j_e7, double j_d38, double j_g4,
            double j_f4, double j_f7, double j_g7, double j_k12, double j_d8, double j_d47, double j_d19,
            double j_d50, double j_BQ_D27_2, double j_BQ_D58_2, double j_i13, double j_k11, double j_D39_2)
        {
            D10 = Math.Round(j_d4, 5);//=设计计算表!D4
            D11 = Math.Round(j_e7, 5);//设计计算表!E7
            D9 = Math.Round(j_d1, 5);//=设计计算表!D1
            D6 = Math.Round(1.47, 5);
            D7 = Math.Round(4.57, 5);
            D17 = Math.Round(0.8, 5);
            D18 = Math.Round(0.95, 5);
            D2 = Math.Round(0.001 * D6 * D9 * (D10 - D11), 5);
            D8 = Math.Round(1.42, 5);
            D12 = Math.Round(j_d38, 5);//设计计算表!D38
            D3 = Math.Round(D8 * D12, 5);
            D13 = Math.Round(j_g4, 5);//设计计算表!G4
            D14 = 2;
            D4 = Math.Round(D7 * (0.001 * D9 * (D13 - D14) - 0.12 * D12), 5);
            D15 = Math.Round(j_f4, 5);//设计计算表!F4
            D16 = Math.Round(j_f7 - j_g7, 5);//设计计算表!F7-设计计算表!G7
            D5 = Math.Round(0.62 * D7 * (0.001 * D9 * (D15 - D14 - D16) - 0.12 * D12), 5);
            D1 = Math.Round(D2 - D3 + D4 - D5, 5);
            if (j_k12 == 1)
            {
                D24 = 2.2;
            }
            else if (j_k12 == 2)
            {
                D24 = 3.5;
            }
            else
            {
                D24 = 4.5;
            }
            D25 = Math.Round(D24 - 0.3, 5);
            D26 = Math.Round(1.013 * 100000 + 9.8 * 1000 * D25, 5);
            //D33 = j_d8;//d8;//手册设计计算表!C13,输入温度 =d8
            if (j_d8 > 25)
            {
                D33 = j_d8;
            }
            else
            {
                D33 = 25;//恒值25℃
            }
           
            D22 = getwd(D33);//D22 = 11.83;//算
            // D27 = Math.Round(0.057 * 0.84,5); //算
            //D27 = getss(D24) / 100 * getnd(j_d19);
            D27 = j_BQ_D27_2;
            D31 = Math.Round(21 * (1 - D27) / (79 + 21 * (1 - D27)) * 100, 5);
            D19 = Math.Round(D22 * (D31 / 42 + D26 / 202600), 5);
            D20 = 2;
            D21 = 9.17;


            D32 = 1.024;

            D34 = 1;
            D35 = Math.Round(D1 * D21 / (D17 * System.Math.Pow(D32, D33 - 20) * (D18 * D19 * D34 - D20)), 5);
            D36 = Math.Round(D35 / 24, 5);
            D37 = Math.Round(D36 / (0.28 * D27), 5);
            D38 = Math.Round(D37 / 60, 5);
            D39 = j_D39_2;//修正值
            D40 = j_i13;
            D41 = j_k11;
            D42 = Math.Round(0.5 * 0.018 * D41 * D40, 5);
            D43 = Math.Round(D39 * D42, 5);
            D44 = Math.Round(D43 * 0.28 * D27, 5);
            D45 = Math.Round(D44 * 60 * 24, 5);
            D46 = Math.Round(D45 * (D17 * System.Math.Pow(D32, (D33 - 20)) * (D18 * D34 * D19 - D20)) / D21, 5); //次方
            if (D1 - D46 > 0)
                D47 = D1 - D46;
            else
                D47 = 0;
            D48 = 0.8;
            D49 = 0.95;

            D51 = 2;
            D52 = 9.17;
            D53 = 11.83;
            D55 = 4.00;
            D56 = D55 - 0.3;
            D57 = Math.Round(1.013 * 100000 + 9.8 * 1000 * D56, 5);
            //D58 = Convert.ToDouble(12) / 100;
            D58 = j_BQ_D58_2;
            D59 = Math.Round(21 * (1 - D58) / (79 + 21 * (1 - D58)) * 100, 5);
            D50 = Math.Round(D53 * (D59 / 42 + D57 / 202600), 5);



            //D60 = 1.013*100000+9.8*1000*D56;
            D60 = 1.024;
            D61 = j_d8;//手册设计计算表!C13,输入温度 =d8
            D62 = 1;
            D63 = Math.Round(D47 * D52 / (D48 * System.Math.Pow(D60, D61 - 20) * (D49 * D50 * D62 - D51)), 5);
            D64 = Math.Round(D63 / 24, 5);
            D65 = Math.Round(D64 / (0.28 * D58), 5);
            D66 = Math.Round(D65 / 60, 5);
            D67 = Math.Round(D66 + D43, 5);
            D68 = Math.Round(j_d47 / 60, 5); //设计计算表!D47/60;

            DataTable dt = new DataTable("TB_BQ");
            dt.Columns.Add("BS", System.Type.GetType("System.String"));
            dt.Columns.Add("WZ", System.Type.GetType("System.String"));
            dt.Columns.Add("SZ", System.Type.GetType("System.String"));
            dt.Rows.Add("BQ", "D1", D1);
            dt.Rows.Add("BQ", "D2", D2);
            dt.Rows.Add("BQ", "D3", D3);
            dt.Rows.Add("BQ", "D4", D4);
            dt.Rows.Add("BQ", "D5", D5);
            dt.Rows.Add("BQ", "D6", D6); 
            dt.Rows.Add("BQ", "D7", D7);
            dt.Rows.Add("BQ", "D8", D8);
            dt.Rows.Add("BQ", "D9", D9);
            dt.Rows.Add("BQ", "D10 ", D10);
            dt.Rows.Add("BQ", "D11 ", D11);
            dt.Rows.Add("BQ", "D12 ", D12);
            dt.Rows.Add("BQ", "D13 ", D13);
            dt.Rows.Add("BQ", "D14 ", D14);
            dt.Rows.Add("BQ", "D15 ", D15);
            dt.Rows.Add("BQ", "D16 ", D16);
            dt.Rows.Add("BQ", "D17 ", D17);
            dt.Rows.Add("BQ", "D18 ", D18);
            dt.Rows.Add("BQ", "D19 ", D19);
            dt.Rows.Add("BQ", "D20 ", D20);
            dt.Rows.Add("BQ", "D21 ", D21);
            dt.Rows.Add("BQ", "D22 ", D22);
            dt.Rows.Add("BQ", "D23 ", D23);
            dt.Rows.Add("BQ", "D24 ", D24);
            dt.Rows.Add("BQ", "D25 ", D25);
            dt.Rows.Add("BQ", "D26 ", D26);
            dt.Rows.Add("BQ", "D27 ", D27);
            dt.Rows.Add("BQ", "D28 ", D28);
            dt.Rows.Add("BQ", "D29 ", D29);
            dt.Rows.Add("BQ", "D30 ", D30);
            dt.Rows.Add("BQ", "D31 ", D31);
            dt.Rows.Add("BQ", "D32 ", D32);
            dt.Rows.Add("BQ", "D33 ", D33);
            dt.Rows.Add("BQ", "D34 ", D34);
            dt.Rows.Add("BQ", "D35 ", D35);
            dt.Rows.Add("BQ", "D36 ", D36);
            dt.Rows.Add("BQ", "D37 ", D37);
            dt.Rows.Add("BQ", "D38 ", D38);
            dt.Rows.Add("BQ", "D39 ", D39);
            dt.Rows.Add("BQ", "D40 ", D40);
            dt.Rows.Add("BQ", "D41 ", D41);
            dt.Rows.Add("BQ", "D42 ", D42);
            dt.Rows.Add("BQ", "D43 ", D43);
            dt.Rows.Add("BQ", "D44 ", D44);
            dt.Rows.Add("BQ", "D45 ", D45);
            dt.Rows.Add("BQ", "D46 ", D46);
            dt.Rows.Add("BQ", "D47 ", D47);
            dt.Rows.Add("BQ", "D48 ", D48);
            dt.Rows.Add("BQ", "D49 ", D49);
            dt.Rows.Add("BQ", "D50 ", D50);
            dt.Rows.Add("BQ", "D51 ", D51);
            dt.Rows.Add("BQ", "D52 ", D52);
            dt.Rows.Add("BQ", "D53 ", D53);
            dt.Rows.Add("BQ", "D54 ", D54);
            dt.Rows.Add("BQ", "D55 ", D55);
            dt.Rows.Add("BQ", "D56 ", D56);
            dt.Rows.Add("BQ", "D57 ", D57);
            dt.Rows.Add("BQ", "D58 ", D58);
            dt.Rows.Add("BQ", "D59 ", D59);
            dt.Rows.Add("BQ", "D60 ", D60);
            dt.Rows.Add("BQ", "D61 ", D61);
            dt.Rows.Add("BQ", "D62 ", D62);
            dt.Rows.Add("BQ", "D63 ", D63);
            dt.Rows.Add("BQ", "D64 ", D64);
            dt.Rows.Add("BQ", "D65 ", D65);
            dt.Rows.Add("BQ", "D66 ", D66);
            dt.Rows.Add("BQ", "D67 ", D67);
            dt.Rows.Add("BQ", "D68 ", D68);

            return dt;
        }

        //取温度（曝气D33）
        public double getwd(double D33)
        {
            int i = Convert.ToInt16(Math.Round(D33, 0));
            double wd = 0.00;
            switch (i)
            {
                 	

                    case 0: wd = 14.62; break;
                    case 1: wd = 14.23; break;
                    case 2: wd = 13.84; break;
                    case 3: wd = 13.48; break;
                    case 4: wd = 13.13; break;
                    case 5: wd = 12.80; break;
                    case 6: wd = 12.48; break;
                    case 7: wd = 12.17; break;
                    case 8: wd = 11.87; break;
                    case 9: wd = 11.59; break;
                    case 10: wd = 11.33; break;
                    case 11: wd = 11.08; break;
                    case 12: wd = 10.83; break;
                    case 13: wd = 10.60; break;
                    case 14: wd = 10.37; break;
                    case 15: wd = 10.15; break;
                    case 16: wd = 9.95; break;
                    case 17: wd = 9.74; break;
                    case 18: wd = 9.54; break;
                    case 19: wd = 9.35; break;
                    case 20: wd = 9.17; break;
                    case 21: wd = 8.99; break;
                    case 22: wd = 8.83; break;
                    case 23: wd = 8.63; break;
                    case 24: wd = 8.53; break;
                    case 25: wd = 8.38; break;
                    case 26: wd = 8.22; break;
                    case 27: wd = 8.07; break;
                    case 28: wd = 7.92; break;
                    case 29: wd = 7.77; break;
                    case 30: wd = 7.63; break;
                    default:
                    wd = 10.83;break; //默认12度
            }


            return wd;
        }
        //去水深（曝气D24）
        public double getss(double D24)
        {
            double ss = 0.00;
            if (D24>=1 && D24<=2)
            {
                ss = ((D24 - 1) * (3.5 - 2) / (2 - 1)) + 2;
            }
            else if(D24>2 && D24<=3)
            {
                ss = ((D24 - 2) * (5 - 3.5) / (3 - 2)) + 3.5;
            }
            else if(D24>3 && D24<=4)
            {
                ss = ((D24 - 3) * (6 - 5) / (4 - 3)) + 5;
            }
            else if(D24>4 && D24<=5)
            {
                ss = ((D24 - 4) * (7 - 6) / (5 - 4)) + 6;
            }

            return ss;
        }
        //取污泥浓度（设计D19）
        public double getnd(double D19)
        {
            double nd = 0.00;
            if (D19 >= 0 && D19 <= 5)
            {
                nd = ((D19 - 0)*(0.95 - 1)/(5 - 0)) + 0.95;
            }
            else if (D19 > 5 || D19 <= 10)
            {
                nd = ((D19 - 5)*(0.85 - 0.95)/(10 - 5)) + 0.85;
            }
            else if (D19 > 10 || D19 <= 15)
            {
                nd = ((D19 - 10)*(0.75 - 0.85)/(15 - 10)) + 0.75;
            }
            else if (D19 > 15 && D19 <= 20)
            {
                nd = ((D19 - 15)*(0.6 - 0.75)/(20 - 15)) + 0.6;
            }

            return nd;
        }
    }
}
