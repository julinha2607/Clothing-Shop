using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets instance; 

    public static GameAssets i
    {
        get
        {
            if (instance == null) instance = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return instance;
        }
    }

    public Sprite witchHatSprite;
    public Sprite brownHairSprite; 
    public Sprite yellowOutfitSprite;
    public Sprite blueOutfitSprite;
    public Sprite womenUnderwearSprite;

}
