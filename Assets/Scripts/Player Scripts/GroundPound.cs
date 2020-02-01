using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPound : MonoBehaviour
{
    private PlayerStatuses status;

    [SerializeField] private float dropSpeed;
    private bool pounding;
    // Start is called before the first frame update
    void Start()
    {
        dropSpeed = -30f;
        pounding = false;
        status = FindObjectOfType<PlayerStatuses>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!status.getGrounded() && Input.GetButtonDown("GroundPound"))
        {
            pounding = true;
        }
    }

    void FixedUpdate()
    {
        if (pounding)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, dropSpeed);

        }

        if (status.getGrounded())
        {
            pounding = false;
        }
    }
}
