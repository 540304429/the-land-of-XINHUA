using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Control : MonoBehaviour
{

    private BoxCollider coll;
    private Rigidbody rb;
    [Header("movement parameters")]
    public float speed = 0.08f;

    [Header("status")]
    public bool isOnGround;
    public bool isWalking;
    Vector3 Xmovement = new Vector3(1, 0, 0);
    Vector3 Ymovement = new Vector3(0, -1, 0);



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {

            rb.transform.position += Xmovement*speed;

        }

    }
    void Update()
    {
       
    }
    
}
