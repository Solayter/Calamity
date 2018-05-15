using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackMenu : MonoBehaviour {

    public GameObject thisMenu;
    public void Click()
    {
        thisMenu.SetActive(false);
    }
}
