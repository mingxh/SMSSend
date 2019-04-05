using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SMSSend.CCP.CCPResponse
{
    /// <summary>
    /// 容联云通讯返回数据
    /// </summary>
    public class TemplateSMS
    {
        /// <summary>
        /// 创建时间 20130201155306
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// 短信Id
        /// </summary>
        public string SmsMessageSid { get; set; }
    }
}
