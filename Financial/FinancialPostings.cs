using System;

namespace Trabalho_final.Financial

{
public class Financial_postings

{
    public Financial_postings(float cash)
    {
        if(cash > 0)
        Console.WriteLine("Entrada"); //Aqui deverá entrar a categoria que classificará o valor

        else
        Console.WriteLine("Saída");
        

        Cash = cash;
    }

    public float Cash { get; }
    }
}    