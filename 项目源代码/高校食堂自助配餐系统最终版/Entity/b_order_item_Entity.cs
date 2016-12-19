using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class b_order_item_Entity
    {
        private int b_o_id;//订单编号
        private int p_id;  //商品编号
        private double p_price;//商品价格
        private int p_num;//商品数量
        public int B_o_id
        {
            get { return b_o_id; }
            set { b_o_id = value; }
        }
        public int P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        public double P_price
        {
            get { return p_price; }
            set { p_price = value; }
        }
        public int P_num
        {
            get { return p_num; }
            set { p_num = value; }
        }
    }
}