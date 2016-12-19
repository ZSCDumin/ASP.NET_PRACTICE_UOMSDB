using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class b_order_state_Entity
    {
        private int b_o_id;//订单编号
        private string b_o_state;//订单状态
        private DateTime b_o_subTime;//提交时间
        public int B_o_id
        {
            get { return b_o_id; }
            set { b_o_id = value; }
        }     
        public string B_o_state
        {
            get { return b_o_state; }
            set { b_o_state = value; }
        }
        public DateTime B_o_subTime
        {
            get { return b_o_subTime; }
            set { b_o_subTime = value; }
        }
    }
}