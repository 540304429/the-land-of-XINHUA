using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Control : MonoBehaviour
{

    public Animator anim;
    private BoxCollider coll;
    private Rigidbody rb;
    [Header("movement parameters")]
    public float speed = 8f;

    [Header("status")]
    public bool isOnGround;
    public bool isWalking;
    Vector3 Xmovement = new Vector3(1, 0, 0);
    Vector3 Ymovement = new Vector3(0, 1, 0);
    Vector3 Zmovement = new Vector3(0, 0, 1);
    int direction;
    float orginalZ;
    //public int Power = 10;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            
            Walk();
            
        }
        if (Input.GetKey("d"))
        {
            StopWalking();
        }
    }
    void Update()
    {
       
    }
    void Walk() {
        //rb.transform.position += -Zmovement * speed;
        //Vector3 direction = new Vector3(rb.velocity.x, rb.velocity.x, -speed * Time.deltaTime);
        isWalking = true;
        orginalZ = transform.position.z;
        direction = -1;
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, direction * speed * Time.deltaTime);
        //rb.AddForce(direction*Zmovement, ForceMode.Force);
        anim.SetBool("Walk", true);
        


    }
    void StopWalking() {
        isOnGround = true;
        rb.velocity = new Vector3(0, 0, 0);
        anim.SetBool("Walk", false);

    }




}
