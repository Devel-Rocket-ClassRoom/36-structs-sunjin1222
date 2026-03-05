using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");
Console.WriteLine("=== 원본 레시피 ===");
Ingredient ingredient1 = new Ingredient("스파게티면", 200, "g");
Ingredient ingredient2 = new Ingredient("토마토소스", 150, "ml");
Ingredient ingredient3 = new Ingredient("양파", 1, "개");
Ingredient ingredient4 = new Ingredient("마늘", 3, "쪽");
Ingredient[] Ingredients = { ingredient1, ingredient2, ingredient3, ingredient4 };
RecipeCard recipeCard1 = new RecipeCard("토마토파스타", 2, Ingredients);
recipeCard1.PrintRecipe();
RecipeCard newrecipe = recipeCard1.ScaleRecipe(4);
newrecipe.PrintRecipe();

struct Ingredient
{ 
    public string Name;
    public double Amount;
    public string Unit;

    public Ingredient(string name, double amount, string unit)
    {
        Name = name;
        Amount = amount;
        Unit = unit;
    }
}

struct RecipeCard
{
    public string Name;
    public int Servings;
    public Ingredient[] Ingredients;

    public RecipeCard(string name, int servings, Ingredient[] ingredients)
    {
        Name = name;
        Servings = servings;
        Ingredients = ingredients;
    }

    public void PrintRecipe()
    {
        Console.WriteLine($"[{Name}] ({Servings}인분)");
        for (int i = 0; i < Ingredients.Length; i++)
        {
            Console.WriteLine($"-{Ingredients[i].Name}:{Ingredients[i].Amount}{Ingredients[i].Unit}");
        }
    }

    public RecipeCard ScaleRecipe(int newServings)
    {
        double amount = (double)newServings / Servings;
        Ingredient[] newingredients = new Ingredient[Ingredients.Length];

        for (int i = 0; i < Ingredients.Length; i++)
        {
            double newamount= Ingredients[i].Amount* amount;

            newingredients[i]=new Ingredient(
                Ingredients[i].Name,
                newamount,
                Ingredients[i].Unit
                );
        }
        return new RecipeCard(Name, newServings, newingredients);
    }


}


