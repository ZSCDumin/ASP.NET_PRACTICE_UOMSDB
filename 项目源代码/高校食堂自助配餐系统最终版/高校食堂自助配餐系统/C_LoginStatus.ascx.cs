using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校食堂自助配餐系统
{
    public partial class C_LoginStatus : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] != null)
            {
                if(Session["UserType"].ToString()=="0")//买家
                {
                    lblAccount.Text = "<ul class=\"nav nav-tabs nav-justified\" ><li><a href=\"/buyer/showInformationOfBuyer.aspx\"> 您好：" +
                            Session["UserAccount"].ToString() + "</a></li><li><a href=\"Logout.aspx\">注销</a></li></ul>";
                }
                else
                {
                    lblAccount.Text = "<ul class=\"nav nav-tabs nav-justified\" ><li><a href=\"/seller/Information.aspx\">您好：" +
                        Session["UserAccount"].ToString() + "</a></li><li><a href=\"Logout.aspx\">注销</a></li></ul>";
                }
            }
            else
            {
                lblAccount.Text = "<ul class=\"nav nav-tabs nav-justified\" ><li><a href=\"login.aspx\" style=\"color:#000000\">登录</a></li> <li><a href=\"register.aspx\"  style=\"color:#000000\">注册</a></li><li><a href=\"registered.aspx\" style=\"color:#000000\">加盟</a></li></ul>";
            }
             
        }
    }
}