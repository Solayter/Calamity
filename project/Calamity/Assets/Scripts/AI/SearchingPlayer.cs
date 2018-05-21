using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchingPlayer : MonoBehaviour {

	public GameObject player;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            player = other.gameObject;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            player = null;
    }
}
