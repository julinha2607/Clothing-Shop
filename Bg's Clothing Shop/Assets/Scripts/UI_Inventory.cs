using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class UI_Inventory : MonoBehaviour
{
    private Transform inventoryContainer;
    private Transform inventoryTemplate;
    private IShopCustomer shopCustomer;
    public Transform witchInv;
    public Transform brownHairInv;
    public Transform yellowFitInv;
    public Transform blueFitInv;
    private Image witchSprite;
    private Image brownHairSprite;
    private Image yellowFitSprite;
    private Image blueFitSprite;
    [SerializeField] CoinManager coinManager;


    private void Awake()
    {
        witchSprite = witchInv.Find("itemSprite").GetComponent<Image>();
        brownHairSprite = brownHairInv.Find("itemSprite").GetComponent<Image>();
        yellowFitSprite = yellowFitInv.Find("itemSprite").GetComponent<Image>();
        blueFitSprite = blueFitInv.Find("itemSprite").GetComponent<Image>();
    }


    public void SellWitch()
    {
        if (witchSprite.sprite !=null)
        {
            witchSprite.sprite = null;
            coinManager.moneyTotal += Item.GetCost(Item.ItemType.witchHat);

        }
    }

    public void SellBrownHair()
    {
        if (brownHairSprite.sprite != null)
        {
            brownHairSprite.sprite = null;
            coinManager.moneyTotal += Item.GetCost(Item.ItemType.brownHair);

        }
    }

    public void SellYellowOufit()
    {
        if (yellowFitSprite.sprite != null)
        {
            yellowFitSprite.sprite = null;
            coinManager.moneyTotal += Item.GetCost(Item.ItemType.yellowOutfit);

        }
    }

    public void SellBlueOufit()
    {
        if (blueFitSprite.sprite != null)
        {
            blueFitSprite.sprite = null;
            coinManager.moneyTotal += Item.GetCost(Item.ItemType.blueOutfit);

        }
    }

}
