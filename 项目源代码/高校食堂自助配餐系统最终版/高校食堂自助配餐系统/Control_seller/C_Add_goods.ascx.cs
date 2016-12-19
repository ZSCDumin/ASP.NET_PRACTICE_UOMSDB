using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;
using Entity;

namespace 高校食堂自助配餐系统.Control_seller
{
    public partial class Add_goods : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserAccount"]==null)
            {
                Response.Redirect("../login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SellService a = new SellService();
            product_Entity b = new product_Entity();
            b.S_account = Session["UserAccount"].ToString().Trim();
            b.P_name = txtProduct_name.Text;
            b.P_category = txtProduct_category.Text;
            b.P_price = double.Parse(txtProduct_price.Text);
            b.P_cNum = int.Parse(txtProduct_number.Text);
            b.P_photo = FileUpload1.FileName;
            a.add(b, FileUpload1);
            Response.Write(MessagesBox.showMessages("添加成功"));
        }
    }
}