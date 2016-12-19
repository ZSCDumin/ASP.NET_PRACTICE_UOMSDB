using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class product_Entity
    {
        private int p_Id; //商品编号
        private string s_account; //卖家帐号
        private string p_name; //商品名称
        private string p_category; //商品分类
        private double p_price; //商品单价
        private int p_cNum; //商品库存量
        private string p_photo;//商品图片
        private int p_saleNum; //销量

        public int P_Id
        {
            get { return p_Id; }
            set { p_Id = value; }
        }
        public string S_account
        {
            get { return s_account; }
            set { s_account = value; }
        }
        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }
        public string P_category
        {
            get { return p_category; }
            set { p_category = value; }
        }
        public double P_price
        {
            get { return p_price; }
            set { p_price = value; }
        }
        public int P_cNum
        {
            get { return p_cNum; }
            set { p_cNum = value; }
        }
        public string P_photo
        {
            get { return p_photo; }
            set { p_photo = value; }
        }     
        public int P_saleNum
        {
            get { return p_saleNum; }
            set { p_saleNum = value; }
        }
    }
}