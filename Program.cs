﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// DONE
class Program
{
    public static void Main(string[] args)
    {
        Nokia nk123 = new Nokia("000145", "NK123", "305460516516051651", 256);
        nk123.InstalarAplicativo("WhatsApp");

        Iphone iphone5S = new Iphone("145000", "iphone5S", "1561506151615064503", 652);
        iphone5S.InstalarAplicativo("Instagram");
    }
}
