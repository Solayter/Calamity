using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusAttack : MonoBehaviour {

    private int dmg;
    private void OnTriggerEnter(Collider other)
    {
        if (transform.localScale.x < 1)
            dmg = 1;
        else
            dmg = 5;

        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PersonController>().healthPointsValue -= dmg;
        }
    }
}
