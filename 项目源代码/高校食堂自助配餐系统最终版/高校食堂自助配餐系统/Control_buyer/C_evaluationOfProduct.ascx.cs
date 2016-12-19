using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;
using Entity;

namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class evaluationOfProduct : System.Web.UI.UserControl
    {
        public string imagePath;
        public string PId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] != null)
            {
                buyerIntSer buyer = new buyerIntSer();
                GridView1.DataSource = buyer.SearchProItmeOrder(Session["UserAccount"].ToString());
                GridView1.DataBind();
            }

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buyerIntSer buyer = new buyerIntSer();
            string str = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text.Trim();
            PId = str;
            imagePath = buyer.SearchUrlOfProPhoto(int.Parse(str));
            Response.Redirect("../buyer/pageOfEvaluation.aspx?imagePath=" + imagePath + "&PId=" + PId);
        }
    }
}