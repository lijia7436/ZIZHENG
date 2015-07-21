using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using Aspose.Words;
using Aspose.Words.Tables;
using Aspose.Words.Drawing;

namespace ZIZHENG
{
    class ExpWord
    {
        public Aspose.Words.Document doc;
        public Aspose.Words.Bookmark bookmark;
        public Aspose.Words.DocumentBuilder builder;

        public void ExpWD(DataTable dt1, DataTable dt2, DataTable dt3, DataTable dt4, DataTable dt5, DataTable dt6, DataTable dt7, DataTable dt8, DataTable dt9, DataTable dt10, DataTable dt11, DataTable dt12)
        {
            try
            {
             // string templateFile = "F:/子征/mb.doc";
             //string saveDocFile = "F:/子征/方案[" + DateTime.Now.ToString("yyyyMMddhhmmss")+"].doc";
            string templateFile = System.Windows.Forms.Application.StartupPath + "\\mb.doc";
            string saveDocFile = System.Windows.Forms.Application.StartupPath + "\\"+dt1.Rows[0]["BS"].ToString()+"方案[" + DateTime.Now.ToString("yyyyMMddhhmmss") + "].doc";
            //dateToUpper(DateTime.Now); 

            doc = new Aspose.Words.Document(templateFile);
            ExpWD1(dt1);
            ExpWD2(dt2);
            ExpWD3(dt3);
            ExpWD4(dt4);
            ExpWD5(dt5);
            ExpWD6(dt6);
            ExpWD7(dt7);
            ExpWD8(dt8);
            ExpWD9(dt9);
            ExpWD10(dt10);
            ExpWD11(dt11);
            ExpWD12(dt12);
            doc.Save(saveDocFile);
            if (MessageUtil.ShowYesNoAndTips("保存成功，是否打开文件？") == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(saveDocFile);
            }
            }
            catch (Exception e)
            {
                MessageUtil.ShowWarning("模版生成异常,请检查模版及数据是否正常!");
                new Log().Write(e.Message.ToString(), MsgType.Error);
                
            }
            
        }
        /// <summary>
        /// 基本信息
        /// </summary>
        public void ExpWD1(System.Data.DataTable dt1)
        {
            
            #region 使用书签替换模式

            //赋值开始
            //方案名称
            bookmark = doc.Range.Bookmarks["Z_A0_1"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[0]["BS"].ToString(); 
            }
            //方案时间
            bookmark = doc.Range.Bookmarks["Z_A0_2"];
            if (bookmark != null)
            {
                bookmark.Text = dateToUpper(DateTime.Now); 
            }
            //处理量
            bookmark = doc.Range.Bookmarks["Z_A0_3"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[3]["BS"].ToString(); 
            }
            //处理水源
            bookmark = doc.Range.Bookmarks["Z_A0_4"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[5]["BS"].ToString();
            }
            //出水水质1
            bookmark = doc.Range.Bookmarks["Z_A0_5"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[25]["BS"].ToString();
            }
            //出水水质2
            bookmark = doc.Range.Bookmarks["Z_A0_6"];
            if (bookmark != null)
            {
                if (dt1.Rows[26]["BS"].ToString() !=null)
                {
                bookmark.Text = "中\""+dt1.Rows[26]["BS"].ToString()+"\"";
                }
            }
            //设备占地
            bookmark = doc.Range.Bookmarks["Z_A0_7"];
            if (bookmark != null)
            {
                bookmark.Text = "[尚未取值]";
            }
            //吨水占地
            bookmark = doc.Range.Bookmarks["Z_A0_8"];
            if (bookmark != null)
            {
                bookmark.Text = "[尚未取值]";
            }
            //吨水运行费
            bookmark = doc.Range.Bookmarks["Z_A0_9"];
            if (bookmark != null)
            {
                bookmark.Text = "[尚未取值]";
            }
            //吨水运行能耗
            bookmark = doc.Range.Bookmarks["Z_A0_A1"];
            if (bookmark != null)
            {
                bookmark.Text = "[尚未取值]";
            }
            //吨水运行投资
            bookmark = doc.Range.Bookmarks["Z_A0_A2"];
            if (bookmark != null)
            {
                bookmark.Text = "[尚未取值]";
            }
            //总投资
            bookmark = doc.Range.Bookmarks["Z_A0_A3"];
            if (bookmark != null)
            {
                bookmark.Text = "[尚未取值]";
            }
            //----------------------------------------------------
            //项目名称
            bookmark = doc.Range.Bookmarks["Z_A11_1"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[0]["BS"].ToString(); 
            }
            //项目地点
            bookmark = doc.Range.Bookmarks["Z_A11_2"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[2]["BS"].ToString(); 
            }
            //处理量
            bookmark = doc.Range.Bookmarks["Z_A11_3"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[3]["BS"].ToString(); 
            }

            bookmark = doc.Range.Bookmarks["I_41_1"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[3]["BS"].ToString();
            }

            //结构
            bookmark = doc.Range.Bookmarks["Z_A11_4"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[19]["BS"].ToString(); 
            }
            //处理量
            bookmark = doc.Range.Bookmarks["Z_A13_1"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[3]["BS"].ToString(); 
            }
            //出水水质1
            bookmark = doc.Range.Bookmarks["Z_A14_1"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[25]["BS"].ToString();
            }
            //出水水质2
            bookmark = doc.Range.Bookmarks["Z_A14_2"];
            if (bookmark != null)
            {
                if (dt1.Rows[26]["BS"].ToString() != null)
                {
                    bookmark.Text = "中\"" + dt1.Rows[26]["BS"].ToString() + "\"";
                }
            }
            //出水COD
            bookmark = doc.Range.Bookmarks["Z_A14_B_21"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[6]["BS"].ToString();
            }
            //出水BOD5
            bookmark = doc.Range.Bookmarks["Z_A14_B_22"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[7]["BS"].ToString();
            }
            //出水SS
            bookmark = doc.Range.Bookmarks["Z_A14_B_23"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[8]["BS"].ToString();
            }
            //出水总氮
            bookmark = doc.Range.Bookmarks["Z_A14_B_24"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[9]["BS"].ToString();
            }
            //出水氨氮（NH3-N）
            bookmark = doc.Range.Bookmarks["Z_A14_B_25"];
            if (bookmark != null)
            {
                bookmark.Text = dt1.Rows[10]["BS"].ToString();
            }





            #endregion

            //doc.Save("testAdvice.doc", Aspose.Words.ContentDisposition.Attachment,Aspose.Words.Saving.SaveOptions.CreateSaveOptions(Aspose.Words.SaveFormat.Doc));


        }

