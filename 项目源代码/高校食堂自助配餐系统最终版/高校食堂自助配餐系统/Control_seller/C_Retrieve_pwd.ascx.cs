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
    public partial class Retrieve_pwd : System.Web.UI.UserControl
    {
        SellService sell = new SellService();
        buyerIntSer buyer = new buyerIntSer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Sumbit_Click(object sender, EventArgs e)
        {
            if (Session["UserType"] == "1")
            {
                Label1.Text = sell.show(txtSell_Account.Text.Trim());
                Response.Write("账号验证成功，请回答密码问题！");
            }
            else
            {
                Label1.Text = buyer.ShowQuestion(txtSell_Account.Text.Trim());
            }
        }

        protected void btn_Ensure_Click(object sender, EventArgs e)
        {
             if(Session["UserType"] == "1")
             {
                 if (sell.check(txtSell_Account.Text, Label1.Text, txtSell_Answer.Text))
                 {
                     Response.Redirect("../seller/Modify.aspx");
                 }
                 else
                 {
                     Response.Write(MessagesBox.showMessages("回答错误，请重新回答。"));
                 }
             }
             else
             {
                 if (buyer.ShowAnswer(txtSell_Account.Text)==txtSell_Answer.Text)
                 {
                     Response.Redirect("../buyer/Modify.aspx");
                 }
                 else
                 {
                     Response.Write(MessagesBox.showMessages("回答错误，请重新回答。"));
                 }
             }    
        }
    }
}