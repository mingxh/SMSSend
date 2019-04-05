using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using NUnit.Framework;
using Project.SMSSend;
using Project.SMSSend.Aliyun;
using Project.SMSSend.CCP;

namespace MmbjSmsSend.NUnitTest
{
    class CCPSmsSendTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IMmbjSMSSend ccpsmsSend = new CCPSMSSend();

            var result = ccpsmsSend.SendSms(new CCPSendSMSConfig()
            {
                RestAddress = "app.cloopen.com",
                RestPort = "8883",
                AppId = "xxxx",
                AccountSid = "xxxx",
                AccountToken = "xxxx",

                PhoneNumbers = "13312345678",
                TemplateCode = "123456",
                Params = new string[] { new Random().Next(100000, 999999).ToString("D6"), "3" }
            });


            Assert.AreEqual(result.Code, "OK");
        }
    }
}
