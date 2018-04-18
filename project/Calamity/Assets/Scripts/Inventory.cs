using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Item[] inventoryList = new Item[60];

    private void Start()
    {
        foreach(Item n in inventoryList)
        {
            if (n != null)
            {
                n.amount = 0;
                n.find = false;
            }
        }
    }
}
