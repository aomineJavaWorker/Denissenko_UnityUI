using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScriot : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeSceneSample()
    {
        SceneManager.LoadScene("MumbleScene");
    }

    public void ChangeSceneMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    public void Quit()
    {
        Application.Quit();
    }
}
