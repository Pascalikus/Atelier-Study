namespace RiderIntroductionProj;

public class Crafting
{
    public int MaxIngredients = 12;
    public Item[] Ingredients;
    private List<Traits> traits;
    public bool pressedStart = false;
    public void SetupIngredients()
    {
        this.Ingredients = new Item[MaxIngredients];
        for (int i = 0; i < this.Ingredients.Length; i++)
        {
            this.Ingredients[i] = new Item();
        }
    }

    public Crafting()
    {
        
    }
    public Crafting(int leftOver)
    {
        Ingredients = new Item[MaxIngredients + leftOver];
    }
    public void AlreadyExists(List<Traits> currentTraitArray, List<Traits> traitsToAdd)
    {
        for (int i = 0; i < traitsToAdd.Count; i++)
        {
            for (int j = 0; j < currentTraitArray.Count; j++)
            {
                if (traitsToAdd[i].TraitID == currentTraitArray[j].TraitID)
                {
                    break;
                }
            }
            currentTraitArray.Add(traitsToAdd[i]);
        }
    }
    public void CraftingLogic()
    {
        int currentIngredients = 0;
        Traits[] currentTraits;
        while (currentIngredients != MaxIngredients || !pressedStart)
        {
            Item addedItem = new Item();
            AddIngredient(addedItem, currentIngredients);    
            currentIngredients++;
            
        }
    }
    
    public Item NavigateInventory()
    {
        Item item = new Item();   
        return item;
    }
    public void AddIngredient(Item ingredient, int currentSpot)
    {
        Ingredients[currentSpot] = ingredient;
        AlreadyExists(traits, ingredient.Traits);
    }
    


}