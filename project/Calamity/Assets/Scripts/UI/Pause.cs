using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject PauseUI;
    public GameObject Player;
    public Camera PauseCam;
    public bool curs;

    
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!PauseUI.activeInHierarchy)
            {
                PauseUI.SetActive(true);
                Player.SetActive(false);
                PauseCam.gameObject.SetActive(true);
                curs = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                curs = false;
                Cursor.lockState = CursorLockMode.Locked;
                PauseUI.SetActive(false);
                Player.SetActive(true);
                PauseCam.gameObject.SetActive(false); 
            }
        }
        Cursor.visible = curs;
        
    }
}
