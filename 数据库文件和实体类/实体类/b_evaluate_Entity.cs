using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity
{
    public class b_evaluate_Entity
    {
        private int evaluate_Id; //评价编号
        private string b_account; //买家账号
        private int p_Id; //商品Id
        private string p_name;//商品名称

        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }
        private string p_photo;//商品图片

        public string P_photo
        {
            get { return p_photo; }
            set { p_photo = value; }
        }
        private string p_evaluate; //商品评价
        public int Evaluate_Id
        {
            get { return evaluate_Id; }
            set { evaluate_Id = value; }
        }       
        public string B_account
        {
            get { return b_account; }
            set { b_account = value; }
        }      
        public int P_Id
        {
            get { return p_Id; }
            set { p_Id = value; }
        }       
        public string P_evaluate
        {
            get { return p_evaluate; }
            set { p_evaluate = value; }
        }

    }
}