using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeList : MonoBehaviour {

    public InventoryUI inventoryUI;
    public int type = 0;

    public void Change()
    {
        inventoryUI.type = type;
        foreach(var n in inventoryUI.buttons)
        {
            n.text = "";
        }
    }
}
