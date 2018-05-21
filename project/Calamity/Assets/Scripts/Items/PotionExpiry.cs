using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
                switch (gameObject.GetComponent<Item>().itemID)
                {
                    case 31:
                        other.GetComponent<NavMeshAgent>().speed *= 0.5F;
                        break;
                    case 32:
                        other.transform.localScale = new Vector3(0.25F, 0.25F, 0.25F);
                        other.GetComponent<EnemyAI>().agressive = false;
                        break;

                    default:
                        break;
                }
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
