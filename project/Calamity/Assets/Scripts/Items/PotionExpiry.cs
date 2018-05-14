using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionExpiry : MonoBehaviour {

    public AudioSource audio;
    public ParticleSystem boom;
    public GameObject body;
    public Rigidbody rb;
    public bool throwed = false;
    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")& !throwed & gameObject.CompareTag("Untagged"))
        {
            boom.Play();
            body.SetActive(false);
            throwed = true;
            rb.isKinematic = true;
            audio.Play();
            if(other.CompareTag("Enemy"))
            {
                //Эффект зелья
            }
        }
    }
    private void Update()
    {
        if(!boom.IsAlive() & throwed)
        {
            Destroy(gameObject);
        }
    }
}
