using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLight : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * GameManager.instance.speedGame);
    }
}
