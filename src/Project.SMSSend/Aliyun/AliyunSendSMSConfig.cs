using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SMSSend.Aliyun
{
    /// <summary>
    /// 阿里云短信发送配置
    /// </summary>
    public class AliyunSendSMSConfig: MmbjSMSConfig
    { 
        /// <summary>
        /// 主账号AccessKey的ID
        /// </summary>
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 访问密钥
        /// </summary>
        public string AccessSecret { get; set; }


        /// <summary>
        /// 区域
        /// </summary>
        public string RegionId { get; set; } = "default";
         
        /// <summary>
        /// 短信签名名称
        /// 请在控制台签名管理页面签名名称一列查看
        /// </summary>
        public string SignName { get; set; }

        /// <summary>
        /// 系统规定参数。取值：SendSms
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// 外部流水扩展字段
        /// </summary>
        public string OutId { get; set; }

        /// <summary>
        /// 上行短信扩展码，无特殊需要此字段的用户请忽略此字段。
        /// </summary>
        public string SmsUpExtendCode { get; set; }

        /// <summary>
        /// 短信模板变量对应的实际值，JSON格式。
        /// </summary>
        public string TemplateParam { get; set; }
    }
}
