using System;
using System.Text.RegularExpressions;

namespace TrabalhoFinal.User
    {
    public class Cpf
    {
        public Cpf(string value)
        {
            Regex cpfPattern = new Regex(@"[0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2}|[0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2}");
            if (!cpfPattern.IsMatch(value))
            {
                throw new Exception($"Invalid CPF: {value}.");
            }
            
            Value = value;
        }

        public string Value { get; }
    }
}

