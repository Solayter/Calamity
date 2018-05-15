using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WakeUp : MonoBehaviour {

	public Animation animWake;
    public Animation animOpenEye;
    public AudioSource audio;
    public AudioClip knock;
    public FirstPersonController fpsCtrl;
    public Pause pause;
    public bool Played = false;


    private void Start()
    {
        //audio.clip = knock;
        pause.enabled = false;
        fpsCtrl.enabled = false;
        Wake();
    }
    // Update is called once per frame
    public void Wake ()
    {
        animWake.PlayQueued("WakeUp", QueueMode.PlayNow);
        animOpenEye.PlayQueued("FromBlack", QueueMode.PlayNow);
        //audio.Play();
        
    }
    private void Update()
    {
        if (!animWake.IsPlaying("WakeUp") & !Played)
        {
            fpsCtrl.enabled = true;
            pause.enabled = true;
            Played = true;
        }
    }
}
