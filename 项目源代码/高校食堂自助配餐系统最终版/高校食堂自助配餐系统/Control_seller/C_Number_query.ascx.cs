using InterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校食堂自助配餐系统.Control_seller
{
    public partial class Number_query : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            SellService a = new SellService();
            GridView1.DataSource = a.searchAllOrder(txtSell_Id.Text);
            GridView1.DataBind(); 
        }
    }
}