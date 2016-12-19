using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataBindAllPro(Session["UserAccount"].ToString(), 1);

            }
        }
        UOMSDBDataContext db = new UOMSDBDataContext();
        public void DataBindAllPro(string account, int pageIndex)
        {
            int repeart = 8;
            var result = db.product_T.Where(c => c.s_account.Equals(account));
            DataList1.DataSource = result.Skip((pageIndex - 1) * repeart).Take(repeart);
            DataList1.DataBind();
            int  num = result.Count();
            if(num% repeart!=0)
            {
                lbTotalPage.Text = ((num / repeart) + 1).ToString();
            }
            else 
            {
                if (num / repeart == 0)
                {
                    lbTotalPage.Text = "1";
                }
                else
                {
                    lbTotalPage.Text = (num / repeart).ToString();
                }
             }
            lbCurrent.Text = pageIndex.ToString();
        }
        DataTask d = new DataTask();
        protected void Button2_Click1(object sender, EventArgs e)
        {
            Button b = sender as Button;
            d.removeProduct(int.Parse(b.CommandArgument), Session["UserAccount"].ToString());
            DataBindAllPro(Session["UserAccount"].ToString(), 1);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Response.Redirect("~/seller/Modify_goods.aspx?id=" + b.CommandArgument + "");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (lbCurrent.Text == "1")
            {
            }
            else
            {
                DataBindAllPro(Session["UserAccount"].ToString(), int.Parse(lbCurrent.Text)-1);
            }
        }

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (lbCurrent.Text == lbTotalPage.Text)
            {
            }
            else
            {
                DataBindAllPro(Session["UserAccount"].ToString(), int.Parse(lbCurrent.Text)+1);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (lbCurrent.Text == "1")
            {

            }
            else
            {
                DataBindAllPro(Session["UserAccount"].ToString(), 1);
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (lbTotalPage.Text == lbCurrent.Text)
            {

            }
            else
            {
                DataBindAllPro(Session["UserAccount"].ToString(), int.Parse(lbTotalPage.Text)-1);
            }
        }
    }
}