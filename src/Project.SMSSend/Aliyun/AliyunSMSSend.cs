using System;
using System.Collections.Generic;
using System.Text;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Newtonsoft.Json;
using Project.SMSSend.Aliyun;

namespace Project.SMSSend.Aliyun
{
    /// <summary>
    /// 阿里云短信接入
    /// </summary>
    public class AliyunSMSSend : IMmbjSMSSend
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
            if (!(config is AliyunSendSMSConfig sendSmsConfig))
                throw new ArgumentException("参数类型传输错误");


            var regionId = string.IsNullOrWhiteSpace(sendSmsConfig.RegionId)
                ? "default"
                : sendSmsConfig.RegionId.Trim();

            IClientProfile profile = DefaultProfile.GetProfile(sendSmsConfig.RegionId, sendSmsConfig.AccessKeyId, sendSmsConfig.AccessSecret);
            DefaultAcsClient client = new DefaultAcsClient(profile);
            CommonRequest request = new CommonRequest();
            request.Method = MethodType.POST;
            request.Domain = "dysmsapi.aliyuncs.com";
            request.Version = "2017-05-25";
            request.Action = "SendSms";
            // request.Protocol = ProtocolType.HTTP;

            request.AddQueryParameters("PhoneNumbers", sendSmsConfig.PhoneNumbers);
            request.AddQueryParameters("SignName", sendSmsConfig.SignName);
            request.AddQueryParameters("TemplateCode", sendSmsConfig.TemplateCode);
            request.AddQueryParameters("TemplateParam", sendSmsConfig.TemplateParam);
            request.AddQueryParameters("SmsUpExtendCode", sendSmsConfig.SmsUpExtendCode);
            request.AddQueryParameters("OutId", sendSmsConfig.OutId);
            try
            {
                CommonResponse response = client.GetCommonResponse(request);
                //Console.WriteLine(System.Text.Encoding.Default.GetString(response.HttpResponse.Content));
                return JsonConvert.DeserializeObject<AliyunSendSmsResult>(response.Data);
            }
            catch (ServerException e)
            {
                Console.WriteLine(e);
                return new AliyunSendSmsResult()
                {
                    Message = "短信服务器错误",
                    Code = "AliServerError",
                    RequestId = string.Empty
                };
            }
            catch (ClientException e)
            {
                Console.WriteLine(e);
                return new AliyunSendSmsResult()
                {
                    Message = "短信客户端错误",
                    Code = "AliClientError",
                    RequestId = string.Empty
                };
            }
        }

        #endregion
    }
}
