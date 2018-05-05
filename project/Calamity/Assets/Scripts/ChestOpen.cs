using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    public Interaction interaction;
    public GameObject items;
    public Animation anim;
    private bool flag = false;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flag == false)
            {
                anim.PlayQueued("Chest_open", QueueMode.PlayNow);
                flag = true;
                items.SetActive(true);
                return;
                
            }
            if (flag == true)
            {
                anim.PlayQueued("Chest_close", QueueMode.PlayNow);
                flag = false;
                return;
            }
        }
    }
    public void OffItem()
    {
        interaction.active = null;
        items.SetActive(false);
    }
}
