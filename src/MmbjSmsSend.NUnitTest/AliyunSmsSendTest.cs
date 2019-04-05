using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;
using Project.SMSSend;
using Project.SMSSend.Aliyun;

namespace MmbjSmsSend.NUnitTest
{
    /// <summary>
    /// 阿里云发送短信测试
    /// </summary>
    public class AliyunSmsSendTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IMmbjSMSSend aliyunSmsSend = new AliyunSMSSend();

            var result = aliyunSmsSend.SendSms(new AliyunSendSMSConfig()
            {
                AccessKeyId = "xxxx",
                AccessSecret = "xxxxx",
                Action = "SendSms",
                PhoneNumbers = "13312345678",
                SignName = "xxxxx",
                TemplateCode = "xxxxx",
                TemplateParam = JsonConvert.SerializeObject(new { code = new Random().Next(100000, 999999).ToString("D6") })
            });


            Assert.AreEqual(result.Code, "OK"); 
        }
    }
}
