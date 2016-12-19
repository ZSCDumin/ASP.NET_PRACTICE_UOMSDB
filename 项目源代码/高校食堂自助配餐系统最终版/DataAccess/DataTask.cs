 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.IO;
using Entity;

namespace DataAccess
{
     
    public class DataTask:System.Web.UI.Page
    {
        string selectStr;
        UOMSDBDataContext sellDB = new UOMSDBDataContext();
        PagedDataSource pds = new PagedDataSource();
        /// <summary>
        /// 绑定首页要展示的是商品的数据
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        /// 
        protected object ProDataBind(int currentPage)
        {
            string str = "Data Source=.;Initial Catalog=UOMSDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            pds.AllowPaging = true;
            pds.PageSize = 6;
            pds.CurrentPageIndex = currentPage;
             selectStr = "select * from Product";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(selectStr, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            pds.DataSource = ds.Tables[0].DefaultView;
            con.Close();
            return pds;
            
        }
        /// <summary>
        /// 这个方法是当用户点击翻页（首页/尾页/上/下一页）的时候用的
        /// </summary>
        /// <param name="e">被点击的DataList</param>
        /// <param name="currentPageIndex">显示当前页数的控件上的值</param>
        /// <param name="totalPageCount">显示总页数的控件上的值</param>
        public void ProductFlip(DataListCommandEventArgs e, string currentPageIndex, string totalPageCount)
        {
            switch (e.CommandName)
            {
                case "首页":
                    pds.CurrentPageIndex = 0;
                    currentPageIndex = 1.ToString();
                    ProDataBind(pds.CurrentPageIndex);
                    break;
                case "上一页":
                    pds.CurrentPageIndex = int.Parse(currentPageIndex) - 2;
                    currentPageIndex = (pds.CurrentPageIndex + 1).ToString();
                    ProDataBind(pds.CurrentPageIndex);
                    break;
                case "下一页":
                    pds.CurrentPageIndex = Int32.Parse(currentPageIndex);
                    currentPageIndex = (pds.CurrentPageIndex + 1).ToString();
                    ProDataBind(pds.CurrentPageIndex);
                    break;
                case "尾页":
                    pds.CurrentPageIndex = Int32.Parse(currentPageIndex) - 1;
                    currentPageIndex = (pds.CurrentPageIndex + 1).ToString();
                    ProDataBind(pds.CurrentPageIndex);
                    break;
            }
        }
        
        /// <summary>
        /// 通过账号和密码验证用户是否存在，存在返回true运行登录，否则拒绝登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public bool userExist(string account, string passWord)
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(account) && c.s_password.Equals(passWord));
            if (results.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 创建卖家用户
        /// </summary>
        /// <param name="seller"></param>
        /// <returns></returns>
        /// 
        public bool createSell(seller_Entity sellT)
        {
            seller_T  a = new seller_T();
            a.s_account = sellT.S_account;
            a.s_answer = sellT.S_answer;
            a.s_name = sellT.S_name;
            a.s_password = sellT.S_password;
            a.s_profit = (decimal)sellT.S_profit;
            a.s_question = sellT.S_question;
            a.s_state = sellT.S_state;
            a.s_storeName = sellT.S_storeName;
            a.s_tel = sellT.S_tel;
            //seller_T是卖家表的对象，seller代表卖家的一个对象
            sellDB.seller_T.InsertOnSubmit(a);
            sellDB.SubmitChanges();
            createFolder(a.s_account);
            return true;
        }

        /// <summary>
        /// 根据账号查询用户是否已存在，在注册的时候验证输入的账号是否已被注册，已经被注册返回true，反之返回false
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool userExist(string account)
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(account));
            if (results.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 改变密码,成功返回true，反之false
        /// </summary>
        /// <param name="account"></param>
        /// <param name="newPassWord"></param>
        public bool changePassWord(string account, string newPassWord)
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(account));
            if (results.Count() > 0)
            {
                foreach (seller_T r in results)
                {
                    r.s_password = newPassWord;
                }
                sellDB.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 验证问题答案
        /// </summary>
        /// <param name="account"></param>
        /// <param name="newPassWord"></param>
        /// <param name="question"></param>
        /// <param name="ansewer"></param>
        public bool testAnswer(string account,  string question, string ansewer)
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(account) && c.s_answer.Equals(ansewer));
            if (results.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 显示卖家安全问题
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public string showQuestion(string account )
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(account)).Select(c => c.s_question);

            return results.FirstOrDefault() ;
        }

