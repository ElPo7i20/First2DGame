using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LastLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void FirstLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void SecondLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void ThirdLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
    public void FourthLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }
    public void FifthLevel()
    {
        SceneManager.LoadScene(sceneBuildIndex: 4);
    }
    public void Menu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 5);
    }
}
