using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTxt : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = GameManager.instance.score.ToString();
    }
}