        public bool changeUserInfo(string account, string telephone, string storeName)
        {
            seller_T sellT = new DataAccess.seller_T();
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(account));
            if (results.Count() > 0)
            {
                foreach (seller_T r in results)
                {
                    r.s_storeName = storeName;
                    r.s_tel = telephone;
                }
                sellDB.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal inquireBalance(string sellAccount)
        {
            return sellDB.seller_T.Where(c => c.s_account.Equals(sellAccount)).Select(c => c.s_profit).FirstOrDefault();
        }
        public decimal inquireTotalProfit(string sellAccount)
        {
            decimal money = sellDB.s_order_T.Where(p => p.s_account.Equals(sellAccount)).Sum(c => c.s_o_totalprice);
            return money;
        }
        public decimal inquireProfit(string sellAccount, DateTime startTime, DateTime endTime)
        {
            var money = sellDB.s_order_T.Where(c => c.s_account.Equals(sellAccount) && (c.s_o_time >= startTime && c.s_o_time <= endTime));
            decimal res = 0;
            if(money.Count()>0)
            { 
                res =  money.Sum(c => c.s_o_totalprice);
            }
            return res;
            
        }

        //以下是商品模块功能
        public product_Entity inquireProById(string account, int ProId)
        {
            product_T product = new product_T();
            product_Entity product_E = new product_Entity();
            product =  sellDB.product_T.Where(c => c.s_account.Equals(account)&&c.p_Id.Equals(ProId)).First();
            product_E.P_Id = product.p_Id;
            product_E.P_name = product.p_name;
            product_E.P_photo = product.p_photo;
            product_E.P_price = (double)product.p_price;
            product_E.P_cNum = product.p_cNum;
            product_E.P_saleNum = product.p_saleNum;
            product_E.P_category = product.p_category;
            return product_E;
        }


        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="sellAccount"></param>
        /// <param name="product"></param>
        public void addProduct(product_Entity product,FileUpload e)
        {
            product_T productT = new product_T();
            productT.s_account = product.S_account;
            productT.p_name = product.P_name;
            productT.p_category = product.P_category;
            productT.p_price = (decimal)product.P_price;
            productT.p_cNum = product.P_cNum;
            productT.p_photo ="~/Images/"+ product.S_account+"/"+e.FileName+"";
            sellDB.product_T.InsertOnSubmit(productT);
            upLoadPhoto(e, product.S_account);
            sellDB.SubmitChanges();
        }
        /// <summary>
        /// 通过卖家商品的ID，删除商品
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="sellerAccount"></param>
        public bool removeProduct(int productId, string sellerAccount)
        {
            var results = sellDB.product_T.Where(p => p.p_Id.Equals(productId) && p.s_account.Equals(sellerAccount));
            if (results.Count() > 0)
            {
                sellDB.product_T.DeleteAllOnSubmit(results);
                sellDB.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
       
        //以下是订单管理模块功能

        /// <summary>
        /// 通过卖家账号查询所有订单
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <returns></returns>
        public object inquireAllOrder(string sellerAccount)
        {
            var results = from orderTable in sellDB.s_order_T.Where(c => c.s_account.Equals(sellerAccount))
                          join orderItem in sellDB.s_order_item_T
                          on orderTable.s_o_Id equals orderItem.s_o_Id
                          select new
                          {
                              orderTable.s_o_Id,
                              orderTable.b_account,
                              orderTable.s_o_state,
                              orderTable.s_o_totalprice,
                              orderTable.s_o_time,
                              orderItem.p_Id,
                              orderItem.p_price,
                              orderItem.p_num
                          };
            return results;
        }
        /// <summary>
        /// 根据当前登录的买家账号通过订单Id进行订单
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="productId"></param>
        /// <returns></returns>
        public object inquireOrderByProId(string sellerAccount, int orderId)
        {
            var results = from ot in sellDB.s_order_T.Where(ot => ot.s_account.Equals(sellerAccount) && ot.s_o_Id.Equals(orderId))
                          join oitem in sellDB.s_order_item_T on ot.s_o_Id equals oitem.s_o_Id
                          select ot;//这里可能需要修改
            return results;
        }
        /// <summary>
        /// 根据当前登录卖家的账号和订单状态查询
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public object inquireOrderByState(string sellerAccount, string state)
        {
            var results = from ot in sellDB.s_order_T.Where(ot => ot.s_account.Equals(sellerAccount) && ot.s_o_state.Equals(state))
                          join oitem in sellDB.s_order_item_T on ot.s_o_Id equals oitem.s_o_Id
                          select ot;//这里可能需要修改
            return results;
        }
        /// <summary>
        /// 操作订单（接单，退款等），即改变订单的状态
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="orderId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool orderOperator(string sellerAccount, int orderId, string state)
        {
            var results = sellDB.s_order_T.Where(ot => ot.s_account.Equals(sellerAccount) && ot.s_o_Id.Equals(orderId));
            if (results.Count() > 0)
            {
                foreach (s_order_T ot in results)
                {
                    ot.s_o_state = state;
                }
                sellDB.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 添加卖家余额
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool addBalance(string sellerAccount, decimal sum)
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(sellerAccount));
            if (results.Count() > 0)
            {
                foreach (seller_T sellerT in results)
                {
                    sellerT.s_profit += sum;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 减少余额
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool reduceBalance(string sellerAccount, decimal sum)
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(sellerAccount));
            if (results.Count() > 0)
            {
                foreach (seller_T sellerT in results)
                {
                    sellerT.s_profit -= sum;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 插入图片
        /// </summary>
        /// <param name="sellAccount"></param>
        private void createFolder(string sellAccount)
        {
            Directory.CreateDirectory(Server.MapPath("~/Images/") + sellAccount);

        }

        public void upLoadPhoto(FileUpload e, string sellAccount)
        {
            if (Directory.Exists(Server.MapPath("~/Images/" + sellAccount)))//如果存在用户文件夹
            {
                int i = 0;
                string oldFileName = e.FileName;
                string newFileName = oldFileName;

                while (File.Exists(Server.MapPath("~/Images/" + sellAccount + "/" + newFileName)))
                {
                    newFileName = oldFileName.Insert(oldFileName.LastIndexOf("."), i.ToString());
                    i++;
                }
               e.SaveAs(Server.MapPath("~/Images/" + sellAccount + "/" + newFileName));
               
            }
            else
            {
                createFolder(sellAccount);//不存在用户文件夹则创建
                upLoadPhoto(e, sellAccount);//不存在先创建文件夹，然后再回调一次.
            }
        }

      
        public bool updateProInfo(string sellerAccount,product_Entity product, FileUpload e)
        {
            var results = sellDB.product_T.Where(c => c.p_Id.Equals(product.P_Id) && c.s_account.Equals(sellerAccount));
            if (results.Count() > 0)
            {
                if (e.FileName != "")
                {
                    foreach (product_T p in results)
                    {
                        p.p_name = product.P_name;
                        p.p_price = decimal.Parse(product.P_price.ToString());
                        p.p_cNum = product.P_cNum;
                        p.p_category = product.P_category;
                        upLoadPhoto(e, sellerAccount);
                    }
                    sellDB.SubmitChanges();
                }
                else
                {
                    foreach (product_T p in results)
                    {
                        p.p_name = product.P_name;
                        p.p_price = decimal.Parse(product.P_price.ToString());
                        p.p_cNum = product.P_cNum;
                        p.p_category = product.P_category;
                    }
                    sellDB.SubmitChanges();
                }
                return true;
            }
            else
            { return true; }
        }
        
        /// <summary>
        /// 按卖家账号查询商品
        /// </summary>
        /// <param name="s_account"></param>
        /// <returns></returns>
        public object Searchgood(string s_account)
        {
            var results = from r in sellDB.product_T
                          where r.s_account == s_account
                          select r;
            return results;
        }
        public int searchProCNum(int productID)
        {
            return sellDB.product_T.Where(c => c.p_Id.Equals(productID)).Select(p => p.p_cNum).FirstOrDefault();
        }

        /// <summary>
        /// 查询卖家信息
        /// </summary>
        /// <param name="s_account"></param>
        /// <returns></returns>
        public object SearchSellinformation(string s_account)
        {
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(s_account)).First();
            return (seller_T)results;
        }

        public bool changeUserInfo(seller_Entity sell)
        {
            seller_T sellT = new DataAccess.seller_T();
            var results = sellDB.seller_T.Where(c => c.s_account.Equals(sell.S_account));
            if (results.Count() > 0)
            {
                foreach (seller_T r in results)
                {
                    r.s_storeName = sell.S_storeName;
                    r.s_tel = sell.S_tel;
                    r.s_question = sell.S_question;
                    r.s_answer = sell.S_answer;
                    r.s_name = sell.S_name;
                }
                sellDB.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}