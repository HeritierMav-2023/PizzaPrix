using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPrix
{

    // Classe représentant un ingrédient
    public class Ingredient
    {
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public string Categorie { get; set; }

        public Ingredient(string nom, decimal prix, string categorie)
        {
            Nom = nom;
            Prix = prix;
            Categorie = categorie;
        }
    }

    // Classe représentant une pizza
    public class Pizza
    {
        public string Nom { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Pizza(string nom)
        {
            Nom = nom;
            Ingredients = new List<Ingredient>();
        }

        public void AjouterIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public decimal CalculerPrix()
        {
            return Ingredients.Sum(i => i.Prix);
        }

        public override string ToString()
        {
            return $"{Nom} - {CalculerPrix():F2} €";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialisation des ingrédients
            var ingredients = new Dictionary<string, Ingredient>();

            // Sauces
            ingredients["Sauce Tomate"] = new Ingredient("Sauce Tomate", 1m, "Sauce");
            ingredients["Sauce Barbecue"] = new Ingredient("Sauce Barbecue", 2m, "Sauce");
            ingredients["Crème fraîche"] = new Ingredient("Crème fraîche", 1.5m, "Sauce");
            ingredients["sauce samouraï"] = new Ingredient("sauce samouraï", 1m, "Sauce");

            // Viandes
            ingredients["poulet rôti"] = new Ingredient("poulet rôti", 6m, "Viande");
            ingredients["emmiëtté de bœuf"] = new Ingredient("emmiëtté de bœuf", 4.5m, "Viande");
            ingredients["merguez"] = new Ingredient("merguez", 5m, "Viande");
            ingredients["jambon"] = new Ingredient("jambon", 4.5m, "Viande");
            ingredients["saucisse pepperoni"] = new Ingredient("saucisse pepperoni", 6m, "Viande");
            ingredients["lardons"] = new Ingredient("lardons", 5.5m, "Viande");

            // Poisson
            ingredients["saumon fumé"] = new Ingredient("saumon fumé", 6m, "Poisson");

            // Légumes
            ingredients["champignons"] = new Ingredient("champignons", 2m, "Légumes");
            ingredients["oignons rouges"] = new Ingredient("oignons rouges", 3.5m, "Légumes");
            ingredients["Olives noires"] = new Ingredient("Olives noires", 3m, "Légumes");
            ingredients["poivrons verts"] = new Ingredient("poivrons verts", 3m, "Légumes");
            ingredients["tomates"] = new Ingredient("tomates", 3m, "Légumes");

            // Miel
            ingredients["miel"] = new Ingredient("miel", 5m, "Miel");

            // Ananas
            ingredients["ananas"] = new Ingredient("ananas", 5m, "ananas");

            // Fromages
            ingredients["mozzarella"] = new Ingredient("mozzarella", 2m, "Fromage");
            ingredients["fromage de chèvre"] = new Ingredient("fromage de chèvre", 4m, "Fromage");
            ingredients["emmental"] = new Ingredient("emmental", 2m, "Fromage");
            ingredients["fourme d’ambert"] = new Ingredient("fourme d’ambert", 4m, "Fromage");
            ingredients["fromage raclette"] = new Ingredient("fromage raclette", 4m, "Fromage");
            ingredients["parmigiano"] = new Ingredient("parmigiano", 5m, "Fromage");

            // Création des pizzas
            var pizzas = new List<Pizza>();

            // 4 Fromages
            var pizza4Fromages = new Pizza("4 Fromages");
            pizza4Fromages.AjouterIngredient(ingredients["Sauce Tomate"]);
            pizza4Fromages.AjouterIngredient(ingredients["mozzarella"]);
            pizza4Fromages.AjouterIngredient(ingredients["fromage de chèvre"]);
            pizza4Fromages.AjouterIngredient(ingredients["emmental"]);
            pizza4Fromages.AjouterIngredient(ingredients["fourme d’ambert"]);
            pizzas.Add(pizza4Fromages);

            // BPM
            var bpm = new Pizza("BPM");
            bpm.AjouterIngredient(ingredients["Sauce Barbecue"]);
            bpm.AjouterIngredient(ingredients["mozzarella"]);
            bpm.AjouterIngredient(ingredients["emmiëtté de bœuf"]);
            bpm.AjouterIngredient(ingredients["poulet rôti"]);
            bpm.AjouterIngredient(ingredients["merguez"]);
            pizzas.Add(bpm);

            // Pepperoni Lovers
            var pepperoniLovers = new Pizza("Pepperoni Lovers");
            pepperoniLovers.AjouterIngredient(ingredients["Sauce Tomate"]);
            pepperoniLovers.AjouterIngredient(ingredients["mozzarella"]);
            pepperoniLovers.AjouterIngredient(ingredients["saucisse pepperoni"]);
            pizzas.Add(pepperoniLovers);

            // Queen
            var queen = new Pizza("Queen");
            queen.AjouterIngredient(ingredients["Sauce Tomate"]);
            queen.AjouterIngredient(ingredients["mozzarella"]);
            queen.AjouterIngredient(ingredients["jambon"]);
            queen.AjouterIngredient(ingredients["champignons"]);
            pizzas.Add(queen);

            // Montagnarde
            var montagnarde = new Pizza("Montagnarde");
            montagnarde.AjouterIngredient(ingredients["Crème fraîche"]);
            montagnarde.AjouterIngredient(ingredients["mozzarella"]);
            montagnarde.AjouterIngredient(ingredients["jambon"]); // Attention: jambon cru ? Dans la liste, on a jambon, on considère que c'est le même
            montagnarde.AjouterIngredient(ingredients["fromage raclette"]);
            montagnarde.AjouterIngredient(ingredients["champignons"]);
            pizzas.Add(montagnarde);

            // Suprême
            var supreme = new Pizza("Suprême");
            supreme.AjouterIngredient(ingredients["Sauce Tomate"]);
            supreme.AjouterIngredient(ingredients["mozzarella"]);
            supreme.AjouterIngredient(ingredients["emmiëtté de bœuf"]);
            supreme.AjouterIngredient(ingredients["saucisse pepperoni"]);
            supreme.AjouterIngredient(ingredients["champignons"]);
            supreme.AjouterIngredient(ingredients["oignons rouges"]);
            supreme.AjouterIngredient(ingredients["poivrons verts"]);
            pizzas.Add(supreme);

            // Raclette
            var raclette = new Pizza("Raclette");
            raclette.AjouterIngredient(ingredients["Crème fraîche"]);
            raclette.AjouterIngredient(ingredients["mozzarella"]);
            // pommes de terre : n'est pas dans la liste des ingrédients ! On doit l'ajouter ? L'énoncé ne donne pas de prix pour les pommes de terre. Problème.
            // On va supposer que c'est un ingrédient manquant. Pour l'exercice, on peut l'ajouter avec un prix. Mais l'énoncé ne le mentionne pas. On va créer un ingrédient "pommes de terre" avec un prix arbitraire, disons 2€.
            // De même pour "lardons" et "fromage à raclette" existent déjà.
            // Ajoutons "pommes de terre" dans la liste des ingrédients.
            // On va le faire avant.
            // Pour simplifier, on va ajouter cet ingrédient maintenant.
            // Mais dans le code, on doit l'avoir dans le dictionnaire. On va le rajouter.
            // On va faire une passe pour ajouter tous les ingrédients manquants.
            // En attendant, on va le créer ici.

            // Ajout de l'ingrédient "pommes de terre" (pas dans le tableau, on lui donne un prix de 2€ par exemple)
            if (!ingredients.ContainsKey("pommes de terre"))
                ingredients["pommes de terre"] = new Ingredient("pommes de terre", 2m, "Légumes"); // catégorie à définir

            raclette.AjouterIngredient(ingredients["pommes de terre"]);
            raclette.AjouterIngredient(ingredients["lardons"]);
            raclette.AjouterIngredient(ingredients["fromage raclette"]);
            pizzas.Add(raclette);

            // Chèvre Miel
            var chevreMiel = new Pizza("Chèvre Miel");
            chevreMiel.AjouterIngredient(ingredients["Crème fraîche"]);
            chevreMiel.AjouterIngredient(ingredients["mozzarella"]);
            chevreMiel.AjouterIngredient(ingredients["fromage de chèvre"]);
            chevreMiel.AjouterIngredient(ingredients["miel"]);
            pizzas.Add(chevreMiel);

            // Nordique
            var nordique = new Pizza("Nordique");
            nordique.AjouterIngredient(ingredients["Crème fraîche"]);
            nordique.AjouterIngredient(ingredients["mozzarella"]);
            nordique.AjouterIngredient(ingredients["saumon fumé"]);
            pizzas.Add(nordique);

            // Campagnarde
            var campagnarde = new Pizza("Campagnarde");
            campagnarde.AjouterIngredient(ingredients["Crème fraîche"]);
            campagnarde.AjouterIngredient(ingredients["mozzarella"]);
            campagnarde.AjouterIngredient(ingredients["lardons"]);
            campagnarde.AjouterIngredient(ingredients["oignons rouges"]);
            campagnarde.AjouterIngredient(ingredients["champignons"]);
            pizzas.Add(campagnarde);

            // Samouraï
            var samourai = new Pizza("Samouraï");
            samourai.AjouterIngredient(ingredients["Sauce Tomate"]);
            samourai.AjouterIngredient(ingredients["mozzarella"]);
            samourai.AjouterIngredient(ingredients["merguez"]);
            samourai.AjouterIngredient(ingredients["poulet rôti"]);
            samourai.AjouterIngredient(ingredients["oignons rouges"]);
            samourai.AjouterIngredient(ingredients["sauce samouraï"]);
            pizzas.Add(samourai);

            // Chicken Parmesan
            var chickenParmesan = new Pizza("Chicken Parmesan");
            chickenParmesan.AjouterIngredient(ingredients["Sauce Tomate"]);
            chickenParmesan.AjouterIngredient(ingredients["mozzarella"]);
            chickenParmesan.AjouterIngredient(ingredients["poulet rôti"]);
            chickenParmesan.AjouterIngredient(ingredients["tomates"]);
            chickenParmesan.AjouterIngredient(ingredients["parmigiano"]);
            // Note: "parmigiano" est dans la liste, "reggiano" ? Il y a "parmigiano, reggiano AOP" mais on a qu'un ingrédient. On va considérer que c'est le même ou ajouter "reggiano"? L'énoncé a "parmigiano" seulement. On va utiliser parmigiano.
            pizzas.Add(chickenParmesan);

            // Végétarienne
            var vegetarienne = new Pizza("Végétarienne");
            vegetarienne.AjouterIngredient(ingredients["Sauce Tomate"]);
            vegetarienne.AjouterIngredient(ingredients["mozzarella"]);
            vegetarienne.AjouterIngredient(ingredients["champignons"]);
            vegetarienne.AjouterIngredient(ingredients["oignons rouges"]);
            vegetarienne.AjouterIngredient(ingredients["poivrons verts"]);
            vegetarienne.AjouterIngredient(ingredients["tomates"]);
            vegetarienne.AjouterIngredient(ingredients["Olives noires"]);
            pizzas.Add(vegetarienne);

            // Hawaïenne Jambon
            var hawaienne = new Pizza("Hawaïenne Jambon");
            hawaienne.AjouterIngredient(ingredients["Sauce Tomate"]);
            hawaienne.AjouterIngredient(ingredients["mozzarella"]);
            hawaienne.AjouterIngredient(ingredients["jambon"]);
            hawaienne.AjouterIngredient(ingredients["ananas"]);
            pizzas.Add(hawaienne);

            // Maintenant, interface utilisateur
            Console.WriteLine("=== Pizzeria ===");
            Console.WriteLine("Liste des pizzas disponibles :");
            for (int i = 0; i < pizzas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {pizzas[i].Nom} - {pizzas[i].CalculerPrix():F2} €");
            }

            Console.WriteLine("\nChoisissez une pizza en entrant son nom ou son numéro :");
            string input = Console.ReadLine();

            Pizza selectedPizza = null;

            // Essayer de parser un numéro
            if (int.TryParse(input, out int index) && index >= 1 && index <= pizzas.Count)
            {
                selectedPizza = pizzas[index - 1];
            }
            else
            {
                // Chercher par nom (insensible à la casse)
                selectedPizza = pizzas.FirstOrDefault(p => p.Nom.Equals(input, StringComparison.OrdinalIgnoreCase));
            }

            if (selectedPizza == null)
            {
                Console.WriteLine("Pizza non trouvée.");
            }
            else
            {
                Console.WriteLine($"Vous avez choisi : {selectedPizza.Nom}");
                Console.WriteLine($"Prix total : {selectedPizza.CalculerPrix():F2} €");
                // Optionnel : afficher les ingrédients
                Console.WriteLine("Ingrédients :");
                foreach (var ing in selectedPizza.Ingredients)
                {
                    Console.WriteLine($"- {ing.Nom} ({ing.Prix:F2} €)");
                }
            }

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
    
}
