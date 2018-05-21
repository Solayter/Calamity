using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public Animation animFall;
    public Animation animCloseEye;
    public FirstPersonController fpsCtrl;
    public Pause pause;
    public bool Played = false;

    
    public void End()
    {
        pause.enabled = false;
        fpsCtrl.enabled = false;
        animFall.PlayQueued("Death", QueueMode.PlayNow);
        animCloseEye.PlayQueued("CloseEye", QueueMode.PlayNow);
        Played = true;
        Global.cursor = true;

    }
    private void Update()
    {
        if(!animCloseEye.isPlaying & Played)
        {

            SceneManager.LoadScene(0);
            
            
        }
    }
}
