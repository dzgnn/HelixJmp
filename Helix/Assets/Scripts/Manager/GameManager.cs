using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    UIManager uimanager;

    public GameObject gameOverPnl;


    public static GameManager ins;

    void Awake()
    {
        ins = this;
        ActionManager.DeadAction += GameOver;
    }
    
    private void Start()
    {
        uimanager = FindObjectOfType<UIManager>();
        if (gameOverPnl)
        {
            gameOverPnl.SetActive(false);
        }

        

    }

    public void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0;
        uimanager.GameOverPointTxt();
        gameOverPnl.SetActive(true);
        PlayerPrefs.DeleteKey("point");
        ActionManager.DeadAction -= GameOver;
    }


}
