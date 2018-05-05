using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionExpiry : MonoBehaviour {

    public ParticleSystem boom;
    public MeshRenderer mesh;
    public Rigidbody rb;
    public bool throwed = false;
    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player")&!throwed)
        {
            boom.Play();
            mesh.enabled = false;
            throwed = true;
            rb.isKinematic = true;
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
