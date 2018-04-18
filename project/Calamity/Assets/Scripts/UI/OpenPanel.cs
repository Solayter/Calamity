using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanel : MonoBehaviour {

    public GameObject newpanel;
    public GameObject player;
    public void Open()
    {
        newpanel.SetActive(true);
        player.SetActive(false);
    }
}
