using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour {

    public AudioSource aud;
    public DoorOpen door;
    private bool flag = false;

    public void Update()
    {
        if (!flag & door.audio.isPlaying)
        {
            aud.Play();
            flag = true;
        }
    }
}
