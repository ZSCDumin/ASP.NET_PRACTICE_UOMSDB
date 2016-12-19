using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccess
{
    public class adminDA
    {
        UOMSDBDataContext sellDB = new UOMSDBDataContext();
        /// <summary>
        /// 管理员
        /// </summary>
        /// <returns></returns>
        public object searchAllSeller()
        {
            return sellDB.seller_T.Select(c => c);
        }
        public object searchSellerByAccount(string account)
        {
            return sellDB.seller_T.Select(c => c.s_account.Equals(account));
        }
        public object searchAllBuyer()
        {
            return sellDB.buyer_T.Select(c => c);
        }
        public object searchBuyerByAccount(string account)
        {
            return sellDB.buyer_T.Select(c => c.b_account.Equals(account));
        }
        public object searchBOrderByOrderId(int OrderId)
        {
            var result = from ot in sellDB.b_order_T
                         join it in sellDB.b_order_item_T on ot.b_o_Id equals it.b_o_Id
                         select new
                         {
                             ot.b_o_Id,
                             ot.s_storeName,
                             ot.s_account,
                             //ot.b_o_totalprice,
                             ot.b_account,
                             it.p_Id,
                             it.p_price,
                             it.p_num,
                         };
            return result;

        }
        public object searchSOrderByOrderId(int OrderId)
        {
            var result = from ot in sellDB.s_order_T
                         join it in sellDB.b_order_item_T on ot.s_o_Id equals it.b_o_Id
                         select new
                         {
                             ot.s_o_Id,
                             ot.s_account,
                             ot.s_o_totalprice,
                             ot.b_account,
                             it.p_Id,
                             it.p_price,
                             it.p_num,
                             ot.s_o_time,
                         };
            return result;
        }
    }
}