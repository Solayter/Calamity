using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchTable : MonoBehaviour
{

    public GameObject AlchUI;
    public GameObject Player;
    public Camera AlchCam;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

        }
    }
}
