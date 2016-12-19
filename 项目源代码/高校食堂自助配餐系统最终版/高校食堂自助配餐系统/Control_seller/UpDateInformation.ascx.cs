using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using InterService;

namespace 高校食堂自助配餐系统.Control_seller
{
    public partial class UpDateInformation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            SellService db = new SellService();
            seller_Entity sell = new seller_Entity();
            string account = Session["UserAccount"].ToString().Trim();
            sell.S_account = account;
            sell.S_name = txt_s_name.Text.Trim();
            sell.S_storeName = txt_s_storename.Text.Trim();
            sell.S_tel = txt_s_tel.Text.Trim();
            sell.S_question = ddl_s_question.Text.Trim();
            sell.S_answer = txt_s_answer.Text.Trim();
            if (db.changeUserInfo(sell))
            {
                Response.Write(MessagesBox.showMessages("用户信息修改成功！"));
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Response.Write(MessagesBox.showMessages("用户信息修改失败！"));
            }
        }

        protected void btn_s_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}