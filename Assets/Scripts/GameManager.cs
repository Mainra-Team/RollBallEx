using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float speedGame;
    [HideInInspector] public int score;
    bool gameover;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
        speedGame = 5;
    }

    // Update is called once per frame
    void Update()
    {
        score = (int)Time.timeSinceLevelLoad;
        speedGame = 5 + (score / 10);

        if (Input.anyKeyDown && gameover)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

    #region GameOver
    [Header("GameOver")]
    public GameObject gameOverPanel;
    public void GameOver()
    {
        Time.timeScale = 0;
        gameover = true;
        gameOverPanel.SetActive(true);
    }
    #endregion
}
