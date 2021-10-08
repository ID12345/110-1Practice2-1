using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_1
{
    public partial class BluePrint : System.Web.UI.Page
    {
        public class Man {
            public string s_Id;
            public float f_Hei;
            public float f Wei;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Man o Man = new Man();
            o Man.s_Id ="A123456789";
            o Man.f_Hei = 178.5f;
            o_Man.f_Wei = 72.8f;

            // s_Id = 值，千_Hei =•值，千_ wei =•值
            Response.Write("s_Id=" + 0_Man.S_Id + ", " +
            "f_Hei=" O_Man.F_Hei.ToString() + ", " +
            "F_Wei =" + 0_Man.f_Wei.ToString();
        }
    }
}