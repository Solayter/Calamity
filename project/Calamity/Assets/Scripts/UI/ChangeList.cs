using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeList : MonoBehaviour {

    public InventoryUI inventoryUI;
    public GameObject belt;
    public int type = 0;

    public void Change()
    {
        foreach (var item in inventoryUI.buttons)
        {
            item.GetComponentInParent<ButtonItem>().item = null;
        }
        
        if (type == 1)
            belt.SetActive(true);
        else
            belt.SetActive(false);
        inventoryUI.type = type;
        foreach(var n in inventoryUI.buttons)
        {
            n.text = "";
        }
    }
}
