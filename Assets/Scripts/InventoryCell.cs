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
    private bool stackable = false;
    private int count;

    public void setGameObj(int num,GameObject go, bool stackable, int count = 1)
    {
        this.number = num;
        this.stackable = stackable;
        item = go;
        if (!stackable)
        {
            this.count = 1;
        }
        else
        {
            this.count = count;
        }
    }

    public GameObject getObject()
    {
        return item;
    }
}
