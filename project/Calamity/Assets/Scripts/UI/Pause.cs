using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause : MonoBehaviour
{
    public FirstPersonController fpsCtrl;
    public UsePotion uspot;
    public GameObject PauseUI;
    public GameObject Interface;
    private bool flag = false;
    public GameObject notif;
    public AudioListener audlistn;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (flag == false)
            {
                PauseUI.SetActive(true);
                audlistn.enabled = false;
                fpsCtrl.enabled = false;
                uspot.enabled = false;
                Interface.SetActive(false);
                flag = true;
                Global.cursor = true;
                return;
            }
            if (flag == true)
            {
                PauseUI.SetActive(false);
                audlistn.enabled = true;
                fpsCtrl.enabled = true;
                uspot.enabled = true;
                Interface.SetActive(true);
                flag = false;
                Global.cursor = false;
                notif.SetActive(false);
                return;
            }
            
        }
    }
}



