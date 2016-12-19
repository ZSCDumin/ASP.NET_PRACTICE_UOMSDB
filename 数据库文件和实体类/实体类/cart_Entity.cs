using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class cart_Entity
    {
        private string b_account;//买家帐号
        private string s_account;//卖家账号
        private string s_storeName;//店铺名称
        private int p_Id;//商品Id
        private string p_name;//商品名称
        private double p_price;//商品价格
        private int p_num;//商品数量
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
        public int P_Id
        {
            get { return p_Id; }
            set { p_Id = value; }
        }       
        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
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