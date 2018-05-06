using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animation anim;
    private bool flag = false;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flag == false)
            {
                anim.PlayQueued("Door_open", QueueMode.PlayNow);
                flag = true;
                return;

            }
            if (flag == true)
            {
                anim.PlayQueued("Door_close", QueueMode.PlayNow);
                flag = false;
                return;
            }
        }
    }
}
