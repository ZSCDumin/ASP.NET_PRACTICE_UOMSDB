using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;

namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class search_state : System.Web.UI.UserControl
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
            buyerIntSer buy = new buyerIntSer();
            GridView1.DataSource = buy.SearchOrderByState(ddlState.SelectedItem.Value.ToString().Trim());
            GridView1.DataBind();
        }
    }
}