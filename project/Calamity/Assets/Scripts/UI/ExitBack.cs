using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBack : MonoBehaviour {

    public GameObject notif;
    public void ExitGame()
    {
        notif.SetActive(false);
    }
}
