using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject Player;
    public Camera PauseCam;
    private bool flag = false;
    public GameObject notif;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (flag == false)
            {
                PauseUI.SetActive(true);
                Player.SetActive(false);
                PauseCam.gameObject.SetActive(true);
                flag = true;
                Global.cursor = true;
                return;
            }
            if (flag == true)
            {
                PauseUI.SetActive(false);
                Player.SetActive(true);
                PauseCam.gameObject.SetActive(false);
                flag = false;
                Global.cursor = false;
                notif.SetActive(false);
                return;
            }
            
        }
    }
}



