using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMelodi : MonoBehaviour
{
    AudioSource audioSource;
    Material material;
    [SerializeField] ScriptableMelodi[] scriptableMelodi;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        material = GetComponent<Renderer>().material;
        ScriptableMelodi getMelodi = scriptableMelodi[Random.Range(0, scriptableMelodi.Length)];

        //set Melodi
        audioSource.clip = getMelodi.clips;
        material.color = getMelodi.color;
    }
    private void Update()
    {
        //move up
        transform.Translate(Vector3.up * Time.deltaTime * 5f);

        //destroy
        if (transform.position.y > 12)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            other.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }
}
