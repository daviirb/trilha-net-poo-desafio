using DesafioPOO.Models;

Console.WriteLine("Telefone Nokia:");
Smartphone nokia = new Nokia(numero: "27999784617", modelo: "Modelo 1", imei: "012939892ISDAD", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Telefone IPhone:");
Smartphone iphone = new Iphone(numero: "27999784617", modelo: "Modelo 1", imei: "012939892ISDAD", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");