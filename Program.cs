using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia - ");
Smartphone nokia = new Nokia(numero: "0001", modelo: "Nokia 3310", imei: "00000000", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone - ");
Smartphone iphone = new Iphone(numero: "0002", modelo: "Iphone 9", imei: "00000000", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");