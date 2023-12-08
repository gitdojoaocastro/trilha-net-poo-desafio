using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("62982263485", "Nokia 2630", "8945415321", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("62987442147", "Iphone XR", "9854454525", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Duolingo");
