using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;
namespace 高校食堂自助配餐系统.Administrator
{
    public partial class AdminManage : System.Web.UI.Page
    {
        adminIntSer adminInterSevice = new adminIntSer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowBuyer_Click(object sender, EventArgs e)
        {
            gv.DataSource = adminInterSevice.searchBuyerByAccount(txtSearch.Text.Trim());
            gv.DataBind();
        }

        protected void btnShowSeller_Click(object sender, EventArgs e)
        {
            gv.DataSource = adminInterSevice.searchSellerByAccount(txtSearch.Text.Trim());
            gv.DataBind();
        }

        protected void btnShowAllBuyer_Click(object sender, EventArgs e)
        {
            gv.DataSource = adminInterSevice.searchAllBuyer();
            gv.DataBind();
        }

        protected void btnShowAllSeller_Click(object sender, EventArgs e)
        {
            gv.DataSource = adminInterSevice.searchAllSeller();
            gv.DataBind();
        }

        protected void searchBOrder_Click(object sender, EventArgs e)
        {
            gv.DataSource = adminInterSevice.searchBOrderByOrderId(Int32.Parse(txtSearch.Text.Trim()));
            gv.DataBind();
        }

        protected void searchSOrder_Click(object sender, EventArgs e)
        {
            gv.DataSource = adminInterSevice.searchSOrderByOrderId(Int32.Parse(txtSearch.Text.Trim()));
            gv.DataBind();
        }
    }
}