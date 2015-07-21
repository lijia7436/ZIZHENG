using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using System.Text;

namespace ZIZHENG
{
    class MJS
    {
        public double K10;
        public double K12;
        public double K9;
        public double D1;
        public int i1;
        public ArrayList MLJS(double k10,double k12,double d1,double k9)
        {    
             ArrayList lits1 = new ArrayList();
             K10 = k10;
             K12 = k12;
             D1 = d1;
             K9 = k9;
             
             DataTable dt = new DataTable("TB_MJS");
             dt.Columns.Add("ZJ", typeof(int));
             dt.Columns.Add("ZJSL", typeof(double));
             dt.Columns.Add("NPS", typeof(double));
             dt.Columns.Add("SJTL", typeof(double));
             dt.Columns.Add("TLCZ", typeof(double));
            
            if(D1 >0 && D1 <=3.60)
            {
                i1 = 10;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 20;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 40;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 50;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 60;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 80;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 100;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 120;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 150;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));

            }
            else if (D1 > 3.60 && D1 <= 60)
            {
                i1 = 20;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 40;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 50;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 60;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 80;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 100;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 120;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 150;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));

            }
            else if (D1 > 60 && D1 <= 200)
            {
                i1 = 40;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 50;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 60;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 80;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 100;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 120;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 150;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));

            }
            else if (D1 > 200)
            {
                i1 = 80;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 100;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 120;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));
                i1 = 150;
                dt.Rows.Add(
                    i1,
                    Math.Round(MZJSL(i1, K10, K12), 0),
                    Math.Round(i1 * MZJSL(i1, K10, K12) * K12, 0),
                    Math.Round(D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000, 2),
                    Math.Round(Math.Abs((D1 / (i1 * MZJSL(i1, K10, K12) * K12) / 0.9 * 1000) - K9), 2));

            }


            DataView dv = dt.DefaultView;dv.Sort = "TLCZ Asc,ZJ Desc";
            DataTable dt2 = dv.ToTable();
            lits1.Add(dt2.Rows[0][0]);
            lits1.Add(dt2.Rows[0][1]);
            lits1.Add(dt2.Rows[0][2]);
            lits1.Add(dt2.Rows[0][3]);
            lits1.Add(dt2.Rows[0][4]);
             return lits1;
        }
        public double MZJSL(int O15,double k10,double k12)
        {
            double d = 0;if (K10/O15/K12 < 1)
            {
                d = 1;
            }
            else
            {
                d = Math.Round(K10/O15/K12, 0);
            }

            return d;
        }


    }
}
