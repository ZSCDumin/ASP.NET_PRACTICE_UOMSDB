using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 高校食堂自助配餐系统.Control_buyer
{
    public partial class ProductShow : System.Web.UI.UserControl
    {
        string selectStr = "select * from product_T";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CurrentPageCount.Text = 1.ToString();
                DataBind(0);
                TotalPageCount.Text = pds.PageCount.ToString();
            }
        }
        PagedDataSource pds = new PagedDataSource();
        protected void selectPro(string proName)
        {
            selectStr = "select * from product_T  where p_category='" + proName + "'";
        }
        protected void DataBind(int currentPage)
        {
            if (Request.QueryString["search"] != null)
            {
                selectStr = "select * from product_T where p_name like ('%'+'" + Request.QueryString["search"].ToString() + "'+'%')";
            }
            else if (Request.QueryString["category"] != null)
            {
                selectStr = "select * from product_T where p_category ='" + Request.QueryString["category"].ToString() + "'";
            }
            string str = "Data Source=.;Initial Catalog=UOMSDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            pds.AllowPaging = true;
            pds.PageSize = 20;
            pds.CurrentPageIndex = currentPage;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(selectStr, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            pds.DataSource = ds.Tables[0].DefaultView;
            DataList1.DataSource = pds;
            DataList1.DataBind();
            con.Close();
        }
        protected void 上一页_Click(object sender, EventArgs e)
        {
            if (CurrentPageCount.Text == "1")
            {
                上一页.OnClientClick = "";
            }
            else
            {
                pds.CurrentPageIndex = int.Parse(CurrentPageCount.Text) - 2;
                CurrentPageCount.Text = (pds.CurrentPageIndex + 1).ToString();
                DataBind(pds.CurrentPageIndex);
            }
        }

        protected void 下一页_Click(object sender, EventArgs e)
        {
            if (CurrentPageCount.Text == TotalPageCount.Text)
            {
                下一页.OnClientClick = "";
                //  return ;
            }
            else
            {
                pds.CurrentPageIndex = Int32.Parse(CurrentPageCount.Text);
                CurrentPageCount.Text = (pds.CurrentPageIndex + 1).ToString();
                DataBind(pds.CurrentPageIndex);
                //  break;
            }
        }

        protected void 首页_Click(object sender, EventArgs e)
        {
            pds.CurrentPageIndex = 0;
            CurrentPageCount.Text = 1.ToString();
            DataBind(pds.CurrentPageIndex);
        }

        protected void 尾页_Click(object sender, EventArgs e)
        {
            pds.CurrentPageIndex = Int32.Parse(TotalPageCount.Text.ToString()) - 1;
            CurrentPageCount.Text = (pds.CurrentPageIndex + 1).ToString();
            DataBind(pds.CurrentPageIndex);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CurrentPageCount.Text = TextBox1.Text.Trim();
            DataBind(int.Parse(TextBox1.Text) - 1);
            TextBox1.Text = null;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton b = sender as ImageButton;
            string id = b.CommandArgument;
            Response.Redirect("~/ProductDetail.aspx?id=" + id + "");
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //string id = DataList1.DataKeys[e.Item.ItemIndex].ToString();
            //Response.Redirect("WebForm2.aspx?id=" + id + "");
        }
        buyerDate buyDB = new buyerDate();
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                Button b = sender as Button;
                int id = int.Parse(b.CommandArgument);//获取button上面绑定的项目的主键值
                buyDB.addProduct(Session["UserAccount"].ToString(), 1, id);//默认的是添加一个到购物车
            }
        }

        protected void btn_serach_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?search=" + txb_serach.Text + "");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?category=" + LinkButton1.Text + "");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?category=" + LinkButton2.Text + "");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?category=" + LinkButton3.Text + "");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?category=" + LinkButton4.Text + "");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?category=" + LinkButton5.Text + "");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?category=" + LinkButton6.Text + "");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx?category=" + LinkButton7.Text + "");
        }
    }
}