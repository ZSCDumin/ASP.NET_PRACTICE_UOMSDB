using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InterService;
using Entity;
namespace 高校食堂自助配餐系统.control_buyer
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        buyerIntSer buyer = new buyerIntSer();
        SellService seller = new SellService();
        b_order_Entity b_order;
        b_order_item_Entity b_order_item;
        b_order_state_Entity b_order_state;
        double results = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserAccount"] == null)
            {
                Response.Redirect("../login.aspx");
                return;
            }
            if (gv.Rows.Count <= 0)
            {
                Response.Write(MessagesBox.showMessages("你的购物车空空如也！"));
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            string account = Session["UserAccount"].ToString().Trim();
            buyer.DeleteFromCartByBuyer(account);
            gv.DataSource = null;
            gv.DataBind();
            Response.Write(MessagesBox.showMessages("购物车已清空！"));
        }
       
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            string account = Session["UserAccount"].ToString().Trim();
            double balance = (double)buyer.SearchBalance(account);
            int totalPrice = int.Parse(lblTotalPrice.Text);
            if (totalPrice <= 0)
            {
                Response.Write(MessagesBox.showMessages("请点击重新计算或选择所要购买的商品！"));
            }
            else
            {
                if (balance >= totalPrice)//判断买家余额是否足够
                {
                    if (chkIsOnline.Checked == true)
                        buyer.AddMoney(account, -1.0 * totalPrice);//扣除买家余额
                    for (int i = 0; i < gv.Rows.Count; i++)
                    {
                        CheckBox chkProduct = (CheckBox)gv.Rows[i].FindControl("chkProducts");
                        if (chkProduct.Checked == true)
                        {
                            //向买家订单表插数据
                            b_order = new b_order_Entity();
                            b_order.B_account = gv.Rows[i].Cells[1].Text;
                            b_order.S_account = gv.Rows[i].Cells[2].Text;
                            b_order.S_storeName = gv.Rows[i].Cells[3].Text;
                            b_order.B_o_totalprice = double.Parse(lblTotalPrice.Text);

                            if (chkIsOnline.Checked == true)
                            {
                                b_order.B_order_state = "已付款";
                            }
                            else
                            {
                                b_order.B_order_state = "未支付";
                            }

                            //记录上一次的卖家和买家账号用于判断所选的是否属性同一个订单
                            string b_account = "";//买家账号
                            string s_account = "";//卖家账号
                            if (i > 0)
                            {
                                b_account = gv.Rows[i - 1].Cells[1].Text;
                                s_account = gv.Rows[i - 1].Cells[2].Text;
                            }
                            //如果是第一个商品的话，增加一条订单记录
                            if (i == 0)
                                buyer.AddOrder(b_order.B_account, b_order.S_account, b_order.S_storeName, b_order.B_order_state, b_order.B_o_totalprice);
                            else
                            {
                                //根据买家、卖家账号判断所选商品是否属性同一个订单
                                if (b_account == gv.Rows[i].Cells[1].Text && s_account == gv.Rows[i].Cells[2].Text) { }
                                else
                                    buyer.AddOrder(b_order.B_account, b_order.S_account, b_order.S_storeName, b_order.B_order_state, b_order.B_o_totalprice);
                            }

                            //向买家订单项目表插数据
                            int id = buyer.searchLatestBOrderId();//获取最新的订单编号
                            b_order_item = new b_order_item_Entity();
                            b_order_item.B_o_id = id;
                            b_order_item.P_id = int.Parse(gv.Rows[i].Cells[4].Text);
                            b_order_item.P_price = double.Parse(gv.Rows[i].Cells[6].Text);
                            TextBox txtNum = (TextBox)gv.Rows[i].FindControl("txtNum");
                            b_order_item.P_num = int.Parse(txtNum.Text);
                            buyer.AddOrderItem(b_order_item.B_o_id, b_order_item.P_id, b_order_item.P_price, b_order_item.P_num);

                            //向买家订单状态表插数据
                            b_order_state = new b_order_state_Entity();
                            b_order_state.B_o_id = id;
                            b_order_state.B_o_subTime = DateTime.Now;
                            if (chkIsOnline.Checked == true)
                            {
                                b_order_state.B_o_state = "已付款";
                            }
                            else
                            {
                                b_order_state.B_o_state = "未支付";
                            }
                            buyer.AddOrderState(b_order_state.B_o_id, b_order_state.B_o_state);
                            buyer.DeleteFromCart(Session["UserAccount"].ToString().Trim(), int.Parse(gv.Rows[i].Cells[4].Text));
                        }
                    }
                    Response.Write(MessagesBox.showMessages("提交结算成功！"));
                    Response.Redirect("../Default.aspx");
                }
                else
                {
                    Response.Write(MessagesBox.showMessages("您的余额不足，请充值！"));
                    Response.Redirect("../buyer/SearchBalance.aspx");
                }

            }

        }
        /// <summary>
        /// 修改商品数量后重新计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReCal_Click(object sender, EventArgs e)
        {
            cal();
        }
        /// <summary>
        /// 计算所选商品总价
        /// </summary>
        public void cal()
        {
            results = 0;
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                CheckBox chkProduct = (CheckBox)gv.Rows[i].FindControl("chkProducts");
                if (chkProduct.Checked == true)//判断是否选中
                {
                    TextBox txtNum = (TextBox)gv.Rows[i].FindControl("txtNum");
                    //判断商品库存量是否足够
                    if (int.Parse(txtNum.Text) > seller.searchProCNum(int.Parse(gv.Rows[i].Cells[4].Text)))
                    {
                        Response.Write(MessagesBox.showMessages("商品名称为：" + gv.Rows[i].Cells[5].Text + " 的商品的库存不足,请重新输入商品数量！"));
                    }
                    else
                    {
                        //判断所选商品数量是否小于零
                        if (int.Parse(txtNum.Text) <= 0)
                        {
                            Response.Write(MessagesBox.showMessages("请重新输入商品名称为：" + gv.Rows[i].Cells[5].Text + " 的商品数量！"));
                        }
                        else
                            results += double.Parse(gv.Rows[i].Cells[6].Text) * double.Parse(txtNum.Text);//单价*数量
                    }
                }
            }
            lblTotalPrice.Text = results.ToString();//显示总价
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void chkAllProducts_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkAll = (CheckBox)sender;
            foreach (GridViewRow gvRow in gv.Rows)
            {
                //获取GridView数据行中的chkAll对象
                CheckBox chkProduct = (CheckBox)gvRow.FindControl("chkProducts");
                chkProduct.Checked = chkAll.Checked;
            }
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal();
        }
    }
}