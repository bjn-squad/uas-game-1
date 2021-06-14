using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunc : MonoBehaviour
{
    public AudioSource buttonPress;

    public void PlayGame(){
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 2;
        SceneManager.LoadScene(1);
    }

    public void QuitGame(){
        buttonPress.Play();
        Application.Quit();
    }

    public void PlayCredits(){
        buttonPress.Play();
        SceneManager.LoadScene(3);
    }
    
    public void TutorialGame(){
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }
}
