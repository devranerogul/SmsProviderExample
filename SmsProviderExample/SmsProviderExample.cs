//Devran Erogul
//Xpoda Inc.
//21.07.2023
//www.xpoda.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace name is not used, choose a name that is relevant to your project. 
namespace XpodaSmsProvider
{
    // You should implement this interface in your project in class named "SmsProvider"
    public interface ISmsProvider
    {
        string SendSms(string number, string content, string header, string username, string password);
    }

    // IMPORTANT : Class name should be "SmsProvider"
    public class SmsProvider : ISmsProvider
    {
        public string SendSms(string number, string content, string header, string username, string password)
        {

            // Do actual implementation here
            // Connect Sms gateway and relay sms
            // Use arguments provided: number, content, header (Xpoda or your company name) , username, password.            
            return String.Format("tx id : {0}, input arguments: {1}, {2}, {3}, {4}, {5}", Guid.NewGuid().ToString(),
                number,
                content,
                header,
                username,
                password);        
        }
    }


}
