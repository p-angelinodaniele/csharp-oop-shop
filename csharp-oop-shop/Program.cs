using csharp_oop_shop;


Prodotto uova = new Prodotto("uova", "uovo", 2, 20);

uova.ottieniCodice();
double prezzo = uova.getPrezzo();
Console.WriteLine("Il prezzo è: " + prezzo);  
uova.prezzoConIva();

uova.nomeEsteso();
uova.padLeft();