        /// <summary>
        /// 单位级数据传输
        /// </summary>
        public void ExpWD2(System.Data.DataTable dt2)
        {
            DataTable dtx = DataTableHelper.CreateTable("BH,SJCS,DW,SZ");
            dtx.Rows.Add(new object[] {  "设计参数", "单位", "数值"});
            dtx.Rows.Add(new object[] { "调节池池停留时间", "h", Convert.ToDouble(dt2.Rows[0][2].ToString()).ToString("0.00") });
            dtx.Rows.Add(new object[] { "调节池有效容积", "m³", Convert.ToDouble(dt2.Rows[1][2].ToString()).ToString("0.00") });
            if (Convert.ToDouble(dt2.Rows[2][2].ToString()).ToString("0.00") != "0.00")
            {
                dtx.Rows.Add(new object[] { "缺氧池停留时间", "h", Convert.ToDouble(dt2.Rows[2][2].ToString()).ToString("0.00") });
                dtx.Rows.Add(new object[] { "缺氧池有效容积", "m³", Convert.ToDouble(dt2.Rows[3][2].ToString()).ToString("0.00") });
            }

            dtx.Rows.Add(new object[] {  "好氧MBR池停留时间", "h", Convert.ToDouble(dt2.Rows[4][2].ToString()).ToString("0.00") });
            dtx.Rows.Add(new object[] { "好氧MBR池有效容积", "m³", Convert.ToDouble(dt2.Rows[5][2].ToString()).ToString("0.00") });
            dtx.Rows.Add(new object[] { "设备机房尺寸", "m", dt2.Rows[6][2].ToString() });
            SCTable(dtx, "Z_B_41");

            bookmark = doc.Range.Bookmarks["Z_A42_1"];//缺氧池停留时间
                if (bookmark != null)
                {
                    bookmark.Text = dt2.Rows[6][2].ToString();
                }

            if (Convert.ToDouble(dt2.Rows[2][2].ToString()).ToString("0.00") != "0.00")
            {
                bookmark = doc.Range.Bookmarks["Z_A22_1"];//缺氧池停留时间
                if (bookmark != null)
                {
                    //\r\n
                    bookmark.Text =
                      //  "有缺氧池的工艺\r\n" +
                        "调节池：均匀水质和水量，抵御水质、水量对处理设备造成的冲击负荷；\r\n" +
                        "缺氧池：在缺氧生物反应器中，将回流混合液中的硝酸盐反硝化为氮气，实现总氮脱除；" +
                        "好氧MBR池：通过微生物代谢活动，去除水中有机污染物；设置曝气管，除了供给微生物活动所需要的氧气，还对膜面进行冲刷，有效控制膜污染；通过回流和加药去除水中的氮和磷；\r\n" +
                        "平板膜组件：进行分离作用，去除悬浮颗粒物、病菌等有害微生物；\r\n" +
                        "化学清洗系统：当平板膜组件受到污染时对其进行在线化学清洗；\r\n" +
                        "除磷加药系统（如有）：通过药剂的加入去除水中的磷；\r\n" +
                        "MSTD池：污泥同步浓缩消化池，通过曝气使池内的部分污泥好氧消化，实现减量化，同时经高效膜过滤降低污泥的含水率实现污泥快速浓缩。\r\n";
                }
            }
            else {
                bookmark = doc.Range.Bookmarks["Z_A22_1"];//缺氧池停留时间
                if (bookmark != null)
                {
                    bookmark.Text =
                       // "无缺氧池的工艺\r\n" +
                        "调节池：均匀水质和水量，抵御水质、水量对处理设备造成的冲击负荷；\r\n" +
                        "好氧MBR池：通过微生物代谢活动，去除水中有机污染物；设置曝气管，除供给微生物活动所需要的氧气，还对膜面进行冲刷，有效控制膜污染；\r\n" +
                        "平板膜组件：进行分离作用，去除悬浮颗粒物、病菌等有害微生物；\r\n" +
                        "化学清洗系统：当平板膜组件受到污染时对其进行在线化学清洗；\r\n" +
                        "除磷加药系统（如有）：通过药剂的加入去除水中的磷；\r\n" +
                        "MSTD池：污泥同步浓缩消化池，通过曝气使池内的部分污泥好氧消化，实现减量化，同时经高效膜过滤降低污泥的含水率实现污泥快速浓缩加药。\r\n";
                }
            }
            string str = "";
            /*
            string str = "";
            bookmark = doc.Range.Bookmarks["Z_A41_B_13"]; //调节池池停留时间
            if (bookmark != null)
            {
                str = dt2.Rows[0][2].ToString();
                bookmark.Text = str;
            }
            bookmark = doc.Range.Bookmarks["Z_A41_B_23"]; //调节池有效容积
            if (bookmark != null)
            {
                str = dt2.Rows[1][2].ToString();
                bookmark.Text = Convert.ToDouble(str).ToString("0.00"); 
            }
            bookmark = doc.Range.Bookmarks["Z_A41_B_33"];//缺氧池停留时间
            if (bookmark != null)
            {
                str = dt2.Rows[2][2].ToString();
                bookmark.Text = Convert.ToDouble(str).ToString("0.00"); 
            }
            bookmark = doc.Range.Bookmarks["Z_A41_B_43"]; //缺氧池有效容积
            if (bookmark != null)
            {
                str = dt2.Rows[3][2].ToString();
                bookmark.Text = Convert.ToDouble(str).ToString("0.00"); 
            }
            bookmark = doc.Range.Bookmarks["Z_A41_B_53"];//好氧MBR池停留时间
            if (bookmark != null)
            {
                str = dt2.Rows[4][2].ToString();
                bookmark.Text = Convert.ToDouble(str).ToString("0.00"); 
            }
            bookmark = doc.Range.Bookmarks["Z_A41_B_63"];//好氧MBR池有效容积
            if (bookmark != null)
            {
                str = dt2.Rows[5][2].ToString();
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            */
            //Z_A41_B_73设备机房尺寸

            //-----------------------------------------
            bookmark = doc.Range.Bookmarks["Z_A62_1"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D25' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A62_2"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D25' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = (Convert.ToDouble(str)*1.8).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A62_3"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D25' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = ((Convert.ToDouble(str) * 1.8) / (Convert.ToDouble(dt2.Select("BY1='D25' AND TYPE='JS'")[0][2].ToString()))).ToString("0.00");
            }



            bookmark = doc.Range.Bookmarks["Z_A42_B_13"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D42' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A42_B_23"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D19' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A42_B_33"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D16' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A42_B_43"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D17' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A42_B_53"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='I9' AND TYPE='JS'")[0][2].ToString();//替换I10
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A42_B_63"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D25' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A42_B_73"];
            if (bookmark != null)
            {
                str = dt2.Select("BY1='D34' AND TYPE='JS'")[0][2].ToString();//回流比
                bookmark.Text = Convert.ToDouble(str).ToString("0.00");
            }
            //Z_A42_B_13














        }

