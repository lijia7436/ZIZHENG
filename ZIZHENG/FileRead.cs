using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;
using System.IO;
namespace ZIZHENG
{
    /// <summary>
    /// 许可证信息获取
    /// </summary>
    class FileRead
    {
        public string ReadData()
        {
            try {
                FileStream fs = new FileStream(Application.StartupPath + "/key.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = sr.ReadLine();
                
                sr.Close();
                fs.Close();
                return str;
            }
            catch {
                YZ y = new YZ();
                y.ShowDialog();
            }
            return "0";
        }
        public void WriterData(string i)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath+"/key.txt");
            
            sw.Write(i);
            sw.Close();
            MessageBox.Show("授权成功");
        }
    }
}