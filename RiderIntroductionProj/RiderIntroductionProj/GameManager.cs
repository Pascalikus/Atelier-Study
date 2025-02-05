using System.Collections.Immutable;
using System.Data;
using System.Data.Common;

namespace RiderIntroductionProj;

public sealed class GameManager
{
    private static readonly GameManager instance = new GameManager();
    public int maxInventorySize = 10000;
    public Item[] Inventory;
    public bool LoadInventory(Item[] inventory)
    {
        
        return true;
    }
    // Explicit static constructor to tell C# compiler
    // not to mark type as beforefieldinit
    static GameManager()
    {
    }
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
}