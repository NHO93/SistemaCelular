﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// DONE
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(".......Nokia.......\n");
        Nokia nk123 = new Nokia("000145", "NK123", "305460516516051651", 256); // TODO: Instanciar um Nokia
        nk123.InstalarAplicativo("WhatsApp"); //  TODO: Instalar o WhatsApp
        nk123.Ligar(); //   TODO: Ligar
        nk123.ReceberLigacao(); //  TODO: Receber uma ligação

        Console.WriteLine("\n.......Iphone......\n");
        Iphone iphone5S = new Iphone("145000", "iphone5S", "1561506151615064503", 652); // TODO: Instanciar um Iphone
        iphone5S.InstalarAplicativo("Instagram"); //    TODO: Instalar o Instagram
        iphone5S.Ligar(); // TODO: Ligar
        iphone5S.ReceberLigacao(); //   TODO: Receber uma ligação
    }
}
