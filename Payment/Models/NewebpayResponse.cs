﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Models
{
    /// <summary>
    /// [藍新金流]介接資料模型
    /// </summary>
    public class NewebpayResponse
    {

        /// <summary>
        /// 商店代號
        /// </summary>
        public string MerchantID { get; set; }

        /// <summary>
        /// 交易資料AES 加密
        /// </summary>
        public string TradeInfo { get; set; }

        /// <summary>
        /// 交易資料SHA256 加密
        /// </summary>
        public string TradeSha { get; set; }

        /// <summary>
        /// 串接程式版本
        /// </summary>
        public string Version { get; set; }
    }
}
