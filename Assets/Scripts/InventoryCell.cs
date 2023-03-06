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

    public InventoryCell(int num)
    {
        number = num;
        item = null;
    }
    public void setGameObj(int num,GameObject go = null)
    {
        number = num;
        item = go;
    }

    public GameObject getObject()
    {
        return item;
    }
}
