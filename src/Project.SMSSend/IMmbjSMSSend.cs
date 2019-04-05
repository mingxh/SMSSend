namespace Project.SMSSend
{
    /// <summary>
    /// 短信发送
    /// </summary>
    public interface IMmbjSMSSend
    {
        /// <summary>
        /// 发送短信
        /// </summary> 
        /// <param name="sendSmsConfig"></param>
        /// <returns></returns>
        MmbjSendSmsResult SendSms(MmbjSMSConfig sendSmsConfig);
    }
}
