using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;
using Entity;
using DataAccess;

namespace 高校食堂自助配餐系统.Control_seller
{
    public partial class C_Information : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string account = Session["UserAccount"].ToString();
            seller_T seller = new seller_T();
            SellService sell = new SellService();

            seller = (seller_T)sell.SearchSellinformation(account);

            lbl_s_account.Text = seller.s_account;
            lbl_s_name.Text = seller.s_name;
            lbl_s_profit.Text = seller.s_profit.ToString();
            lbl_s_state.Text = seller.s_state?"账号有效":"账号无效";
            lbl_s_storename.Text = seller.s_storeName;
            lbl_s_tel.Text = seller.s_tel;
        }

    }
}