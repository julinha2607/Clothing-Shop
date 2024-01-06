using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour, IShopCustomer
{
    public float speed = 5f;
    public GameObject playerBody;
    public GameObject playerHead;
    public SpriteRenderer bodySR;
    public SpriteRenderer headSR;
    [SerializeField] CoinManager coinManager;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        bodySR = playerBody.GetComponent<SpriteRenderer>();
        headSR = playerHead.GetComponent<SpriteRenderer>();
        
  
    }


  void Update()
{
    float moveHorizontal = Input.GetAxisRaw("Horizontal");
    float moveVertical = Input.GetAxisRaw("Vertical");

    animator.SetFloat("moveX", moveHorizontal);
    animator.SetFloat("moveY", moveVertical);

    Vector2 movement = new Vector2(moveHorizontal, moveVertical);

    

    GetComponent<Rigidbody2D>().velocity = movement * speed;
}

 

    public void BoughtItem(Item.ItemType itemType)
    {
        switch (itemType)
        {
            case Item.ItemType.witchHat:
                headSR.sprite = Item.GetSprite(Item.ItemType.witchHat);
                coinManager.moneyTotal -= Item.GetCost(Item.ItemType.witchHat);
                break;
            case Item.ItemType.brownHair:
                headSR.sprite = Item.GetSprite(Item.ItemType.brownHair);
                coinManager.moneyTotal -= Item.GetCost(Item.ItemType.brownHair);
                break;
            case Item.ItemType.yellowOutfit:
                bodySR.sprite = Item.GetSprite(Item.ItemType.yellowOutfit);
                coinManager.moneyTotal -= Item.GetCost(Item.ItemType.yellowOutfit);
                break;
            case Item.ItemType.blueOutfit:
                bodySR.sprite = Item.GetSprite(Item.ItemType.blueOutfit);
                coinManager.moneyTotal -= Item.GetCost(Item.ItemType.blueOutfit);
                break;
        } 
    }

    
}


