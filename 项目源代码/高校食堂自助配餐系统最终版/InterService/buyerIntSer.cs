using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
using Entity;

namespace InterService
{
    public class buyerIntSer
    {
        buyerDate Date = new buyerDate();
        public bool ifBuyerExist(string account)
        {
            return Date.ifBuyerExist(account);
        }
        public int searchLatestBOrderId()
        {
            return Date.searchLatestBOrderId();
        }
        //--搜索模块--

        /// <summary>
        /// 1.SearchByProName函数的功能：根据商品名称查找商品
        /// </summary>
        /// <param name="name">商品的名称</param>
        /// <returns>根据商品名称查询的商品的信息的Linq查询结果的集合</returns>
        public object SearchByProName(string name)
        {
            product_Entity P = new product_Entity();
            P.P_name = name;
            return Date.searchByProName(P);
        }
        /// <summary>
        /// SearchByCategory函数的功能：根据类型查找商品
        /// </summary>
        /// <param name="category">商品的类型</param>
        /// <returns>根据商品的类型查询的商品的信息的Linq查询结果的集合</returns>
        public object SearchByCategory(string category)
        {
            product_Entity P = new product_Entity();
            P.P_category = category;
            return Date.searchByCategory(P);
        }



        //--买家信息模块--

        /// <summary>
        /// BuyerReg函数的功能：买家的注册
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <param name="password">账号密码</param>
        /// <param name="name">买家姓名</param>
        /// <param name="tel">联系电话</param>
        /// <param name="question">密保问题</param>
        /// <param name="answer">答案</param>
        /// <param name="email">电子邮箱</param>
        public bool BuyerReg(string account, string password, string name, string tel, string question, string answer, string email)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            B.B_password = password;
            B.B_name = name;
            B.B_tel = tel;
            B.B_question = question;
            B.B_answer = answer;
            B.B_email = email;
            if (!Date.ifBuyerExist(B.B_account))
            {
                Date.user_reg(B);
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// login函数的功能：买家账号登录函数
        /// login函数的实现：主要是通过验证给定的密码与数据库中账号对应的密码是否一致来判断是否登录成功
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <param name="password">登录时输入的密码</param>
        /// <returns>如果验证成功返回true,验证失败返回false</returns>
        public bool login(string account, string password)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            B.B_password = password;
            bool result;
            result = Date.user_login(B);
            return result;
        }
        /// <summary>
        /// BuyerModify函数的功能：实现对买家用户信息的修改
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <param name="name">买家姓名</param>
        /// <param name="tel">电话</param>
        /// <param name="question">密保问题</param>
        /// <param name="answer">答案</param>
        /// <param name="email">电子邮箱</param>
        public void BuyerModify(string account, string name, string tel, string question, string answer, string email)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            B.B_name = name;
            B.B_tel = tel;
            B.B_question = question;
            B.B_answer = answer;
            B.B_email = email;
            Date.user_modify(B);
        }
        /// <summary>
        /// ShowQuestion函数的功能：用于显示用户的密保问题
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <returns>返回用户的密保问题</returns>
        public string ShowQuestion(string account)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            return Date.Return_question(B);
        }
        /// <summary>
        /// ShowAnswer函数的功能：显示买家用户的密保问题的答案
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <returns>返回用户的密保问题的答案</returns>
        public string ShowAnswer(string account)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            return Date.Return_answer(B);
        }
        /// <summary>
        /// FindPassword函数的功能：验证用户输入的密保问题与注册时的密保答案是否一致
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <param name="answer">密保答案</param>
        /// <returns>如果密保问题验证成功返回true，否则返回false</returns>
        public bool FindPassword(string account, string answer)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            if (Date.Return_answer(B) == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Updatepassword函数的功能：修改密码
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <param name="password">原密码</param>
        public void Updatepassword(string account, string password)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            B.B_password = password;
            Date.UpDatePassword(B);
        }


        /// <summary>
        /// SearchByName函数的功能：根据买家姓名查找买家信息
        /// </summary>
        /// <param name="name">买家的姓名</param>
        /// <returns>返回的是根据买家姓名来查询买家信息的Linq查询结果的集合</returns>
        public object SearchByName(string name)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_name = name;
            return Date.searchByName(B);
        }

        public object ShowUser()
        {
            buyer_Entity B = new buyer_Entity();
            return Date.ShowInformOfUseer(B);
        }


        public string name(string account)
        {
            return Date.Name(account);
        }
        public string tel(string account)
        {
            return Date.Tel(account);
        }
        public string balance(string account)
        {
            return Date.Balance(account);
        }
        public string email(string account)
        {
            return Date.Email(account);
        }






        //--购物车模块--

        /// <summary>
        /// InsertToCart函数的功能：向购物车中添加商品
        /// </summary>
        /// <param name="Baccount">买家账号</param>
        /// <param name="Saccount">卖家账号</param>
        /// <param name="name">商品名称</param>
        /// <param name="id">商品ID</param>
        /// <param name="price">商品价格</param>
        /// <param name="num">商品数量</param>
        public void InsertToCart(string Baccount, string Saccount, string name, int id, double price, int num)
        {
            cart_Entity C = new cart_Entity();
            C.B_account = Baccount;
            C.S_account = Saccount;
            C.P_name = name;
            C.P_Id = id;
            C.P_price = price;
            C.P_num = num;
          //  Date.addProduct(C);
        }
        /// <summary>
        /// DeleteFromCartByBuyer函数的功能：根据买家的账号删除个人购物车的所有记录
        /// </summary>
        /// <param name="account">买家账号</param>
        public void DeleteFromCartByBuyer(string account)
        {
            cart_Entity C = new cart_Entity();
            C.B_account = account;
            Date.removeProductByBuyer(C);
        }
        /// <summary>
        /// DeleteFromCart函数的功能：从购物车中移除商品
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <param name="id">商品ID</param>
        public void DeleteFromCart(string account, int id)
        {
            cart_Entity C = new cart_Entity();
            C.B_account = account;
            C.P_Id = id;
            Date.removeProduct(C);
        }
        /// <summary>
        /// ReturnInformOfCart函数的功能：返回购物车中的信息
        /// </summary>
        /// <param name="Baccount">买家账号</param>
        /// <returns>返回的是根据买家账号来查询购物车信息的Linq查询结果的集合</returns>
        public object ReturnInformOfCart(string Baccount)
        {
            cart_Entity C = new cart_Entity();
            C.B_account = Baccount;
            return Date.Return_Cart(C);
        }



        //--提交计算模块--

        /// <summary>
        /// SubmitOrder函数的功能：提交订单
        /// </summary>
        /// <param name="Oid">订单ID</param>
        /// <param name="price">商品价格</param>
        /// <param name="num">商品数量</param>
        public void SubmitOrderItem(int Oid, int Pid, double price, int num, DateTime time)
        {
            b_order_item_Entity I = new b_order_item_Entity();
            I.B_o_id = Oid;
            I.P_id = Pid;
            I.P_price = price;
            I.P_num = num;
            Date.InsertToOrderItem(I);
        }
        /// <summary>
        /// 订单支付
        /// </summary>
        /// <param name="Bid">买家ID</param>
        /// <param name="state">订单状态</param>
        public void PayForOrder(int Bid, string state,DateTime time)
        {
            b_order_state_Entity S = new b_order_state_Entity();
            S.B_o_id = Bid;
            S.B_o_state = state;
            S.B_o_subTime = time;
            Date.InsertToOrderState(S);
        }
        /// <summary>
        /// AddOrder函数的功能：向买家订单表中添加一条新的记录
        /// </summary>
        /// <param name="Bid">订单编号</param>
        /// <param name="Baccount">买家账号</param>
        /// <param name="Saccount">卖家账号</param>
        /// <param name="storeName">商铺名</param>
        /// <param name="money">总计金额</param>
        public void AddOrder(string Baccount,string Saccount,string storeName,string state ,double money)
        {
            b_order_Entity O = new b_order_Entity();
            O.B_account = Baccount;
            O.S_account = Saccount;
            O.S_storeName = storeName;
            O.B_order_state = state;
            O.B_o_totalprice = money;
           
            Date.InsertToOrder(O);
        }
        /// <summary>
        /// AddOrderItem函数的功能：向买家订单项目表中添加一条新的记录
        /// </summary>
        /// <param name="Bid">订单编号</param>
        /// <param name="Pid">商品编号</param>
        /// <param name="price">商品价格</param>
        /// <param name="num">商品数量</param>
        /// <param name="time">提交时间</param>
        public void AddOrderItem(int Bid,int Pid,double price,int num)
        {
            b_order_item_Entity Item = new b_order_item_Entity();
            Item.B_o_id = Bid;
            Item.P_id = Pid;
            Item.P_price = price;
            Item.P_num = num;
            Date.InsertToOrderItem(Item);
        }
        /// <summary>
        /// AddOrderState函数的功能：向买家订单状态表中添加一条新的记录
        /// </summary>
        /// <param name="Bid">订单编号</param>
        /// <param name="state">订单状态</param>
        /// <param name="time">提交时间</param>      
        public void AddOrderState(int Bid,string state)
        {
            b_order_state_Entity State = new b_order_state_Entity();
            State.B_o_id = Bid;
            State.B_o_state = state;
            Date.InsertToOrderState(State);
        }



        //--订单查询模块--

        /// <summary>
        /// SearchOrderById函数的功能：订单编号查询
        /// </summary>
        /// <param name="Oid">订单ID</param>
        /// <returns>订单详情</returns>
        public object SearchOrderById(int Oid)
        {
            b_order_Entity O = new b_order_Entity();
            O.B_o_id = Oid;
            return Date.orderSearchAllById(O);
        }
        public object SearchStateByOId(int Oid)
        {
            b_order_state_Entity O = new b_order_state_Entity();
            O.B_o_id = Oid;
            return Date.orderSearchStateById(O);
        }
        /// <summary>
        /// SearchOrderByState函数的功能：订单状态查询
        /// </summary>
        /// <param name="state">订单的状态</param>
        /// <returns>订单详情</returns>
        public object SearchOrderByState(string state)
        {
            b_order_Entity S = new b_order_Entity();
            S.B_order_state = state;
            return Date.orderSearchByState(S);
        }



        //--买家充值--

        /// <summary>
        /// AddMoney函数的功能：买家充值
        /// </summary>
        /// <param name="account">买家账户</param>
        /// <param name="money">充值金额</param>
        public void AddMoney(string account, double money)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            B.B_balance = money;
            Date.addmoney(B);
        }



        //--买家查询余额--

        /// <summary>
        /// SearchBalance函数的功能：查询买家账户余额
        /// </summary>
        /// <param name="account">买家账号</param>
        /// <returns></returns>
        public double SearchBalance(string account)
        {
            buyer_Entity B = new buyer_Entity();
            B.B_account = account;
            return Date.searchBalanceOfBuyer(B);
        }


        public void InsertToEvaluations(b_evaluate_Entity evalua)
        {
            Date.insertEvaluation(evalua);
        }
        public string SearchUrlOfProPhoto(int pid)
        {
            return Date.searchUrlOfProPhoto(pid);
        }
        public string SearchNameOfPro(int pid)
        {
            return Date.searchNameOfPro(pid);
        }
        public object SearchProItmeOrder(string account)
        {
            return Date.searchProItmeOrder(account);
        }
    
    }
}