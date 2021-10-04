using System;
using System.Text.RegularExpressions;

namespace TrabalhoFinal.User
{
    public class Email
    {
        public Email(string valueEmail)
        {
            Regex emailPattern = new Regex(@"^[a-zA-Z0-9.!#$%&'*+=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
            if (!emailPattern.IsMatch(valueEmail))
            {
                throw new Exception($"Invalid E-mail: {valueEmail}.");
            }
            
            Value = valueEmail;
        }

        public string Value { get; }
    }
}
