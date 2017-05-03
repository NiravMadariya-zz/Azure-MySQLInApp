using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Azure_MySQLInApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn_str = Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb").ToString();
            connStrToArray(conn_str);
        }

        public void connStrToArray(string connStr)
        {
            string[] connArray = Regex.Split(connStr, ";");
            string[] connArray2 = new string[] { };
            string[] keyArray = new string[] { "Database", "Data Source", "User ID", "Password" };
            for (int i = 0; i < connArray.Length; i++)
            {
                Response.Write(keyArray[i] + ":" + connArray[i].Substring(connArray[i].IndexOf("=") + 1).ToString() + "<br />");
            }
        }
    }
}