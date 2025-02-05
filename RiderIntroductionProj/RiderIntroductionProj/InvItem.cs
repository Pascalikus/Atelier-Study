namespace RiderIntroductionProj;

public class InvItem
{
    public int ItemId;
    public string ItemName = "";
    public int ItemQuality;
    public int ItemRank;
    public int ElementFire;
    public int ElementEarth;
    public int ElementWater;
    public int ElementWind;

    public string[] ItemEffects = new string[3];
    public string[] ItemTraits = new string[3];

    public void UseItem()
    {
        
    }
}