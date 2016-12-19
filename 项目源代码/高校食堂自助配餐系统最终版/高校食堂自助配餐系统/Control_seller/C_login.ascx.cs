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
    public partial class login : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCode.Text = GenerateRandomCode.RandomCode().Trim();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SellService a = new SellService();
            buyerIntSer b = new buyerIntSer();
            if (RadioButtonList1.SelectedItem != null)
            {
                if (RadioButtonList1.SelectedItem.Value.ToString() == "卖家")
                {
                    if (!txtCode.Text.Trim().Equals(lblCode.Text.Trim()))
                    {
                        Response.Write(MessagesBox.showMessages("验证码错误！"));
                    }
                    else
                    {
                        if (a.landing(txtAccount.Text.Trim(), txtPassword.Text.Trim()))
                        {
                            Session["UserAccount"] = txtAccount.Text.Trim();
                            Session["UserPassword"] = txtPassword.Text.Trim();
                            Session["Logged"] = true;
                            Session["UserType"] = "1";
                            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtAccount.Text, true);

                        }
                        else
                        {
                            Response.Write(MessagesBox.showMessages("账号或密码错误！"));
                        }
                    }
                }


                else
                {

                    if (!txtCode.Text.Trim().Equals(lblCode.Text.Trim()))
                    {
                        Response.Write(MessagesBox.showMessages("验证码错误！"));
                    }
                    else
                    {
                        if (b.login(txtAccount.Text.Trim(), txtPassword.Text.Trim()))
                        {
                            Session["UserAccount"] = txtAccount.Text.Trim();
                            Session["UserPassword"] = txtPassword.Text.Trim();
                            Session["Logged"] = true;
                            Session["UserType"] = "0";
                            System.Web.Security.FormsAuthentication.RedirectFromLoginPage(txtAccount.Text, true);

                        }
                        else
                        {
                            Response.Write(MessagesBox.showMessages("账号或密码错误！"));
                        }
                    }
                }
            }
            else
            {
                Response.Write(MessagesBox.showMessages("请先选择用户角色!"));
            }
        }
    }
}