using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animation anim;
    public AudioSource audio;
    public AudioClip open;
    public AudioClip close;
    private bool flag = false;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (!anim.isPlaying)
                {
                    if (flag == false)
                    {
                        anim.PlayQueued("Door_open", QueueMode.PlayNow);
                        audio.clip = open;
                        audio.Play();
                        flag = true;
                        return;

                    }
                    if (flag == true)
                    {
                        anim.PlayQueued("Door_close", QueueMode.PlayNow);
                        audio.clip = close;
                        audio.Play();
                        flag = false;
                        return;
                    }
                }
            }
        }
    }
}
