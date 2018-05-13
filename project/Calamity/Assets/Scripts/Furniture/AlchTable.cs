using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AlchTable : MonoBehaviour
{
    public AudioSource audio;
    public GameObject alchUI;
    public GameObject interf;
    public GameObject player;
    public GameObject alchCam;
    public bool near = false;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.SetActive(false);
            alchCam.SetActive(true);
            audio.Play();
            alchUI.SetActive(true);
            interf.SetActive(false);
            Global.cursor = true;
            near = true;
            return;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&near)
        {
            player.SetActive(true);
            alchCam.SetActive(false);
            audio.Stop();
            alchUI.SetActive(false);
            interf.SetActive(true);
            Global.cursor = false;
            near = false;
            return;
        }
    }
}
