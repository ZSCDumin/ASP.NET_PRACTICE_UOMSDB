using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;
using Entity;

namespace 高校食堂自助配餐系统.Control_seller
{
    public partial class Modify : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Session["UserType"].ToString().Trim() == "0")
            {
                buyerIntSer buyer = new buyerIntSer();
                buyer.Updatepassword(Session["UserAccount"].ToString().Trim(), txtSell_password.Text.Trim());
                Response.Write(MessagesBox.showMessages("修改成功!"));
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                SellService a = new SellService();
                a.change(Session["UserAccount"].ToString().Trim(), txtSell_password.Text.Trim());
                Response.Write(MessagesBox.showMessages("修改成功!"));
                Response.Redirect("~/Default.aspx");
            }
            
        }
    }
}