using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer rend;
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            rend.material.color = other.gameObject.GetComponent<Renderer>().material.color;
        }
    }
}
