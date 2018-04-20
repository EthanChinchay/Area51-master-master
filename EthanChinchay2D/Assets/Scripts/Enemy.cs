using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Ay me mori we no mames");
            Destroy(GameObject.FindWithTag("Player"));
        }
    }
}

