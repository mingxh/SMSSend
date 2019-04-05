using System;
using System.Collections.Generic;
using System.Text;

namespace Project.SMSSend
{
    /// <summary>
    /// 短信配置
    /// </summary>
    public abstract class MmbjSMSConfig
    {

        /// <summary>
        /// 短信模板ID
        /// 请在控制台模板管理页面模板CODE一列查看
        /// </summary>
        public string TemplateCode { get; set; }


        #region 短信内容

        /// <summary>
        /// 接收短信的手机号码
        /// </summary>
        public string PhoneNumbers  { get; set; }

        #endregion
    }
}
