using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Entity;

namespace DataAccess
{
    public class buyerDate
    {
        UOMSDBDataContext buyerDB = new UOMSDBDataContext();
        //--搜索模块--

        /// <summary>
        /// searchByProName函数的功能：访问数据库根据商品的名称查找出商品的信息
        /// </summary>
        /// <param name="product">商品对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object searchByProName(product_Entity product)
        {
            var Name = buyerDB.product_T.Where(n => n.p_name == product.P_name).Select(n => n);
            return (object)Name;
        }
        /// <summary>
        /// searchByCategory函数的功能：访问数据库根据商品的分类查找出商品的信息
        /// </summary>
        /// <param name="product">商品对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object searchByCategory(product_Entity product)
        {
            var Category = buyerDB.product_T.Where(r => r.p_category == product.P_category).Select(r => r);
            return (object)Category;
        }


        public bool ifBuyerExist(string account)
        {
            var results = buyerDB.buyer_T.Where(r => r.b_account == account);
            if (results.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //--买家信息模块--

        /// <summary>
        /// user_reg函数的功能：向买家表中增加一条新的记录（增）
        /// </summary>
        /// <param name="buyer">买家对象</param>
        public void user_reg(buyer_Entity buyer)
        {
            buyer_T Buyer = new buyer_T();
            Buyer.b_account = buyer.B_account;
            Buyer.b_password = buyer.B_password;
            Buyer.b_name = buyer.B_name;
            Buyer.b_tel = buyer.B_tel;
            Buyer.b_question = buyer.B_question;
            Buyer.b_answer = buyer.B_answer;
            Buyer.b_email = buyer.B_email;
            buyerDB.buyer_T.InsertOnSubmit(Buyer);
            buyerDB.SubmitChanges();
        }
        /// <summary>
        /// deleteBuyerByAccount函数的功能：根据买家账号删除买家表中的数据（删）
        /// </summary>
        /// <param name="buyer">买家对象</param>
        public void deleteBuyerByAccount(buyer_Entity buyer)
        {
            var results = buyerDB.buyer_T.Where(r => r.b_account == buyer.B_account).Select(r => r);
            buyerDB.buyer_T.DeleteAllOnSubmit(results);
            buyerDB.SubmitChanges();
        }
        /// <summary>
        /// ShowInformOfUseer函数的功能：买家表的查询（查）
        /// </summary>
        /// <param name="buyer">买家对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object ShowInformOfUseer(buyer_Entity buyer)
        {
            var results = buyerDB.buyer_T.Select(r => r);
            return (object)results;
        }
        /// <summary>
        /// user_modify函数的功能：买家表的修改（改）
        /// </summary>
        /// <param name="buyer">买家对象</param>
        public void user_modify(buyer_Entity buyer)
        {
            var results = buyerDB.buyer_T.Where(r => r.b_account == buyer.B_account).Select(r => r);
            if (results.Count() > 0)
            {
                foreach (buyer_T r in results)
                {
                    r.b_name = buyer.B_name;
                    r.b_tel = buyer.B_tel;
                    r.b_question = buyer.B_question;
                    r.b_answer = buyer.B_answer;
                    r.b_email = buyer.B_email;
                }
                buyerDB.SubmitChanges();
            }
        }


        /// <summary>
        /// user_login函数的功能：访问数据库根据用户提供的账号查询对应的密码进行比较如果密码一样则登录成功，否则登录失败。
        /// </summary>
        /// <param name="buyer">买家对象</param>
        /// <returns>如果密码验证成功返回true，否则返回false</returns>
        public bool user_login(buyer_Entity buyer)
        {
            buyer_T Buyer = new buyer_T();
            string passWord = buyerDB.buyer_T.Where(c => c.b_account.Equals(buyer.B_account)).Select(c => c.b_password).FirstOrDefault();
            if (passWord != null)
            {
                if (passWord.Equals(buyer.B_password))
                {
                    return true;
                }
            }
            return false;

        }
        /// <summary>
        /// Return_question函数的功能：访问数据库根据用户的账号查找用户的密保问题
        /// </summary>
        /// <param name="buyer">买家对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public string Return_question(buyer_Entity buyer)
        {
            var question = buyerDB.buyer_T.Where(q => q.b_account == buyer.B_account).Select(q => q.b_question);
            return question.First();
        }
        /// <summary>
        /// find_password函数的功能：访问数据库根据用户的账号查找用户的密保问题答案
        /// </summary>
        /// <param name="buyer">买家对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public string Return_answer(buyer_Entity buyer)
        {
            var Answer = buyerDB.buyer_T.Where(a => a.b_account == buyer.B_account).Select(a => a.b_answer);
            return Answer.First();
        }
        /// <summary>
        /// UpDatePassword函数的功能：访问数据库根据用户的账户更新用户的密码
        /// </summary>
        /// <param name="buyer">买家对象</param>
        public void UpDatePassword(buyer_Entity buyer)
        {
            var results = buyerDB.buyer_T.Where(r => r.b_account == buyer.B_account).Select(r => r);
            if (results.Count() > 0)
            {
                foreach (buyer_T r in results)
                {
                    r.b_password = buyer.B_password;
                }
                buyerDB.SubmitChanges();
            }
        }
        /// <summary>
        /// searchByName函数的功能：访问数据库根据买家名字查找出买家的信息
        /// </summary>
        /// <param name="buyer">买家对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object searchByName(buyer_Entity buyer)
        {
            var Name = buyerDB.buyer_T.Where(r => r.b_name == buyer.B_name).Select(r => r);
            return (object)Name;
        }

        public string Name(string account)
        {
            var Name = buyerDB.buyer_T.Where(n => n.b_account == account).Select(n => n.b_name);
            return Name.First();
        }
        public string Tel(string account)
        {
            var Tel = buyerDB.buyer_T.Where(t => t.b_account == account).Select(t => t.b_tel);
            return Tel.First();
        }
        public string Balance(string account)
        {
            var Balance = buyerDB.buyer_T.Where(b => b.b_account == account).Select(b => b.b_balance);
            return Balance.First().ToString();
        }
        public string Email(string account)
        {
            var Email = buyerDB.buyer_T.Where(e => e.b_account == account).Select(e => e.b_email);
            return Email.First();
        }








        /// <summary>
        /// 添加商品到购物车
        /// </summary>
        /// <param name="buyAccount"></param>
        /// <param name="ProNum"></param>
        /// <param name="ProID"></param>
        public void addProduct(string buyAccount, int ProNum, int ProID)
        {
            var result = buyerDB.product_T.Where(c => c.p_Id.Equals(ProID));
            var resultCart = buyerDB.cart_T.Where(c => c.p_Id.Equals(ProID) && c.b_account.Equals(buyAccount));
            cart_T Cart = new cart_T();
            if (resultCart.Count() > 0)
            {
                foreach (cart_T r in resultCart)
                {
                    r.p_num += ProNum;
                    buyerDB.SubmitChanges();
                }
            }
            else
            {
                foreach (product_T r in result)
                {
                    Cart.s_account = r.s_account;
                    Cart.b_account = buyAccount;
                    Cart.s_storeName = r.p_name;
                    Cart.p_name = r.p_name;
                    Cart.p_price = r.p_price;
                    Cart.p_Id = r.p_Id;
                    Cart.p_num = ProNum;
                    buyerDB.cart_T.InsertOnSubmit(Cart);
                    buyerDB.SubmitChanges();
                }
            }
        }

        /// <summary>
        /// removeProductByBuyer函数的功能：访问数据库的购物车表根据买家账号删除对应的记录（删）
        /// </summary>
        /// <param name="cart">购物车对象</param>
        public void removeProductByBuyer(cart_Entity cart)
        {
            var results = buyerDB.cart_T.Where(r => r.b_account == cart.B_account).Select(r => r);
            buyerDB.cart_T.DeleteAllOnSubmit(results);
            buyerDB.SubmitChanges();
        }
        /// <summary>
        /// removeProduct函数的功能：访问数据库的购物车表根据买家账户和商品ID移除购物车表中的记录（删）
        /// </summary>
        /// <param name="cart">购物车对象</param>
        public void removeProduct(cart_Entity cart)
        {
            var results = buyerDB.cart_T.Where(r => r.b_account == cart.B_account && r.p_Id == cart.P_Id).Select(r => r);
            buyerDB.cart_T.DeleteAllOnSubmit(results);
            buyerDB.SubmitChanges();
        }
        /// <summary>
        /// Return_Cart函数的功能：访问数据库的购物车表根据买家账户查询记录（查）
        /// </summary>
        /// <param name="cart">购物车对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object Return_Cart(cart_Entity cart)
        {
            var results = buyerDB.cart_T.Where(c => c.b_account == cart.B_account).Select(c => c);
            return (object)results;
        }
        /// <summary>
        /// UpdateInformationOfCart函数的功能：根据买家账号修改购物车信息（改）
        /// </summary>
        /// <param name="cart">购物车对象</param>
        public void UpdateInformationOfCart(cart_Entity cart)
        {
            var results = buyerDB.cart_T.Where(c => c.b_account == cart.B_account).Select(c => c);
            if(results.Count()>0)
            {
                foreach(cart_T c in results)
                {
                    c.s_account = cart.S_account; ;
                    c.s_storeName = cart.S_storeName;
                    c.p_Id = cart.P_Id;
                    c.p_name = cart.P_name;
                    c.p_price = (decimal)cart.P_price;
                    c.p_num = cart.P_num;
                }
                buyerDB.SubmitChanges();
            }
        }




        //--提交计算模块--

        /// <summary>
        /// InsertToOrderItem函数的功能：访问数据库的买家订单项目表并向表中添加一条新的记录（增）
        /// </summary>
        /// <param name="orderitem">买家订单项目对象</param>
        public void InsertToOrderItem(b_order_item_Entity orderitem)
        {
            b_order_item_T items = new b_order_item_T();
            items.b_o_Id = orderitem.B_o_id;
            items.p_Id = orderitem.P_id;
            items.p_price = (decimal)orderitem.P_price;
            items.p_num = orderitem.P_num;
            buyerDB.b_order_item_T.InsertOnSubmit(items);
            buyerDB.SubmitChanges();
        }
        /// <summary>
        /// InsertToOrderState函数的功能：访问数据库的买家订单状态表并向表中添加一条新的记录（增）
        /// </summary>
        /// <param name="orderstate">买家订单状态对象</param>
        public void InsertToOrderState(b_order_state_Entity orderstate)
        {
            b_order_state_T state = new b_order_state_T();
            state.b_o_Id = orderstate.B_o_id;
            state.b_o_state = orderstate.B_o_state;
            state.b_o_subTime = DateTime.Now;
            buyerDB.b_order_state_T.InsertOnSubmit(state);
            buyerDB.SubmitChanges();
        }
        /// <summary>
        /// InsertToOrder函数的功能：访问数据库的买家订单表向表中添加一条新的记录（增）
        /// </summary>
        /// <param name="order">买家订单对象</param>
        public void InsertToOrder(b_order_Entity order)
        {
            b_order_T Order = new b_order_T();
            Order.b_account = order.B_account;
            Order.s_account = order.S_account;
            Order.s_storeName = order.S_storeName;
            Order.b_orderState = order.B_order_state;
            Order.b_o_totalPrice = (decimal)order.B_o_totalprice;
            Order.b_o_time = DateTime.Now;
            buyerDB.b_order_T.InsertOnSubmit(Order);
            buyerDB.SubmitChanges();
        }




        //--订单查询模块--

        /// <summary>
        /// orderSearchAllById函数的功能：访问数据库按订单编号查询订单详情（查）
        /// </summary>
        /// <param name="order">买家订单表对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object orderSearchAllById(b_order_Entity order)
        {
            var dataSet = buyerDB.b_order_item_T.Where(d => d.b_o_Id == order.B_o_id).Select(d => d);
            return (object)dataSet;
        }
        /// <summary>
        /// orderSearchStateById函数的功能：访问数据库按订单编号查询订单状态（查）
        /// </summary>
        /// <param name="orderstate">买家订单表对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object orderSearchStateById(b_order_state_Entity orderstate)
        {
            var dataSet = buyerDB.b_order_state_T.Where(d => d.b_o_Id == orderstate.B_o_id).Select(d => d);
            return (object)dataSet;
        }
        /// <summary>
        /// orderSearchByState函数的功能：访问数据库按订单状态查询订单的详情（查）
        /// </summary>
        /// <param name="orderstate">买家订单状态表对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object orderSearchByState(b_order_Entity orderstate)
        {
            var dataSet = buyerDB.b_order_T.Where(d => d.b_orderState == orderstate.B_order_state).Select(d=>d);
            return (object)dataSet;
        }
        /// <summary>
        /// orderSearchItem函数的功能：对买家订单项目表的查询（查）
        /// </summary>
        /// <param name="orderitem">买家订单项目表对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public object orderSearchItem(b_order_item_Entity orderitem)
        {
            var results = buyerDB.b_order_item_T.Where(r => r.b_o_Id == orderitem.B_o_id).Select(r => r);
            return (object)results;
        }





        //--买家充值--

        /// <summary>
        /// addmoney函数的功能：访问数据库根据买家的账号修改买家的账户余额（改）
        /// </summary>
        /// <param name="buyer">买家对象</param>
        public void addmoney(buyer_Entity buyer)
        {
            var results = buyerDB.buyer_T.Where(c => c.b_account.Equals(buyer.B_account));
            if (results.Count() > 0)
            {
                foreach (buyer_T buyerT in results)
                {
                    buyerT.b_balance += (decimal)buyer.B_balance;
                }
                buyerDB.SubmitChanges();
            }
        }



        //--买家查询余额--

        /// <summary>
        /// searchBalanceOfBuyer函数的功能：访问数据库根据买家的账号查询买家的账户余额
        /// </summary>
        /// <param name="buyer">买家对象</param>
        /// <returns>LINQ查询结果的集合</returns>
        public double searchBalanceOfBuyer(buyer_Entity buyer)
        {
            var balance = buyerDB.buyer_T.Where(b => b.b_account == buyer.B_account).Select(b => b.b_balance);
            
            return (double)balance.FirstOrDefault();
        }

        public int searchLatestBOrderId()
        {
            var id = (from r in buyerDB.b_order_T
                      orderby r.b_o_time descending
                     select r.b_o_Id).First();
            return int.Parse(id.ToString());
        }

        public int user_login()
        {
            throw new NotImplementedException();

        }


        /******************************订单评价***************************************/
        public void insertEvaluation(b_evaluate_Entity evaluate)
        {
            b_evaluate_T evaluation = new b_evaluate_T();
            evaluation.p_Id = evaluate.P_Id;
            evaluation.b_account = evaluate.B_account;
            evaluation.p_name = evaluate.P_name;
            evaluation.p_photo = evaluate.P_photo;
            evaluation.p_evaluate = evaluate.P_evaluate;
            buyerDB.b_evaluate_T.InsertOnSubmit(evaluation);
            buyerDB.SubmitChanges();
        }
        public string searchUrlOfProPhoto(int pid)
        {
            var Url = buyerDB.product_T.Where(u => u.p_Id == pid).Select(u => u.p_photo);
            return Url.First();
        }

        public string searchNameOfPro(int pid)
        {
            var Name = buyerDB.product_T.Where(n => n.p_Id == pid).Select(u => u.p_name);
            return Name.First();
        }

        public object searchProItmeOrder(string account)
        {
            var results = from a in buyerDB.product_T
                          join b in buyerDB.b_order_item_T on a.p_Id equals b.p_Id
                          join c in buyerDB.b_order_T on b.b_o_Id equals c.b_o_Id
                          where c.b_account==account
                          select new
                          {
                              b.b_o_Id,
                              a.p_Id,
                              a.p_name,
                              b.p_num,
                              c.b_o_totalPrice,
                              c.b_orderState,
                              c.b_o_time
                          };
            return (object)results;
        }

    }
}