        /// <summary>
        /// 设计参数
        /// </summary>
        public void ExpWD3(System.Data.DataTable dt3)
        {
            #region //添加表格4.3
            try{
            builder = new Aspose.Words.DocumentBuilder(doc);
            builder.MoveToBookmark("Z_A43_B_1");  
             for (var i = 0; i < dt3.Rows.Count; i++)
                {
                    for (var j = 0; j < dt3.Columns.Count-1; j++)
                    {
                        builder.InsertCell();// 添加一个单元格                    
                        //builder.CellFormat.Borders.LineStyle = LineStyle.Single;
                        //builder.CellFormat.Borders.LineWidth = 2;
                        if(i==0)
                        {
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Top.LineWidth = 2;

                        }else if (i == dt3.Rows.Count-1)
                        {
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Bottom.LineWidth = 2;
                        }else{
                            builder.CellFormat.Borders.LineWidth = 1;
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;     
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                            
                            
                        }
                        if (j == 0)
                        {
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;

                        }
                        else if (j == dt3.Columns.Count - 2)
                        {
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                        }
                        else
                        {
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                        }

                        
                        builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
                        builder.CellFormat.Width = 100;
                        builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                        builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;//垂直居中对齐
                        builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//水平居中对齐
                        if (j == 0) { builder.CellFormat.Width = 60; }
                        else if (j == 1) { builder.CellFormat.Width = 120; }
                        else if (j == 2) { builder.CellFormat.Width = 120; }
                        else if (j == 3) { builder.CellFormat.Width = 80; }
                        else if (j == 4) { builder.CellFormat.Width = 80; }
                        else if (j == 5) { builder.CellFormat.Width = 100; }
                        builder.Write(dt3.Rows[i][j].ToString());


                    }
                        

                    builder.EndRow();
                }
            //    doc.Range.Bookmarks["cs"].Text = "";    // 清掉标示  
            }
            catch (Exception e)
            { 
                MessageUtil.ShowWarning(e.Message.ToString());
            }
        #endregion
        }

