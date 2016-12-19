using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Entity
{
    public class s_order_item_Entity
    {
        private int s_o_id;   //订单编号
        private int p_Id;   //商品编号
        private double p_price;  //商品价格
        private int p_num;    //商品数量
        public int P_Id
        {
            get { return p_Id; }
            set { p_Id = value; }
        }             
        public int P_num
        {
            get { return p_num; }
            set { p_num = value; }
        }
        public double P_price
        {
            get { return p_price; }
            set { p_price = value; }
        }      
        public int S_o_id
        {
            get { return s_o_id; }
            set { s_o_id = value; }
        }
    }
}