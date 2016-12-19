using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
using Entity;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace InterService
{
    public class SellService:System.Web.UI.Page
    {
        DataTask db = new DataTask();

        /// <summary>
        /// 通过账号和密码验证用户是否存在，存在返回true运行登录，否则拒绝登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public bool landing(string account,string passWord)
        {
            return db.userExist(account,passWord);       
        }
        public int searchProCNum(int productID)
        {
            return db.searchProCNum(productID);
        }
        /// <summary>
        /// 根据账号查询用户是否已存在，在注册的时候验证输入的账号是否已被注册，已经被注册返回true，反之返回false
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public bool exist(string account)
        {
            return db.userExist(account);
        }

        /// <summary>
        /// 创建卖家用户
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool create(seller_Entity a)
        {
            return db.createSell(a);
        }

        /// <summary>
        /// 改变密码,成功返回true，反之false  
        /// </summary>
        /// <param name="account"></param>
        /// <param name="newPassWord"></param>
        /// <returns></returns>
    
        public bool change(string account, string newPassWord)
        {
            return db.changePassWord(account, newPassWord);
        }

        /// <summary>
        /// 验证问题答案
        /// </summary>
        /// <param name="account"></param>
        /// <param name="question"></param>
        /// <param name="ansewer"></param>
        /// <returns></returns>
        public bool check(string account, string question, string ansewer)
        {
            return db.testAnswer(account, question, ansewer);
        }

        /// <summary>
        /// 显示卖家安全问题
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public string show(string account)
        {
            return db.showQuestion(account);
        }

        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="a"></param>
        /// <param name="e"></param>
        public void add(product_Entity a,FileUpload e)
        {
            /*product_T b = new product_T();*/
            db.addProduct(a,e);
        }

        /// <summary>
        /// 通过卖家商品的ID，删除商品
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="sellerAccount"></param>
        /// <returns></returns>
        public bool remove(int productId, string sellerAccount)
        {
            return db.removeProduct(productId, sellerAccount);
        }

        //以下是订单管理模块功能
        /// <summary>
        /// 通过卖家账号查询所有订单
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <returns></returns>
        public object searchAllOrder(string sellerAccount)
        {
            return db.inquireAllOrder(sellerAccount);
        }

        /// <summary>
        /// 根据当前登录的买家账号通过订单Id进行订单
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public object OrderByProId(string sellerAccount, int orderId)
        {
            return db.inquireOrderByProId(sellerAccount, orderId);
        }

        /// <summary>
        /// 操作订单（接单，退款等），即改变订单的状态
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="orderId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool changeOrderOperator(string sellerAccount, int orderId, string state)
        {
            return db.orderOperator(sellerAccount, orderId, state);
        }

        /// <summary>
        /// 添加卖家余额
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool AddBalance(string sellerAccount, decimal sum)
        {
            return db.addBalance(sellerAccount, sum);
        }

        /// <summary>
        /// 减少余额
        /// </summary>
        /// <param name="sellerAccount"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool ReduceBalance(string sellerAccount, decimal sum)
        {
            return db.reduceBalance(sellerAccount, sum);
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="a"></param>
        /// <param name="s_account"></param>
        /// <param name="e"></param>
        public bool updateProInfo(string sellerAccount, product_Entity product, FileUpload e)
        {
            return db.updateProInfo(sellerAccount, product, e);
        }

        /// <summary>
        /// 按卖家账号查询商品
        /// </summary>
        /// <param name="s_account"></param>
        /// <returns></returns>
        public object Searchgood(string s_account)
        {
            return db.Searchgood(s_account);
        }

        /// <summary>
        /// 查询卖家信息
        /// </summary>
        /// <param name="s_account"></param>
        /// <returns></returns>
        public object SearchSellinformation(string s_account)
        {

            return (seller_T)db.SearchSellinformation(s_account);
        }

        public bool changeUserInfo(seller_Entity sell)
        {
            return db.changeUserInfo(sell);
        }

        /// <summary>
        /// 查询时间段卖家盈利
        /// </summary>
        /// <param name="sellAccount"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public decimal inquireProfit(string sellAccount, DateTime startTime, DateTime endTime)
        {
            return db.inquireProfit(sellAccount, startTime, endTime);
        }

        public product_Entity inquireProById(string account, int ProId)
        {
            return db.inquireProById(account, ProId);
        }
     }
}