        /// <summary>
        /// 负荷参数
        /// </summary>
        public void ExpWD4(System.Data.DataTable dt)
        {
            #region //表格4.2
            try
            {
                builder = new Aspose.Words.DocumentBuilder(doc);
                builder.MoveToBookmark("Z_A42_B_1");        //开始添加值
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    for (var j = 0; j < dt.Columns.Count - 1; j++)
                    {
                        builder.InsertCell();// 添加一个单元格                    
                        //builder.CellFormat.Borders.LineStyle = LineStyle.Single;
                        //builder.CellFormat.Borders.LineWidth = 2;

                        if (i == 0)
                        {
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Top.LineWidth = 2;
                         //   builder.Font.Subscript = true;

                        }
                        else if (i == dt.Rows.Count - 1)
                        {
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Bottom.LineWidth = 2;
                        }
                        else
                        {
                            builder.CellFormat.Borders.LineWidth = 1;
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;


                        }
                        if (j == 0)
                        {
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;

                        }
                        else if (j == dt.Columns.Count - 2)
                        {
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                        }
                        else
                        {
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                        }


                        builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
                        builder.CellFormat.Width = 100;
                        builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                        builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;//垂直居中对齐
                        builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//水平居中对齐
                        if (j == 0) { builder.CellFormat.Width = 60; }
                        else if (j == 1) { builder.CellFormat.Width = 120; }
                        else if (j == 2) { builder.CellFormat.Width = 120; }
                        else if (j == 3) { builder.CellFormat.Width = 80; }
                        else if (j == 4) { builder.CellFormat.Width = 80; }
                        else if (j == 5) { builder.CellFormat.Width = 100; }
                        builder.Write(dt.Rows[i][j].ToString().Replace("(B1)", "").Replace("(B2)", "").Replace("(B3)", "").Replace("(B4)", "").Replace("(L1)", "").Replace("(L2)", "").Replace("(L3)", "").Replace("(L4)", ""));


                    }
                    builder.EndRow();
                }
                if( Convert.ToDouble(dt.Rows[2][2].ToString()).ToString("0.00") == "0.00")
                { 
                 builder.MoveToBookmark("BZ1");
                 Row row = (Row)builder.CurrentNode.GetAncestor(NodeType.Row);
                 if (row != null) row.Remove();
                }
            }
            catch (Exception e)
            {
                MessageUtil.ShowWarning(e.Message.ToString());
            }
            #endregion
        }

