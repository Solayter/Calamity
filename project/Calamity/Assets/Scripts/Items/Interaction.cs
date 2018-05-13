using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {

    public Inventory inventory;
    public GameObject active;

    public Text itemName;
    public GameObject nameObject;

    private void OnTriggerStay(Collider other)      //Отобразить имя предмета
    {
        if (other.CompareTag("Collectable"))
        {
            active = other.gameObject;
            nameObject.SetActive(true);
            itemName.text = other.GetComponent<Item>().inventoryName + " <E>";
        }
    }
    private void OnTriggerExit(Collider other)      //Скрыть имя
    {
        if (other.gameObject == active)
        {
            active = null;
            nameObject.SetActive(false);
            itemName.text = "";
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))        //Собрать предмет
        {
            if (active != null)
                foreach (Item n in inventory.inventoryList)
                {
                    if (n != null)
                        if (n.itemID == active.GetComponent<Item>().itemID)
                        {
                            n.amount++;
                            n.find = true;
                            Destroy(active.gameObject);
                            itemName.text = "";
                            nameObject.SetActive(false);
                            active = null;
                            return;
                        }
                }
        }
        if(active == null)
        {
            nameObject.SetActive(false);
            itemName.text = "";
        }
    }
}
