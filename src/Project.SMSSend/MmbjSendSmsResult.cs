using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SMSSend
{
    /// <summary>
    /// 短信发送结果
    /// </summary>
    public class MmbjSendSmsResult
    {
        /// <summary>
        /// 发送回执ID，可根据该ID在接口QuerySendDetails中查询具体的发送状态。
        /// </summary>
        public string BizId { get; set; }

        /// <summary>
        /// 请求状态码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 状态码的描述
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        public string RequestId { get; set; }
    }
}
