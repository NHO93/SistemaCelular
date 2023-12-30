﻿using DesafioPOO.Models;

// TRealizar os testes com as classes Nokia e Iphone

class Program
{ protected Program() {} // Construtor protegido
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia: ");
        Nokia nk123 = new Nokia(numero: "1234567891011", modelo: "NK123", imei: "305460516516051651", memoria: 256); // Instanciar um Nokia
        nk123.InstalarAplicativo("WhatsApp"); // Instalar o aplicativo
        nk123.Ligar(); // Ligar
        nk123.ReceberLigacao(); // Receber uma ligação
        
        Console.WriteLine("\n.....................................\n");

        Console.WriteLine("Smartphone iPhone: ");
        Iphone iphone5S = new Iphone(numero: "01234567891112", modelo: "iphone5S", imei: "1561506151615064503", memoria: 652); // Instanciar um Iphone
        iphone5S.InstalarAplicativo("Instagram"); // Instalar o aplicativo
        iphone5S.Ligar(); //Ligar
        iphone5S.ReceberLigacao(); // Receber uma ligação
    }
}
