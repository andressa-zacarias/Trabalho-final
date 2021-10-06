using System;
using System.Text.RegularExpressions;

namespace TrabalhoFinal.User
{
    public class Password
    {
        public Password(string valuePassword)
        {
            Regex cpfPattern = new Regex(@"[0-9]{6}");
            if (!cpfPattern.IsMatch(valuePassword))
            {
                throw new Exception($"Invalid Password: {valuePassword}.");
            }
            
            Value = valuePassword;
        }

        public string Value { get; set; }
    }
}