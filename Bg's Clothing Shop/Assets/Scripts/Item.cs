using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour { 
public enum ItemType
{
    witchHat,
    brownHair,
    yellowOutfit,
    blueOutfit,
    womenUnderwear,

}



public static Sprite GetSprite(ItemType itemType)
{
    switch (itemType)
    {
        default:
        case ItemType.witchHat: return GameAssets.i.witchHatSprite;
        case ItemType.brownHair: return GameAssets.i.brownHairSprite;
        case ItemType.yellowOutfit: return GameAssets.i.yellowOutfitSprite;
        case ItemType.blueOutfit: return GameAssets.i.blueOutfitSprite;
        case ItemType.womenUnderwear: return GameAssets.i.womenUnderwearSprite;
    }
}


    public static int GetCost(ItemType itemType)
{
    switch (itemType)
    {
        default:
        case ItemType.witchHat: return 10;
        case ItemType.brownHair: return 5;
        case ItemType.yellowOutfit: return 30;
        case ItemType.blueOutfit: return 30;

    }
}

}