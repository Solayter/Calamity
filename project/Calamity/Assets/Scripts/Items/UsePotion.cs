using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion : MonoBehaviour {

    public ChoosePotion chPot;
    GameObject Throwing;
    public float force = 500;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) & chPot.choosenPotion != null)
        {
            if (chPot.choosenPotion.potionType == 1)
            {
                //выпить зелье
            }
            if (chPot.choosenPotion.potionType == 2)
            {
                Throwing = Instantiate(chPot.choosenPotion.gameObject, transform.position, transform.rotation);
                Throwing.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Throwing.tag = "Untagged";
                
            }
            chPot.potionCtrl.potionBelt[chPot.choosenNum] = null;
            chPot.choosenPotion = null;
            chPot.Refresh();

        }
    }

}
