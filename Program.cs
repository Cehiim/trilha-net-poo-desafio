using DesafioPOO.Models;

Console.WriteLine("\nTestando Nokia:");
Nokia meuNokia = new Nokia("123-456", "Nokia 3310", "001122334455", 64);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\nTestando Iphone:");
Iphone meuIphone = new Iphone("789-101", "iPhone 13", "998877665544", 128);
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Instagram");