using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;//load a scence ";" at the end of a line
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public void start()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void back()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
