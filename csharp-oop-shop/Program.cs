using csharp_oop_shop;


Prodotto uova = new Prodotto("uova", "uovo", 10, 20);


double prezzo = uova.GetPrezzo();
Console.WriteLine("Il prezzo già con iva è: " + prezzo + "euro");  
uova.PrezzoSenzaIva();
uova.PrezzoSenzaIva();
Console.WriteLine("Il codice con il padding è: " + uova.GetCodice());
uova.NomeEsteso();



