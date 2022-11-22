using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGround", 2f, Mathf.Lerp(1.5f, 0.5f, GameManager.instance.score / 100f));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnGround()
    {
        Instantiate(groundPrefab, new Vector3(Random.Range(-6f, 6f), Random.Range(transform.position.y, transform.position.y - 5), 6), Quaternion.identity, transform);
    }
}
