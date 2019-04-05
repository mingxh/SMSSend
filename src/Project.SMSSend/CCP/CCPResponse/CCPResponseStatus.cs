using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SMSSend.CCP.CCPResponse
{
    /// <summary>
    /// 容联云通讯 返回状态
    /// </summary>
    public class CCPResponseStatus
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string StatusCode { get; set; } = "000000";

        /// <summary>
        /// 消息
        /// </summary>
        public string Message { get; set; } = "成功";

        /// <summary>
        /// 附加数据
        /// </summary>
        public Dictionary<string, object> Data { get; set; } = new Dictionary<string, object>();

        /// <summary>
        /// 短信数据
        /// </summary>
        public TemplateSMS TemplateSMS { get; set; }

    }
}
