using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collection : MonoBehaviour
{

    public AudioSource tickSource;

    void Start()
    {
        tickSource = GetComponent<AudioSource>();
    }
        void OnTriggerEnter2D(Collider2D col)
    {
        tickSource.Play();
        Destroy(gameObject);
    }
}
