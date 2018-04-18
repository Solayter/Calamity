using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour {

    public GameObject Player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Player.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
