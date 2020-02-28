using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBall : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Collidable")
        {
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
