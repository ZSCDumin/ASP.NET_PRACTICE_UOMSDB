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
    public partial class showInformationOfBuyer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            buyerIntSer buyer = new buyerIntSer();
            string account = Session["UserAccount"].ToString();
            laccount.Text= account;
            lname.Text = buyer.name(account);
            ltel.Text = buyer.tel(account);
            lbalance.Text = buyer.balance(account);
            lemail.Text = buyer.email(account);
        }
    }
}