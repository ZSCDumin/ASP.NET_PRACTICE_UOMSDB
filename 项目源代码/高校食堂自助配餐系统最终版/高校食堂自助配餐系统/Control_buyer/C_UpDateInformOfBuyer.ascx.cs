using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity;
using InterService;
namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class UpDateInformOfBuyer : System.Web.UI.UserControl
    {

        public string imagePath;
        public string PId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            buyer_Entity buyer = new buyer_Entity();
            buyerIntSer B = new buyerIntSer();
   
            buyer.B_account = Session["UserAccount"].ToString().Trim();
            bool b = B.ifBuyerExist(buyer.B_account);
            if (b)
            {
                buyer.B_name = txtName.Text;
                buyer.B_tel = txtTel.Text;
                buyer.B_question = DropDownList1.SelectedItem.Value;
                buyer.B_answer = txtAnswer.Text;
                buyer.B_email = txtEmail.Text;
                B.BuyerModify(buyer.B_account, buyer.B_name, buyer.B_tel,
                    buyer.B_question, buyer.B_answer, buyer.B_email);
                Response.Write(MessagesBox.showMessages("修改成功！"));
                System.Threading.Thread.Sleep(1000);
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Response.Write(MessagesBox.showMessages("信息修改失败，请重新进行修改操作！"));
            }   
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

    }
}