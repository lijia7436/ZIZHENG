using System;
using System.Collections.Generic;
using System.Data;

using System.Text;

namespace ZIZHENG
{
    class DTset
    {
        public DataTable FDT(string name)
        {
            DataTable dt = new DataTable(name);
            dt.Columns.Add("col0", System.Type.GetType("System.String"));
            dt.Columns.Add("col1", System.Type.GetType("System.String"));
            DataRow dr = dt.NewRow();
            dr["col0"] = "AX";
            dr["col1"] = "";
            return dt;
        }
        public DataTable dtadd(string name)
        {
            DataTable dt = new DataTable(name);
            dt.Columns.Add("col0", System.Type.GetType("System.String"));
            dt.Columns.Add("col1", System.Type.GetType("System.String"));
            DataRow dr = dt.NewRow();
            dr["col0"] = "AX";
            dr["col1"] = "";
            return dt;
        }
    }
}
