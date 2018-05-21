using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingGame : MonoBehaviour {

    public Animator animUI;
    public Animator animCam;
    private bool curs = true;
    void Start()
    {
        Cursor.visible = false;
        animCam.SetTrigger("Start");
    }
    private void Update()
    {
        if (animCam.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.End"))
        {
            animUI.SetTrigger("Start");
            if (animUI.GetCurrentAnimatorStateInfo(0).fullPathHash == Animator.StringToHash("Base Layer.End"))
            {
                if (curs)
                    Cursor.visible = true;
                curs = false;
            }
        }
    }
}
