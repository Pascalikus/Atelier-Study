
using System.Reflection;

namespace RiderIntroductionProj;

public class Item
{
    public UInt16 itemId;
    private int OwO = 1;
    public List<Traits> Traits;
    public void CallEffectFunctions(int OwO)
    {
        Type type = typeof(Item);
        OwO++;
        MethodInfo method = type.GetMethod("CallEffectFunctions");
        Console.WriteLine("Test int is currently at " + OwO);
        if (OwO < 20) 
        {
            object[] paramters = new object[] { OwO };

            method.Invoke(this, paramters);
        }
    }

    public Item()
    {
        itemId = 65535;
    }
}