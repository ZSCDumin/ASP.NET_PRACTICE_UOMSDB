using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;
namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class searchBalance : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
            else
            {
                string account = Session["UserAccount"].ToString();
                lblAccount.Text = account;
                buyerIntSer buyer = new buyerIntSer();
                lblbalance.Text = buyer.SearchBalance(account).ToString();
            }
        }

        protected void btnRecharge_Click(object sender, ImageClickEventArgs e)
        {
            string account = Session["UserAccount"].ToString().Trim();
            buyerIntSer buyer = new buyerIntSer();
            buyer.AddMoney(account,double.Parse(TextBox1.Text.Trim()));
        }
    }
}