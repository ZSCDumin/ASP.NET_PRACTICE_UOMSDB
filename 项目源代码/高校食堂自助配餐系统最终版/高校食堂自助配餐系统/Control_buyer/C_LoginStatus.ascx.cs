using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class C_LoginStatus : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] != null)
            {
               
               Label1.Text = "<div style=\"font-size:20px;\">" + "您好：" + Session["UserAccount"].ToString() + "</div>";
            }
        }
    }
}