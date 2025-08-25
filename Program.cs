using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone(numero: "12345", modelo: "Modelo 1", imei: "12223333", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "15835", modelo: "Modelo 1", imei: "1227533", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");