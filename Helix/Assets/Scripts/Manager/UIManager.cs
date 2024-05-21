using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int winPoint = 0;
    string currentLevel;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI levelText;
    LevelManager levelManager;
    public static UIManager instance;

    private void Awake()
    {
        instance = this;
        levelManager = FindObjectOfType<LevelManager>();
        
    }

    void Start()
    {
        Level();
        winPoint = PlayerPrefs.GetInt("point");
    }

    void Update()
    {
        TextToUI();
    }

    public void AddPoint()
    {
        winPoint += 100;
        PlayerPrefs.SetInt("point", winPoint);
        
    }

    private void TextToUI()
    {
        scoreText.text = "Score \n" + winPoint.ToString();
    }

    public void GameOverPointTxt()
    {
        gameOverScoreText.text = "Score \n" + winPoint.ToString();
    }

    private void Level()
    {
        currentLevel = levelManager.GetLevelIndex().ToString();
        //currentLevel = SceneManager.GetActiveScene().name;
        levelText.text ="Level: " +  currentLevel;
    }
}
