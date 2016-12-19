using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity
{
    public class seller_Entity
    {
        /* 属性区*/
        private string s_account; //卖家帐号
        private string s_password;  //密码
        private string s_storeName; //店铺名称
        private string s_name; //姓名
        private string s_tel; //电话号码
        private string s_question;  //密保问题
        private string s_answer; //密保答案
        private bool s_state; //账号状态
        private double s_profit;//收益额

        public string S_account
        {
            get { return s_account; }
            set { s_account = value; }
        }      
        public string S_password
        {
            get { return s_password; }
            set { s_password = value; }
        }       
        public string S_storeName
        {
            get { return s_storeName; }
            set { s_storeName = value; }
        }      
        public string S_name
        {
            get { return s_name; }
            set { s_name = value; }
        }      
        public string S_tel
        {
            get { return s_tel; }
            set { s_tel = value; }
        }      
        public string S_question
        {
            get { return s_question; }
            set { s_question = value; }
        }      
        public string S_answer
        {
            get { return s_answer; }
            set { s_answer = value; }
        }
        public bool S_state
        {
            get { return s_state; }
            set { s_state = value; }
        }      
        public double S_profit
        {
            get { return s_profit; }
            set { s_profit = value; }
        }
    }
}