using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UsePotion : MonoBehaviour {

    public PersonController perCtrl;

    public ChoosePotion chPot;
    GameObject Throwing;
    public float force = 500;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) & chPot.choosenPotion != null)
        {
            if (chPot.choosenPotion.potionType == 1)
            {
                switch (chPot.choosenPotion.itemID)
                {
                    case 21:
                        perCtrl.healthPointsValue = perCtrl.healthPointsValue + perCtrl.healthPointsMax*0.3F;
                        if (perCtrl.healthPointsValue > perCtrl.healthPointsMax)
                            perCtrl.healthPointsValue = perCtrl.healthPointsMax;
                        break;
                    default:
                        break;
                }
            }
            if (chPot.choosenPotion.potionType == 2)
            {
                Throwing = Instantiate(chPot.choosenPotion.gameObject, transform.position, transform.rotation);
                Throwing.GetComponent<Rigidbody>().isKinematic = false;
                Throwing.GetComponent<Rigidbody>().AddForce(transform.forward * force);
                Throwing.tag = "Untagged";
                
            }
            chPot.potionCtrl.potionBelt[chPot.choosenNum] = null;
            chPot.choosenPotion = null;
            chPot.Refresh();

        }
    }

}
