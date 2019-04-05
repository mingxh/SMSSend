using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SMSSend.CCP
{
    /// <summary>
    /// 容联云通讯短信配置
    /// </summary>
    public class CCPSendSMSConfig : MmbjSMSConfig
    {
        /// <summary>
        /// REST连接地址 ip格式如下，不带https://
        /// api.init("app.cloopen.com", "8883");
        /// </summary>
        public string RestAddress { get; set; }

        /// <summary>
        /// REST 端口
        /// </summary>
        public string RestPort { get; set; }

        /// <summary>
        /// 主帐号
        /// </summary>
        public string AccountSid { get; set; }

        /// <summary>
        /// 主账号令牌
        /// </summary>
        public string AccountToken { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 发送的参数
        /// </summary>
        public string[] Params { get; set; }

    }
}
