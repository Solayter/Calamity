using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionController : MonoBehaviour {

    public InventoryUI invent;
    public Item[] potionBelt = new Item[8];
    public RawImage[] picBelt = new RawImage[8];
    public RawImage[] interfaceBelt = new RawImage[8];
    public IconsForPotions icons;
    
    public void Click(int id)
    {
        if (potionBelt[id] == null)
        {
            if ((invent.item.amount > 0) & (invent.item.type == 1))
            {
                invent.item.amount--;
                potionBelt[id] = invent.item;
                picBelt[id].color = new Color32(255, 255, 255, 255);
                picBelt[id].texture = icons.potionIcons[invent.item.itemID - 21].texture;
                interfaceBelt[id].color = new Color32(255, 255, 255, 255);
                interfaceBelt[id].texture = icons.potionIcons[invent.item.itemID - 21].texture;
                return;
            }
        }
        if (potionBelt[id] != null)
        {
            potionBelt[id].amount++;
            potionBelt[id] = null;
            picBelt[id].color = new Color32(255, 255, 255, 0);
            interfaceBelt[id].color = new Color32(255, 255, 255, 0);
        }
    }

    public void Refresh()
    {
        for(int i = 0; i < 8; i++)
        {
            if(potionBelt[i] == null)
            {
                picBelt[i].color = new Color32(255, 255, 255, 0);
                interfaceBelt[i].color = new Color32(255, 255, 255, 0);
            }
        }
    }

}
