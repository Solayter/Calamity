using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour {

    public GameObject fire;
    public GameObject light;
    public Inventory inv;
    public AudioSource aud;
    private bool flag = false;

    private void OnTriggerStay(Collider other)
    {
        if (inv.inventoryList[58].amount > 0)
        {
            gameObject.tag = "Usable";
            if ((other.gameObject.CompareTag("Player")) & (Input.GetKeyDown(KeyCode.F)))
            {
                if (flag == false)
                {
                    fire.SetActive(true);
                    light.SetActive(true);
                    aud.Play();
                    flag = true;
                }
                else if (flag == true)
                {
                    fire.SetActive(false);
                    light.SetActive(false);
                    aud.Stop();
                    flag = false;
                }
            }
        }
        else
            gameObject.tag = "Untagged";
    }
}
