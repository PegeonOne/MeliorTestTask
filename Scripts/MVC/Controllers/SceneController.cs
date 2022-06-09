using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController
{
    enum Levels { MainMenu, GameLevel}

    public void StartTheGame()
    {
        SceneManager.LoadSceneAsync((int)Levels.GameLevel);
    }
    public void BackToMenu()
    {
        SceneManager.LoadSceneAsync((int)Levels.MainMenu);
    }
}