        /// <summary>
        /// 经济指标/报价取值
        /// </summary>
        public void ExpWD5(System.Data.DataTable dt5)
        {
            DataView dv10 = dt5.DefaultView;
            dv10.RowFilter = "TYPE='10'";
            DataTable dt10 = dv10.ToTable();

            DataView dv11 = dt5.DefaultView;
            dv11.RowFilter = "TYPE='11'";
            DataTable dt11 = dv11.ToTable();

            bookmark = doc.Range.Bookmarks["Z_A42_2"];
            if (bookmark != null)
            {
                bookmark.Text = dt11.Rows[1][2].ToString();
            }
            bookmark = doc.Range.Bookmarks["Z_A42_3"];
            if (bookmark != null)
            {
                bookmark.Text = dt11.Rows[1][3].ToString();
            }
            //--------------------------前言部分
            bookmark = doc.Range.Bookmarks["Z_A0_7"]; //污水处理设备
            if (bookmark != null)
            {
                bookmark.Text = dt11.Rows[1][2].ToString();
            }
            bookmark = doc.Range.Bookmarks["Z_A0_8"];//吨水占地面积
            if (bookmark != null)
            {
                bookmark.Text = dt11.Rows[1][3].ToString();
            }
            bookmark = doc.Range.Bookmarks["Z_A0_9"];//吨水运行费用平均
            if (bookmark != null)
            {
                bookmark.Text = (double.Parse(dt11.Rows[4][3].ToString()) +double.Parse(dt11.Rows[6][3].ToString())).ToString("0.00");
            }
            bookmark = doc.Range.Bookmarks["Z_A0_A1"];//吨水运行能耗
            if (bookmark != null)
            {
                bookmark.Text = dt11.Rows[2][3].ToString();
            }
            bookmark = doc.Range.Bookmarks["Z_A0_A2"];//吨水投资
            if (bookmark != null)
            {
                bookmark.Text = dt11.Rows[0][3].ToString();
            }
            bookmark = doc.Range.Bookmarks["Z_A0_A3"];//总投资
            if (bookmark != null)
            {
                bookmark.Text = dt11.Rows[0][2].ToString();
            }
        }

        public void ExpWD6(System.Data.DataTable dt6)
        {
            builder = new Aspose.Words.DocumentBuilder(doc);



            bookmark = doc.Range.Bookmarks["Z_A50_1"];
            if (bookmark != null)
            {
                bookmark.Text = dt6.Rows[20][6].ToString();
            }

            builder.MoveToBookmark("Z_A51_B_1");
            for (var i = 0; i < dt6.Rows.Count; i++)
            {
                for (var j = 0; j < dt6.Columns.Count - 1; j++)
                {
                    builder.InsertCell();   
                    if (i == 0)
                    {
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Top.LineWidth = 2;

                    }
                    else if (i == dt6.Rows.Count - 1)
                    {
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Bottom.LineWidth = 2;
                    }
                    else
                    {
                        builder.CellFormat.Borders.LineWidth = 1;
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;


                    }
                    if (j == 0)
                    {
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;

                    }
                    else if (j == dt6.Columns.Count - 2)
                    {
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                    }
                    else
                    {
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                    }

                    //单元格合并
                    /*
                    if ((i >= 3 &&i <= 4) && j == 0)
                    {
                        if (i == 3) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 5 && i <=8) && j == 0) 
                    {
                        if (i == 5) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 9 && i <= 11) && j == 0)
                    {
                        if (i == 9) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 12 && i <= 13) && j == 0)
                    {
                        if (i == 12) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 18 && i <= 19) && j == 0)
                    {
                        if (i == 18) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else
                    {
                        builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                    }
                    */

                    builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                    builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
                    builder.CellFormat.Width = 100;
                    builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;//垂直居中对齐
                    builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//水平居中对齐

                    if (j == 0) { builder.CellFormat.Width = 60; }
                    else if (j == 1) { builder.CellFormat.Width = 120; }
                    else if (j == 2) { builder.CellFormat.Width = 120; }
                    else if (j == 3) { builder.CellFormat.Width = 80; }
                    else if (j == 4) { builder.CellFormat.Width = 80; }
                    else if (j == 5) { builder.CellFormat.Width = 100; }
                    else if (j == 5) { builder.CellFormat.Width = 100; }
                    else if (j == 5) { builder.CellFormat.Width = 80; }
                    builder.Write(dt6.Rows[i][j].ToString());
                }


                builder.EndRow();
            }

            /*
            builder.MoveToBookmark("Z_A51_B_1");
            Aspose.Words.Tables.Table table = (Aspose.Words.Tables.Table)doc.GetChild(NodeType.Table, 0, true);
            int i = 0;
            if (dt6.Rows.Count > 0)
            {
                builder.InsertCell();
                builder.CellFormat.Borders.LineStyle = LineStyle.Single;
                builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
                builder.CellFormat.VerticalMerge = CellMerge.None;
                builder.Write("Text in one cell");
                builder.EndRow();

                //设置单元格属性，合并单元格
                table.Rows[4].Cells[0].CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.First;
                for (int j = 0; j < dt6.Rows.Count - 1; j++)
                {
                    Aspose.Words.Tables.Row beforeRow = table.Rows[i++];
                    Aspose.Words.Tables.Row clonedRow = (Aspose.Words.Tables.Row)beforeRow.Clone(true);
                    table.InsertAfter(clonedRow, beforeRow);//插入到指定位置下面
                    DataRow dr = dt6.Rows[j];
                    //修改上行内容
                    builder.MoveToCell(0, i - 1, 1, 0);
                    builder.Write(dr[1].ToString());
                    //设置合并内容
               //     builder.MoveToCell(0, i, 0, 0);
                    builder.CellFormat.WrapText = true;
                    //合并单元格
                    clonedRow.Cells[0].CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.Previous;
                }

                builder.MoveToCell(0, i, 1, 0);
                builder.Write(dt6.Rows[dt6.Rows.Count - 1][1].ToString());
            }
             * */
        }

