using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTowards : MonoBehaviour {

    public GameObject flyTowards;
    public string flyTowardsStartPointName;
    public bool constant;
    public float speedAccel;
    public float speedMax;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();

        if (!constant)
        {
            flyTowards = GameObject.Find(flyTowardsStartPointName);
            //transform.LookAt(flyTowards.transform);
            rb.AddForce((flyTowards.transform.position - transform.position) * speedMax);
        }
    }

    private void FixedUpdate()
    {
        if(constant && flyTowards != null)
        {
            rb.AddForce((flyTowards.transform.position - transform.position) * speedAccel);
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, speedMax);
        }
    }
}
