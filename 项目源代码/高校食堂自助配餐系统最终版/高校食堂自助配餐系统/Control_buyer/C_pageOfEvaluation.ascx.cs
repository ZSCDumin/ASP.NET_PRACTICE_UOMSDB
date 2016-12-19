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
    public partial class pageOfEvaluation : System.Web.UI.UserControl
    {
        public string imagePath;
        public string PId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
            }
            imagePath = Request.QueryString["imagePath"];    
            PId = Request.QueryString["PId"];
            Image1.ImageUrl=imagePath;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            b_evaluate_Entity evaluate = new b_evaluate_Entity();
            buyerIntSer buyer=new buyerIntSer();
            evaluate.P_evaluate = TextBox1.Text.Trim();
            evaluate.B_account = Session["UserAccount"].ToString().Trim();
            evaluate.P_name = buyer.SearchNameOfPro(int.Parse(PId));
            evaluate.P_Id = int.Parse(PId);
            evaluate.P_photo = buyer.SearchUrlOfProPhoto(int.Parse(PId));
            buyer.InsertToEvaluations(evaluate);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}