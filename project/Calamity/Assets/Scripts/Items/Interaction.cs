using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {

    public Inventory inventory;
    public GameObject active;

    public Text itemName;
    public GameObject nameItem;
    public Text subjectName;
    public GameObject nameSubject;
    private void OnTriggerStay(Collider other)      //Отобразить имя предмета
    {
        if (other.CompareTag("Collectable"))
        {
            active = other.gameObject;
            nameItem.SetActive(true);
            itemName.text = other.GetComponent<Item>().inventoryName + " <E>";
        }
        if (other.CompareTag("Usable"))
        {
            nameSubject.SetActive(true);
            subjectName.text = other.GetComponent<SubjectName>().name + " <F>";
        }
    }
    private void OnTriggerExit(Collider other)      //Скрыть имя
    {
        if (other.gameObject == active)
        {
            active = null;
            nameItem.SetActive(false);
            itemName.text = "";
        }
        if (other.CompareTag("Usable"))
        {
            active = other.gameObject;
            nameSubject.SetActive(false);
            subjectName.text = "";
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
                            nameItem.SetActive(false);
                            active = null;
                            return;
                        }
                }
        }
        if(active == null)
        {
            nameItem.SetActive(false);
            itemName.text = "";
        }
    }
}
