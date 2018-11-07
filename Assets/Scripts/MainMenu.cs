using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Start()
    {
        SceneManager.LoadScene("Scenes/Level_1");
        //This loads the first level when the start button is pushed.
    }
    public void Quit()
    {
        Application.Quit();
        //This quits the game when its pressed.
    }
    public void Menu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
        //This loads the Main Menu scene when the button is pressed.
    }
}