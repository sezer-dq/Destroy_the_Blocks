using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SahneKontrolu : MonoBehaviour
{
    public int currentscene;
    private void Start()
    {

        if (SceneManager.GetActiveScene().buildIndex < 5) 
        {
            currentscene = SceneManager.GetActiveScene().buildIndex;
            SaveLevel();
            Debug.Log(currentscene);
        }
    }
    void UnlockNewLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }
    public void SaveLevel()
    {
        SaveSystem.SaveLevel(this);
    }
    public void LoadLevel() 
    {
        LevelData data=  SaveSystem.LoadLevel();
        currentscene= data.level;
    }
    public void GoToScene()
    {
        Debug.Log(gameObject.name);
    }
    public void NextScene()
    {
        int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitTheGame()
    {
        Application.Quit();
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void SahneyeYonlen(string sahneIsmi)
    {
        SceneManager.LoadScene(sahneIsmi);
    }
    public void BlokBitti()
    {
        if (BlockController.blockcount <= 0)
        {
            UnlockNewLevel();
            NextScene();
        }
    }
}
