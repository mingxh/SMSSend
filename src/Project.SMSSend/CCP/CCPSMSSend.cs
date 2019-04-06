using System;
using System.Collections.Generic;
using System.Text;
using Project.SMSSend.CCP.CCPResponse;

namespace Project.SMSSend.CCP
{
    /// <summary>
    /// 容联云通信短信发送
    /// </summary>
    public class CCPSMSSend : IMmbjSMSSend
    {
        #region Implementation of IMmbjSMSSend

        /// <summary>
        /// 发送短信
        /// </summary> 
        /// <param name="config"></param>
        /// <returns></returns>
        public MmbjSendSmsResult SendSms(MmbjSMSConfig config)
        {
            //类型不可转换，那么报错
            if (!(config is CCPSendSMSConfig sendSmsConfig))
                throw new ArgumentException("参数类型传输错误");


            CCPRestSDK api = new CCPRestSDK();
            //ip格式如下，不带https://
            bool isInit = api.init(sendSmsConfig.RestAddress, sendSmsConfig.RestPort);
            api.setAccount(sendSmsConfig.AccountSid, sendSmsConfig.AccountToken);
            api.setAppId(sendSmsConfig.AppId);

            try
            {
                if (isInit)
                {
                    CCPResponseStatus ccpResponseStatus = api.SendTemplateSMS(sendSmsConfig.PhoneNumbers, sendSmsConfig.TemplateCode, sendSmsConfig.Params);

                    return new CCPSendSmsResult()
                    {
                        Code = ccpResponseStatus.StatusCode == "000000" ? "OK" : ccpResponseStatus.StatusCode,
                        Message = ccpResponseStatus.StatusMsg,
                        RequestId = ccpResponseStatus.TemplateSMS?.SmsMessageSid??""
                    };

                }
                else
                {
                    return new CCPSendSmsResult()
                    {
                        Message = "初始化失败",
                        Code = "AliServerError",
                        RequestId = string.Empty
                    };
                }
            }
            catch (Exception exc)
            {
                return new CCPSendSmsResult()
                {
                    Message = "运行错误",
                    Code = "AliServerError",
                    RequestId = string.Empty
                };
            }
        }
        #endregion
    }
}
