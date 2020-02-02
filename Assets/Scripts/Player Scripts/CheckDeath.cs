using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDeath : MonoBehaviour
{
    private PlayerStatuses status;
    public Collider2D Collider;

    void Start()
    {
        status = FindObjectOfType<PlayerStatuses>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.name == Collider.name && collider.tag == Collider.tag)
        {
            status.isAlive = false;
            Debug.Log("Test");
        }
    }
}
