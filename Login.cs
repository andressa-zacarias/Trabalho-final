using System;
using TrabalhoFinal.User;
using TrabalhoFinal.Processing;


namespace TrabalhoFinal
{
public class Login
{
    
     public bool success = true;

       public void Run()
       {
            
            
            //validar se tem o cadastro com um bool
            //caso acerte a senha prosseguir
            //tem cadastro e a senha é validada, entrar
            //tem cadastro mas a senha é invalida, tentar novamente
            //
            
          Console.WriteLine("Type your e-mail:");
          string email = Console.ReadLine();
          var mail = new Email(email);           
          Console.WriteLine("{0}", mail.Value);
                        

       }
}
}