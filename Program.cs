using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: \n");
Smartphone nokia = new Nokia(numero: "(11)9999-9999",modelo:"Modelo 1",imei:"1111111dasd1",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");
nokia.ReceberLigacao();

Console.WriteLine("\nSmartphone Iphone: \n");
Smartphone iphone = new Iphone(numero: "(11)8888-8888",modelo:"Modelo X",imei:"1222222dasd1",memoria:128);
iphone.Ligar();
iphone.InstalarAplicativo("Android Virtual");
iphone.ReceberLigacao();