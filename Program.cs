using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone15 = new Iphone("19971359432", "15", "123456789", 15);
Nokia nokia1 = new Nokia("19971351234", "Tijolo", "987654321", 1);

iphone15.Ligar();
nokia1.ReceberLigacao();

nokia1.Ligar();
iphone15.ReceberLigacao();

iphone15.InstalarAplicativo("facebook");
nokia1.InstalarAplicativo("facebook");