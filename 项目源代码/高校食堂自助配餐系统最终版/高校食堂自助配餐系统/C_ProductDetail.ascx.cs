using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;

namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class ProductDetail : System.Web.UI.UserControl
    {
        UOMSDBDataContext db = new UOMSDBDataContext();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserAccount"]==null)
            {
                Response.Redirect("~/Default.aspx");
            }
            if(!IsPostBack)
            {
               
                DataList1.DataSource = db.product_T.Where(c => c.p_Id.Equals(Request.QueryString["id"].ToString()));
                DataList1.DataBind();
            }
         
        }
        buyerDate bd = new buyerDate();

        protected void Button2_Click(object sender, EventArgs e)
        {
          
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            TextBox t= e.Item.FindControl("TextBox1") as TextBox;
            bd.addProduct(Session["UserAccount"].ToString(),int.Parse(t.Text), int.Parse( DataList1.DataKeys[e.Item.ItemIndex].ToString()));
            DataList1.DataSource = db.product_T.Where(c => c.p_Id.Equals(Request.QueryString["id"].ToString()));
            DataList1.DataBind();
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}