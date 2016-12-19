using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Entity
{
    public class buyer_Entity
    {
        /* 属性区*/
        private string b_account;//买家帐号
        private string b_password;  //密码
        private string b_name; //姓名
        private string b_tel; //电话号码
        private double b_balance;  //账户余额
        private string b_question; //密保问题
        private string b_answer;  //密保问题答案
        private string b_email;//邮箱

        public string B_account
        {
            get { return b_account; }
            set { b_account = value; }
        }
        public string B_password
        {
            get { return b_password; }
            set { b_password = value; }
        }
        public string B_name
        {
            get { return b_name; }
            set { b_name = value; }
        }
        public string B_tel
        {
            get { return b_tel; }
            set { b_tel = value; }
        }
        public double B_balance
        {
            get { return b_balance; }
            set { b_balance = value; }
        }
        public string B_question
        {
            get { return b_question; }
            set { b_question = value; }
        }
        public string B_answer
        {
            get { return b_answer; }
            set { b_answer = value; }
        }
        public string B_email
        {
            get { return b_email; }
            set { b_email = value; }
        }
    }
}