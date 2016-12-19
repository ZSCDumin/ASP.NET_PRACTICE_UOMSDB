using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class b_order_Entity
    {
        private int b_o_id;//订单编号
        private string b_account;//买家账号
        private string s_account;//卖家账号
        private string s_storeName;//店铺名称
        private double b_o_totalprice;//订单总价
        private DateTime b_o_time;//订单时间
        private string b_order_state;//订单状态

        public string B_order_state
        {
            get { return b_order_state; }
            set { b_order_state = value; }
        }

        public DateTime B_o_time
        {
            get { return b_o_time; }
            set { b_o_time = value; }
        }
        public int B_o_id
        {
            get { return b_o_id; }
            set { b_o_id = value; }
        }
        public string B_account
        {
            get { return b_account; }
            set { b_account = value; }
        }
        public string S_account
        {
            get { return s_account; }
            set { s_account = value; }
        }
        public string S_storeName
        {
            get { return s_storeName; }
            set { s_storeName = value; }
        }
        public double B_o_totalprice
        {
            get { return b_o_totalprice; }
            set { b_o_totalprice = value; }
        }
    }
}