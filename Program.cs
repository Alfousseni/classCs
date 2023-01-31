// See https://aka.ms/new-console-template for more information
using projetProduit;

public class program
{
    public static void Main(String[] args)
    {
       List <Produit> produits= new List <Produit>();

        produits.Add(new Produit("A001", "lait", "produit laitier", 1000,23));
        produits.Add(new Produit("A002", "sucre", "produit laitier", 1500,18));
        produits.Add(new Produit("A003", "the", "produit laitier", 1700,49));
        produits.Add(new Produit("A004", "caffe", "produit laitier", 300,90));
        produits.Add(new Produit("A005", "kiren", "eau mineral", 500,20));
        produits.Add(new Produit("A006", "huile", "huile vegetal", 5700, 10));
        produits.Add(new Produit("A009", "riz", "Aliment", 15000, 100));


        foreach (var produit in produits)
        {
            produit.Affichage();
        }
        Console.WriteLine("----------------Produit donc le Montant en stock depasse 500 000 : --------------------");
        foreach (var produit in produits)
        {
            if (produit.Calculprix() > 500000) { 
                produit.Affichage();
            }
            if (produit.prix_unitaire >= 500)
            {
                produit.prix_unitaire -= 100;
            }
                                
        }
        Console.WriteLine("-----------------apres revision des prix unitaire----------------------------");

        foreach(var produit in produits)
        {
            produit.Affichage();
        }

    }
}
