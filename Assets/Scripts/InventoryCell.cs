using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class InventoryCell 
{
    private type type;
    private int number;
    private GameObject cell;
    private GameObject item;
    [SerializeField]
    private CardData cardData;
    public InventoryCell(int num, GameObject cell, GameObject go = null)
    {
        if (go != null)
        {
            if (go.GetComponent<CardItem>().GetObjectType() == type.Card)
            {
                type = type.Card;
                cardData = go.GetComponent<CardItem>().GetCardData();
                ChangeImage(cardData.Icon);
            }
        }
        else
        {
            item = go;
        }
        number = num;
        item = null;
        this.cell = cell;

    }
    public type GetCellType()
    {
        return type;
    }
    public void setGameObj(GameObject go)
    {
      
        if (go.GetComponent<CardItem>().GetObjectType() == type.Card)
        {
            cardData = go.GetComponent<CardItem>().GetCardData();
            ChangeImage(cardData.Icon);
        }
       
                
       
     
        
    }
    public CardData GetCardData()
    {
        return cardData;
    }


    public void ChangeImage(Sprite image) 
    {
        cell.GetComponentsInChildren<Image>()[1].sprite = image;
    }
    public GameObject getObject()
    {
        return item;
    }
}
