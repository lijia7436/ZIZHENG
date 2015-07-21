using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Web;
using System.Reflection;
//using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
/*
 * 开发人员：Hisen
 * 时间：2008年11月24日
 * 功能：将数据导出Excel 
 * 
 */
namespace ZIZHENG
{
    public class ExcelExport
    {
        /*
        public bool ExportExcel(System.Data.DataTable dt, string url)
        {
            bool flag = false;
            Microsoft.Office.Interop.Excel.Application objExcel = null;
            Workbook objWorkbook = null;
            Worksheet objsheet = null;
            try
            {
                //申明对象
                objExcel = new Microsoft.Office.Interop.Excel.Application();
                objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                objsheet = (Worksheet)objWorkbook.ActiveSheet;

                //设置Excel不可见
                objExcel.Visible = false;
                objExcel.DisplayAlerts = false;

                //设置Excel字段类型全部为字符串
                objsheet.Cells.NumberFormat = "@";

                //向Excel中写入表格的标头
                int displayColumnsCount = 1;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    objExcel.Cells[1, displayColumnsCount] = dt.Columns[i].ColumnName.Trim();
                    displayColumnsCount++;
                }
                //向Excel中逐行逐列写入表格中的数据
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    displayColumnsCount = 1;
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        try
                        {
                            objExcel.Cells[row + 2, displayColumnsCount] = dt.Rows[row][col].ToString().Trim();
                            displayColumnsCount++;
                        }
                        catch (Exception)
                        { }
                    }
                }
                //保存文件
                objWorkbook.SaveAs(
                    url, Missing.Value, 
                    Missing.Value, 
                    Missing.Value, 
                    Missing.Value, 
                    Missing.Value, 
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
                
                System.Windows.Forms.MessageBox.Show(
                    ex.Message, "温馨提示", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Information);
            }
            finally
            {
                //关闭Excel应用
                if (objWorkbook != null) objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);
                if (objExcel.Workbooks != null) objExcel.Workbooks.Close();
                if (objExcel != null) objExcel.Quit();

                //杀死进程
                KillProcess("Excel");
                objsheet = null;
                objWorkbook = null;
                objExcel = null;
            }
            return flag;
        }

        /// <summary>
        /// 根据进程名称杀死进程 
        /// </summary>
        /// <param name=" ProcessName "> DataTable</param>
        public void KillProcess(string ProcessName)
        {
            System.Diagnostics.Process myproc = new System.Diagnostics.Process();
            try
            {
                foreach (System.Diagnostics.Process thisproc in System.Diagnostics.Process.GetProcessesByName(ProcessName))
                {
                    if (!thisproc.CloseMainWindow())
                    {
                        thisproc.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }

        //------
        public static bool DataGridviewShowToExcel(DataGridView dgv, bool isShowExcle)
        {
            //申明保存对话框    
            SaveFileDialog dlg = new SaveFileDialog();
            //默然文件后缀    
            dlg.DefaultExt = "xls ";
            //文件后缀列表    
            dlg.Filter = "EXCEL文件(*.xls)|*.xls ";
            //默然路径是系统当前路径    
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            //打开保存对话框    
            if (dlg.ShowDialog() == DialogResult.Cancel) return false;
            //返回文件路径    
            string fileNameString = dlg.FileName;
            if (dgv.Rows.Count == 0)
                return false;
            //建立Excel对象    
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xBook = excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcle;
            //--------


            //--------

            //生成字段名称    
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                excel.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }
            //填充数据    
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv[j, i].ValueType == typeof(string))
                    {
                        excel.Cells[i + 2, j + 1] = "'" + dgv[j, i].Value.ToString();
                    }
                    else
                    {
                        excel.Cells[i + 2, j + 1] = dgv[j, i].Value.ToString();
                    }
                }
            }
            FileInfo file = new FileInfo(fileNameString);
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            xBook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            MessageBox.Show(fileNameString + "\n\n导出完毕! ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           // KillProcess("Excel");
            return true;
        }

        public static bool DataTableShowToExcel(System.Data.DataTable dt, bool isShowExcle)
        {
            //申明保存对话框    
            SaveFileDialog dlg = new SaveFileDialog();
            //默然文件后缀    
            dlg.DefaultExt = "xls ";
            //文件后缀列表    
            dlg.Filter = "EXCEL文件(*.xls)|*.xls ";
            //默然路径是系统当前路径    
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            //打开保存对话框    
            if (dlg.ShowDialog() == DialogResult.Cancel) return false;
            //返回文件路径    
            string fileNameString = dlg.FileName;
            if (dt.Rows.Count == 0)
                return false;
            //建立Excel对象    
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xBook = excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcle;
            //--------
            //生成字段名称  
            int displayColumnsCount = 1;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                excel.Cells[1, i + 1] = dt.Columns[i].ColumnName.Trim();
                displayColumnsCount++;
            }
            //向Excel中逐行逐列写入表格中的数据
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                displayColumnsCount = 1;
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    try
                    {
                        //if (dt.Rows[row][col]. == typeof(string))
                       // {
                            excel.Cells[row + 2, displayColumnsCount] = "'" + dt.Rows[row][col].ToString().Trim();
                       // }
                       // else
                       // {
                       //     excel.Cells[row + 2, displayColumnsCount] = dt.Rows[row][col].ToString().Trim();
                       // }
                        displayColumnsCount++;
                    }
                    catch (Exception)
                    { }
                }
            }

            //--------

            FileInfo file = new FileInfo(fileNameString);
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            xBook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            MessageBox.Show(fileNameString + "\n\n导出完毕! ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // KillProcess("Excel");
            return true;
        }
         */
    }
         
}