        public void ExpWD7(System.Data.DataTable dt7)
        {
            builder = new Aspose.Words.DocumentBuilder(doc);
            builder.MoveToBookmark("Z_A61_B_1");
            for (var i = 0; i < dt7.Rows.Count; i++)
            {
                for (var j = 0; j < dt7.Columns.Count - 1; j++)
                {
                    builder.InsertCell();
                    if (i == 0)
                    {
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Top.LineWidth = 2;

                    }
                    else if (i == dt7.Rows.Count - 1)
                    {
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Bottom.LineWidth = 2;
                    }
                    else
                    {
                        builder.CellFormat.Borders.LineWidth = 1;
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;


                    }
                    if (j == 0)
                    {
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;

                    }
                    else if (j == dt7.Columns.Count - 2)
                    {
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                    }
                    else
                    {
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                    }

                    //单元格合并
                    /*
                    if ((i >= 3 &&i <= 4) && j == 0)
                    {
                        if (i == 3) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 5 && i <=8) && j == 0) 
                    {
                        if (i == 5) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 9 && i <= 11) && j == 0)
                    {
                        if (i == 9) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 12 && i <= 13) && j == 0)
                    {
                        if (i == 12) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 18 && i <= 19) && j == 0)
                    {
                        if (i == 18) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else
                    {
                        builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                    }
                    */

                    builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                    builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
                    builder.CellFormat.Width = 100;
                    builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;//垂直居中对齐
                    builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//水平居中对齐

                    if (j == 0) { builder.CellFormat.Width = 60; }
                    else if (j == 1) { builder.CellFormat.Width = 120; }
                    else if (j == 2) { builder.CellFormat.Width = 120; }
                    else if (j == 3) { builder.CellFormat.Width = 80; }
                    else if (j == 4) { builder.CellFormat.Width = 80; }
                    else if (j == 5) { builder.CellFormat.Width = 100; }
                    else if (j == 6) { builder.CellFormat.Width = 100; }
                    else if (j == 7) { builder.CellFormat.Width = 80; }
                    else if (j == 8) { builder.CellFormat.Width = 80; }
                    builder.Write(dt7.Rows[i][j].ToString());
                    
                }


                builder.EndRow();

            }
        }

