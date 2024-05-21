using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public LevelCreator[] levels;
    public int currentLevelIndex = 0;
    


    private void Awake()
    {
        levels = Resources.LoadAll<LevelCreator>("Levels");
        ActionManager.NextAction += LoadNextLevel;
    }

    private void Start()
    {
        LoadLevel();
    }

    public int GetLevelIndex()
    {
        currentLevelIndex = PlayerPrefs.GetInt("levelIndex", 1);
        return currentLevelIndex;
    }

    private void SetLevelIndex(int levelIndex)
    {
        PlayerPrefs.SetInt("levelIndex", levelIndex);
    }

    public void LoadLevel()
    {
        if (GetLevelIndex() >= 0 && GetLevelIndex() <= levels.Length)
        {
            Instantiate(levels[GetLevelIndex() - 1].map);
        }
        else if (GetLevelIndex() > levels.Length)
        {
            int levelindex = (GetLevelIndex() - 1) % levels.Length;
            Instantiate(levels[levelindex].map);
        }
    }

    public void LoadNextLevel()
    {
        int currentLevel = GetLevelIndex();
        currentLevel++;
        SetLevelIndex(currentLevel);
        SceneManager.LoadScene(0);
        ActionManager.NextAction -= LoadNextLevel;
    }


    // public void PlayAgain()
    // {
    //     SceneManager.LoadScene(1);
    //     Time.timeScale = 1f;
    //     PlayerPrefs.DeleteKey("point");
    // }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
