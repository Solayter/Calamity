using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int itemID;
    public string inventoryName;
    public string description;
    public int amount = 0;
    public bool find = false;
    public int type;
    public RawImage image;
}