        public void ExpWD8(System.Data.DataTable dt8)
        {

            builder = new Aspose.Words.DocumentBuilder(doc);

            builder.MoveToBookmark("Z_A62_B_1");
            for (var i = 0; i < dt8.Rows.Count; i++)
            {
                for (var j = 0; j < dt8.Columns.Count - 1; j++)
                {
                    builder.InsertCell();
                    if (i == 0)
                    {
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Top.LineWidth = 2;

                    }
                    else if (i == dt8.Rows.Count - 1)
                    {
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                        builder.CellFormat.Borders.Bottom.LineWidth = 2;
                    }
                    else
                    {
                        builder.CellFormat.Borders.LineWidth = 1;
                        builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;


                    }
                    if (j == 0)
                    {
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;

                    }
                    else if (j == dt8.Columns.Count - 2)
                    {
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                    }
                    else
                    {
                        builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                        builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                    }

                    //单元格合并
                    
                    if ((i >= 4 &&i <= 5) && (j == 0||j==1))
                    {
                        if (i == 4) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 6 && i <= 7) && (j == 0 || j == 1)) 
                    {
                        if (i == 6) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else if ((i >= 8 && i <= 13) && (j == 0 || j == 1))
                    {
                        if (i == 8) { builder.CellFormat.VerticalMerge = CellMerge.First; } else { builder.CellFormat.VerticalMerge = CellMerge.Previous; }
                    }
                    else
                    {
                        builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                    }
                    

         //           builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                    builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
                    builder.CellFormat.Width = 100;
                    builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;//垂直居中对齐
                    builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//水平居中对齐

                    if (j == 0) { builder.CellFormat.Width = 60; }
                    else if (j == 1) { builder.CellFormat.Width = 120; }
                    else if (j == 2) { builder.CellFormat.Width = 120; }
                    else if (j == 3) { builder.CellFormat.Width = 80; }
                    else if (j == 4) { builder.CellFormat.Width = 80; }
                    else if (j == 5) { builder.CellFormat.Width = 100; }
                    else if (j == 6) { builder.CellFormat.Width = 100; }
                    else if (j == 7) { builder.CellFormat.Width = 80; }
                    else if (j == 8) { builder.CellFormat.Width = 80; }
                    builder.Write(dt8.Rows[i][j].ToString());

                }


                builder.EndRow();

                
            }
            bookmark = doc.Range.Bookmarks["Z_A62_4"];
            bookmark.Text = dt8.Rows[6][3].ToString();
        }

        public void ExpWD9(System.Data.DataTable dt)
        { }

        public void ExpWD10(System.Data.DataTable dt)
        { }

        public void ExpWD11(System.Data.DataTable dt)
        { }

        public void ExpWD12(System.Data.DataTable dt)
        {
            #region //图片插入
            builder = new Aspose.Words.DocumentBuilder(doc);

            Shape shape = new Shape(doc, ShapeType.Image);
            shape.ImageData.SetImage("D:\\sw\\2010\\[Beautyleg]2010.06.18 No.414 Avy[73P]\\60.jpg");
            shape.Width = 850;
            shape.Height = 290;
            shape.HorizontalAlignment = HorizontalAlignment.Center; //靠右对齐
            if (doc.Range.Bookmarks["Z_IMG_24"] != null)
            {
                builder.MoveToBookmark("Z_IMG_24");
             //   builder.InsertImage("D:\\sw\\2010\\[Beautyleg]2010.06.18 No.414 Avy[73P]\\60.jpg", 550, 250);
                builder.InsertImage(dt.Rows[0][2].ToString(), 450, 200);
               // doc.Range.Bookmarks["Z_IMG_24"].Text = "";

               
            }
            if (doc.Range.Bookmarks["Z_IMG_41"] != null)
            {
                
                builder.MoveToBookmark("Z_IMG_41");
               // builder.InsertNode(shape);
             //   builder.InsertImage("D:\\sw\\2010\\[Beautyleg]2010.06.18 No.414 Avy[73P]\\60.jpg",550,250);
                builder.InsertImage(dt.Rows[1][2].ToString(), 450, 200);
               // doc.Range.Bookmarks["Z_IMG_41"].Text = "";

            }
            #endregion
        }


