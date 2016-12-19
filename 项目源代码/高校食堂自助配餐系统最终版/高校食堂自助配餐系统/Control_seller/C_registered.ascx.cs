using Entity;
using InterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校食堂自助配餐系统.Control_seller
{
    public partial class registered : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SellService db = new SellService();
            seller_Entity a = new seller_Entity();
            a.S_account = txtSell_Account.Text;
            a.S_password = txtSell_password.Text;
            a.S_name = txtSell_Name.Text;
            a.S_storeName = txtSell_storename.Text;
            a.S_tel = txtSell_tel.Text;
            a.S_question = ddlQuestion.Text;
            a.S_answer = txtSell_answer.Text;
            if (!db.exist(txtSell_Account.Text))
            {
                db.create(a);
                Response.Write(MessagesBox.showMessages("注册成功"));
            }
            else
            {
                Response.Write(MessagesBox.showMessages("账号已存在，请重新输入"));
            }
        }
    }
}