using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        
        private int codice;

        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;




        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            
            

        }


        //--------------GETTERS AND SETTERS------------
        public long getCodice()
        {
            

            return codice;
        }

        public string getNome()
        {
            return nome;
        }
        public string getDescrizione()
        {
            return descrizione;
        }
        public double getPrezzo()
        {
            return prezzo;
        }
        public double getIva()
        {
            return iva;
        }

       

        public void setPrezzo(double nuovoPrezzo)
        {
            if (nuovoPrezzo < 0)
            {
                return;
            }else
            {
                prezzo = nuovoPrezzo;   
            }
        }

        public void setIva(double nuovaIva)
        {
            if (nuovaIva < 0)
            {
                return;
            }
            else
            {
               iva = nuovaIva;
            }
        }
        public void setDescrizione(string nuovaDescrizione)
        {
            descrizione = nuovaDescrizione; 
        }

        public void setNome(string nuovoNome)
        {
            nome = nuovoNome;
        }

        //------------------------------------------------------



        //----------------------FUNZIONI------------------------

        public void nomeEsteso()
        {
            Console.WriteLine("Il codice + nome è: " + codice + "-" + nome);
        }


        public void padLeft()
        {
            string codiceString = codice.ToString();
            char zero = '0';
            Console.WriteLine("Il codice per intero è: " + codiceString.PadLeft(8, zero));
        }






        public int ottieniCodice()
        {
            Random random = new Random();
            codice = random.Next(1000);
            return codice;
        }



        public double prezzoConIva()
        {
            double totale;
            iva = (100 - iva) / 100;
            totale = prezzo * iva;
            Console.WriteLine("Il prezzo con iva di " + nome + " è: " + totale + " euro.");
            return totale;

        }
    }
}
