using Entity;
using InterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess;
namespace 高校食堂自助配餐系统.Control_seller
{
    public partial class Modify_goods : System.Web.UI.UserControl
    {
        DataTask dt = new DataTask();
            
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
            //这里我改了,时间2016.12.17.22.05
            //else if (Session["UserAccount"].Equals(Request.QueryString["account"])==false)
            //{
            //    Response.Redirect("../login.aspx");
            //}
            if (!IsPostBack)
            {
                product_Entity product = new product_Entity();
                product = dt.inquireProById(Session["UserAccount"].ToString(), int.Parse(Request.QueryString["id"]));
                txtProduct_name.Text = product.P_name;
                txtProduct_number.Text = product.P_cNum.ToString();
                txtProduct_price.Text = product.P_price.ToString();
                txtProduct_category.Text = product.P_category;
                Image1.ImageUrl = product.P_photo;
            }
        }
        protected void showPicture()
        {
            Image1.ImageUrl = FileUpload1.FileName;
            Image1.Visible = true;
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SellService a = new SellService();
            product_Entity b = new product_Entity();
            b.P_Id = int.Parse(Request.QueryString["id"].ToString());
            b.S_account = Session["UserAccount"].ToString().Trim();
            b.P_name = txtProduct_name.Text.Trim();
            b.P_category = txtProduct_category.Text.Trim();
            b.P_price = double.Parse(txtProduct_price.Text.Trim());
            b.P_cNum = int.Parse(txtProduct_number.Text.Trim());
            b.P_photo = "~/Images/" + Session["UserAccount"].ToString().Trim() + "/" + FileUpload1.FileName;
            if (a.updateProInfo(Session["UserAccount"].ToString().Trim(), b, FileUpload1))
            {
                Response.Write(MessagesBox.showMessages("更改成功!"));
            }
            else
            {
                Response.Write(MessagesBox.showMessages("更改失败!"));
            }
        }
    }
}