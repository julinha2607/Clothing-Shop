using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;

public class ui_shop : MonoBehaviour
{

    private Transform Container;
    private Transform shopItemTemplate;
    private IShopCustomer shopCustomer;
    public Transform witchHatInventory;
    public Transform brownHairInventory;
    public Transform yellowOutfitInventory;
    public Transform blueOutfitInventory;
    public Image witchSprite;
    public Image brownHairSprite;
    public Image yellowfitSprite;
    public Image bluefitSprite;
    

    private void Awake()
    {
        Container = transform.Find("Container");
        shopItemTemplate = Container.Find("shopItemTemplate");
        witchSprite = witchHatInventory.Find("itemSprite").GetComponent<Image>();
        brownHairSprite = brownHairInventory.Find("itemSprite").GetComponent<Image>();
        yellowfitSprite = yellowOutfitInventory.Find("itemSprite").GetComponent<Image>();
        bluefitSprite = blueOutfitInventory.Find("itemSprite").GetComponent<Image>();

    }

    private void Start()
    {
        CreateItemButton(Item.ItemType.witchHat, Item.GetSprite(Item.ItemType.witchHat), "Witch Hat", Item.GetCost(Item.ItemType.witchHat), 24);
        CreateItemButton(Item.ItemType.brownHair, Item.GetSprite(Item.ItemType.brownHair), "Brown Hair", Item.GetCost(Item.ItemType.brownHair), -60);
        CreateItemButton(Item.ItemType.yellowOutfit,Item.GetSprite(Item.ItemType.yellowOutfit), "Yellow Fit", Item.GetCost(Item.ItemType.yellowOutfit), -150);
        CreateItemButton(Item.ItemType.blueOutfit, Item.GetSprite(Item.ItemType.blueOutfit), "Blue Fit", Item.GetCost(Item.ItemType.blueOutfit), -239);
        
        Hide();
    }


    private void CreateItemButton(Item.ItemType itemType, Sprite itemSprite, string itemName, int itemCost, float offsetY)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, Container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float newY = shopItemRectTransform.anchoredPosition.x + offsetY;

        shopItemRectTransform.anchoredPosition = new Vector2(0, newY);

        shopItemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemRectTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemSprite").GetComponent<Image>().sprite = itemSprite;

        shopItemTransform.GetComponent<Button_UI>().ClickFunc = () =>
        {
            TryBuyItem(itemType);

            switch (itemType)
            {
                case Item.ItemType.witchHat:
                    witchSprite.sprite = Item.GetSprite(Item.ItemType.witchHat);
                    break;
                case Item.ItemType.brownHair:
                    brownHairSprite.sprite = Item.GetSprite(Item.ItemType.brownHair);
                    break;
                case Item.ItemType.yellowOutfit:
                    yellowfitSprite.sprite = Item.GetSprite(Item.ItemType.yellowOutfit);
                    break;
                case Item.ItemType.blueOutfit:
                    bluefitSprite.sprite = Item.GetSprite(Item.ItemType.blueOutfit);
                    break;
            }
        }; 

    }

    private void TryBuyItem(Item.ItemType itemType)
    {
        shopCustomer.BoughtItem(itemType);
    }

    public void Show (IShopCustomer shopCustomer)
    {
        this.shopCustomer = shopCustomer;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

}
