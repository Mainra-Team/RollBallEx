using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGround", 2f, Random.Range(0.5f, 2f));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnGround()
    {
        Instantiate(groundPrefab, new Vector3(Random.Range(-2.85f, 2.85f), Random.Range(-9.5f, -9), 6), Quaternion.identity, transform);
    }
}
