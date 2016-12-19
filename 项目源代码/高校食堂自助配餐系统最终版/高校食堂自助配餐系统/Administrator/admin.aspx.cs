using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;

namespace 高校食堂自助配餐系统
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            buyerIntSer buyer = new buyerIntSer();
            GridView1.DataSource = buyer.ShowUser();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            buyerIntSer buyer = new buyerIntSer();
            
        }
    }
}