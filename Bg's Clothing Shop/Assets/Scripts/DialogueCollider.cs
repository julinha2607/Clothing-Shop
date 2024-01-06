using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCollider : MonoBehaviour
{
    public GameObject dialogueTemplate;
    public GameObject fKey;
    private bool isInTriggerZone = false;
    public GameObject uiShop;
    public Vector2 dialogueAnchorPos = new Vector2(1160.6f, 1.163046f);
    private RectTransform dialogueRectTransform;


    void Start()
    {
       dialogueTemplate.SetActive(false);
       fKey.SetActive(false);
       dialogueRectTransform = dialogueTemplate.GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isInTriggerZone == true)
        {
            OpenDialogue();
        }

        if (dialogueTemplate.activeSelf)
        {
            fKey.SetActive(false);
        }

        if (uiShop.activeSelf)
        {
            dialogueTemplate.SetActive(false) ;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        fKey.SetActive(true);
        isInTriggerZone = true;

    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        fKey.SetActive(false);
        isInTriggerZone = false;

        CloseDialog();
    }

    void OpenDialogue() 
    {
        dialogueTemplate.SetActive(true);

        dialogueRectTransform.anchoredPosition = new Vector2(169f, -17.41f);



    }

    void CloseDialog()
    {
        
            dialogueTemplate.SetActive(false);     
        
    }

}
