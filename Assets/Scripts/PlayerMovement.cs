using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField, Range(10, 100)] float speedMove;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizotalLimit();
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speedMove * Time.deltaTime;
    }
    void HorizotalLimit()
    {
        if (transform.position.x > 7.5f)
        {
            transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -7.5)
        {
            transform.position = new Vector3(-7.5f, transform.position.y, transform.position.z);
        }
    }
}
