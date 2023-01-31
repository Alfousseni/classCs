using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace projetProduit
{
    internal class Produit
    {
        static int incr;
        public string id;
        public string code;
        public string libelle;
        public string description;
        public double prix_unitaire;
        public int quantitestock;

        public Produit(string code, string libelle, string description, double prix_unitaire, int quantitestock)
        {
            incr++;
            this.id = libelle.Substring(0,1) + incr.ToString().PadLeft(3, '0');
            this.code = code;
            this.libelle = libelle;
            this.description = description;
            this.prix_unitaire = prix_unitaire;
            this.quantitestock = quantitestock;
            
        }

        public  void Affichage()
        {
            Console.WriteLine("id :            " + this.id);
            Console.WriteLine("code :          " + this.code);
            Console.WriteLine("libelle :       " + this.libelle);
            Console.WriteLine("Description :   " + this.description);
            Console.WriteLine("Prix unitaire : " + this.prix_unitaire);
            Console.WriteLine("Quantiter:      " + this.quantitestock);

            Console.WriteLine("");
            Console.WriteLine("----------------------");
        }

        public double Calculprix()
        {
            double ptotal=this.prix_unitaire * this.quantitestock;

            return ptotal;
        }

        
    }
}
