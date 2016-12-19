using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class s_order_Entity
    {
        private int s_o_id;          //订单编号
        private string b_account;       //卖家账号
        private string s_account;       //买家账号
        private string s_o_state;       //订单状态
        private double s_o_totalprice;  //订单总价
        private DateTime s_o_time;      //订单时间
        public double S_o_totalprice
        {
            get { return s_o_totalprice; }
            set { s_o_totalprice = value; }
        }
        public string S_o_state
        {
            get { return s_o_state; }
            set { s_o_state = value; }
        }
        public string S_account
        {
            get { return s_account; }
            set { s_account = value; }
        }
        public string B_account
        {
            get { return b_account; }
            set { b_account = value; }
        }
        public int S_o_id
        {
            get { return s_o_id; }
            set { s_o_id = value; }
        }
        public DateTime S_o_time
        {
            get { return s_o_time; }
            set { s_o_time = value; }
        }
    }
}