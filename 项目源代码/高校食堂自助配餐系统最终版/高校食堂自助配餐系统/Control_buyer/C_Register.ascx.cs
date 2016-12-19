using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using InterService;

namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class C_Register : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            buyerIntSer buyer = new buyerIntSer();

            bool b = buyer.BuyerReg(txtSell_Account.Text.Trim(), txtSell_password.Text.Trim(), txtSell_Name.Text.Trim(),

            txtSell_tel.Text.Trim(), ddlQuestion.SelectedItem.Value, txtSell_answer.Text.Trim(), txtSell_mail.Text.Trim());

            if (!b)
            {
                Response.Write(MessagesBox.showMessages("注册成功"));
                Response.Redirect("~/Default.aspx");
            }

            else
            {
                Response.Write(MessagesBox.showMessages("账号已存在，请重新输入"));
            }
        }
    }
}