        //把数字转换为大写
        public string numtoUpper(int num)
        {
            String str=num.ToString();
            string rstr = "";
            int n;
            for (int i = 0; i < str.Length; i++) 
            {
                n =Convert.ToInt16(str[i].ToString());//char转数字,转换为字符串，再转数字
                switch (n) 
                {
                    case 0:rstr=rstr+"〇";break;
                    case 1:rstr=rstr+"一";break;
                    case 2:rstr=rstr+"二";break;
                    case 3:rstr=rstr+"三";break;
                    case 4:rstr=rstr+"四";break;
                    case 5:rstr=rstr+"五";break;
                    case 6:rstr=rstr+"六";break;
                    case 7:rstr=rstr+"七";break;
                    case 8:rstr=rstr+"八";break;
                    default:rstr=rstr+"九";break;
                        

                }

            }
            return rstr;
        }
        //月转化为大写
        public string monthtoUpper(int month)
        {
            if (month < 10)
            {
                return numtoUpper(month);
            }
            else
                if (month == 10) { return "十"; }

                else
                {
                    return "十" + numtoUpper(month - 10);
                }
        }
        //日转化为大写
        public string daytoUpper(int day)
        {
            if (day < 20)
            {
                return monthtoUpper(day);
            }
            else
            {
                String str = day.ToString();
                if (str[1] == '0')
                {
                    return numtoUpper(Convert.ToInt16(str[0].ToString()))+"十" ;
 
                }
               

                else
                {
                    return numtoUpper(Convert.ToInt16(str[0].ToString())) + "十" 
                        + numtoUpper(Convert.ToInt16(str[1].ToString())); 
                }
            }
        }
        //日期转换为大写
        public string  dateToUpper(System.DateTime date)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            return numtoUpper(year) + "年" + monthtoUpper(month) + "月" + daytoUpper(day) + "日";

        }
        public void AsposeCreateCell(Aspose.Words.DocumentBuilder builder, double width, string text)
        {
            builder.InsertCell();
            builder.CellFormat.Borders.LineStyle = Aspose.Words.LineStyle.Single;
            builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
            builder.CellFormat.Width = width;//单元格的宽度
            builder.CellFormat.LeftPadding = 3;//单元格的左内边距
            builder.CellFormat.RightPadding = 3;//单元格的右内边距
            builder.RowFormat.Height = 20;//行高
            builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
            builder.CellFormat.VerticalAlignment = Aspose.Words.Tables.CellVerticalAlignment.Center;//垂直居中对齐
            builder.ParagraphFormat.Alignment = Aspose.Words.ParagraphAlignment.Center;//水平居中对齐
            builder.Write(text);
        }

        public void SCTable(DataTable dx, string sq)
        {
            #region 
            try
            {
                builder = new Aspose.Words.DocumentBuilder(doc);
                builder.MoveToBookmark(sq);
                for (var i = 0; i < dx.Rows.Count; i++)
                {
                    for (var j = 0; j < dx.Columns.Count - 1; j++)
                    {
                        builder.InsertCell();// 添加一个单元格                    
                        //builder.CellFormat.Borders.LineStyle = LineStyle.Single;
                        //builder.CellFormat.Borders.LineWidth = 2;
                        if (i == 0)
                        {
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Top.LineWidth = 2;

                        }
                        else if (i == dx.Rows.Count - 1)
                        {
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                            builder.CellFormat.Borders.Bottom.LineWidth = 2;
                        }
                        else
                        {
                            builder.CellFormat.Borders.LineWidth = 1;
                            builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;


                        }
                        if (j == 0)
                        {
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.None;

                        }
                        else if (j == dx.Columns.Count - 2)
                        {
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.None;
                        }
                        else
                        {
                        //    builder.CellFormat.Borders.LineWidth = 1;
                       //     builder.CellFormat.Borders.Top.LineStyle = LineStyle.Single;
                       //     builder.CellFormat.Borders.Bottom.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Left.LineStyle = LineStyle.Single;
                            builder.CellFormat.Borders.Right.LineStyle = LineStyle.Single;
                        }


                        builder.CellFormat.Borders.Color = System.Drawing.Color.Black;
                        builder.CellFormat.Width = 100;
                        builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;
                        builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;//垂直居中对齐
                        builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//水平居中对齐
                        if (j == 0) { builder.CellFormat.Width = 60; }
                        else if (j == 1) { builder.CellFormat.Width = 120; }
                        else if (j == 2) { builder.CellFormat.Width = 120; }
                        else if (j == 3) { builder.CellFormat.Width = 80; }
                        else if (j == 4) { builder.CellFormat.Width = 80; }
                        else if (j == 5) { builder.CellFormat.Width = 100; }
                        builder.Write(dx.Rows[i][j].ToString());
                    }


                    builder.EndRow();
                }
                //    doc.Range.Bookmarks["cs"].Text = "";    // 清掉标示  
            }
            catch (Exception e)
            {
                MessageUtil.ShowWarning(e.Message.ToString());
            }
            #endregion
        }
    }
   
}
