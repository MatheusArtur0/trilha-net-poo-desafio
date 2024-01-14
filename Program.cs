using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(Numero: "123456", Modelo: "Modelo 1", IMEI: "111111111", Memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(Numero: "4987", Modelo: "Modelo 2", IMEI: "222222222", Memoria: 128);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");