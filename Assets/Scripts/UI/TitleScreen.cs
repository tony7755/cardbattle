using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour {

	public void start()
    {
        SceneManager.LoadScene("Main Menu");
    }

}