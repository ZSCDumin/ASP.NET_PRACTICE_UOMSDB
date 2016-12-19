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
    public partial class C_Timerprofit : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
        }

        protected void btn_s_selectstart_Click(object sender, EventArgs e)
        {
            cld_s_start.Visible = true;           
        }

        protected void cld_s_start_SelectionChanged(object sender, EventArgs e)
        {
            txt_s_start.Text = cld_s_start.SelectedDate.ToString();
            cld_s_start.Visible = false;
        }

        protected void btn_s_selectend_Click(object sender, EventArgs e)
        {
            cld_s_end.Visible = true;
        }

        protected void cld_s_end_SelectionChanged(object sender, EventArgs e)
        {
            txt_s_end.Text = cld_s_end.SelectedDate.ToString();
            cld_s_end.Visible = false;
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            SellService sell = new SellService();
            string account = Session["UserAccount"].ToString().Trim();
            Label1.Text = sell.inquireProfit(account, cld_s_start.SelectedDate, cld_s_end.SelectedDate).ToString();
        }
    }
}