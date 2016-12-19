using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;

namespace InterService
{
    public class adminIntSer
    {
        adminDA adminDataTask = new adminDA();
        /// <summary>
        /// 查询所有卖家
        /// </summary>
        /// <returns></returns>
        public object searchAllSeller()
        {
            return adminDataTask.searchAllSeller();
        }
        /// <summary>
        /// 根据账号查询卖家
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public object searchSellerByAccount(string account)
        {
            return adminDataTask.searchSellerByAccount(account);
        }
        /// <summary>
        /// 查询所有买家
        /// </summary>
        /// <returns></returns>
        public object searchAllBuyer()
        {
            return adminDataTask.searchAllBuyer();
        }
        /// <summary>
        /// 根据账号查询买家
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public object searchBuyerByAccount(string account)
        {
            return adminDataTask.searchBuyerByAccount(account);
        }
        /// <summary>
        /// 根据订单编号查询买家订单
        /// </summary>
        /// <param name="buyAccount"></param>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public object searchBOrderByOrderId(int OrderId)
        {
            return adminDataTask.searchBOrderByOrderId(OrderId);
        }
        /// <summary>
        /// 根据订单编号查询卖家订单
        /// </summary>
        /// <param name="sellAccount"></param>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public object searchSOrderByOrderId(int OrderId)
        {
            return adminDataTask.searchSOrderByOrderId(OrderId);
        }
    }
}