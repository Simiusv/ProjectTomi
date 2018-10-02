using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	
	public void NewGame ()
    {
        //This should play an opening cutscene once we figure out how to do that
        SceneManager.LoadScene(1);
	}

    public void LoadGame ()
    {
        SceneManager.LoadScene(2);
    }

    public void Settings ()
    {

    }

    public void QuitGame ()
    {
        Application.Quit();
    }

}
