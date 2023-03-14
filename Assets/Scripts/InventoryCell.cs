using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[Serializable]
public class InventoryCell 
{
    private int number;
    private GameObject item;
    [SerializeField]
    private ScriptableObject cardData;
    public InventoryCell(int num)
    {
        number = num;
        item = null;
    }

    public void setGameObj(GameObject go = null)
    {
        if (go != null)
        {
            if (go.GetComponent<Card>().GetObjectType() == type.Card)
            {
                cardData = go.GetComponent<Card>().GetCardData();
            }
        }
        else 
        {
            item = go;
        }
    }

    public GameObject getObject()
    {
        return item;
    }
}
