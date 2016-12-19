using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;

namespace 高校食堂自助配餐系统
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtAccount.Text=="admin"&&txtPassword.Text=="admin")
            {
                Response.Write(MessagesBox.showMessages("登录成功！"));
                Response.Redirect("~/Administrator/AdminManage.aspx");
            }
            else
            {
                Response.Write(MessagesBox.showMessages("登录失败！"));
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";//清空账号
            txtPassword.Text = "";//清空密码
        }
    }
}