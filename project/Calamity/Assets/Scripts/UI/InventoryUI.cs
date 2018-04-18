using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour {

    public Inventory inventory;
    public Text[] buttons = new Text[20];
    public int type = 0;

    public Text itemName;
    public Text itemDescription;
    public RawImage itemImage;

    void Update()
    {
        int i = 0;
        foreach (Item n in inventory.inventoryList)
        {
            if (n != null)
                if (n.find)
                    if (n.type == type)
                    {
                        buttons[i].GetComponentInParent<ButtonItem>().item = n;
                        buttons[i].text = n.inventoryName + " x " + n.amount;
                        i++;
                    }
        }
    }
    
    public void Click(Button but)
    {
        if (but.GetComponent<ButtonItem>().item != null)
        {
            itemName.text = but.GetComponent<ButtonItem>().item.inventoryName;
            itemDescription.text = but.GetComponent<ButtonItem>().item.description;
            itemImage.texture = but.GetComponent<ButtonItem>().item.image.texture;
            itemImage.color = new Color32(255, 255, 255, 255);
        }
    }
}
