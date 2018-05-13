using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaskThrow : MonoBehaviour {

    public GameObject Flask;
    GameObject Trowhing;
    public bool throwed = true;
    public float force = 500;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) & throwed)
        {
            Trowhing = Instantiate(Flask, transform.position, transform.rotation);
            Trowhing.GetComponent<Rigidbody>().AddForce(transform.forward*force);
        }
    }
    
}