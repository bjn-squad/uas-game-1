using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public AudioSource levelMusic;
    public GameObject pausedMenu;
    public AudioSource pauseJingle;

    void Update()
    {
        if(Input.GetButtonDown("Cancel")){
            if(isPaused == false){
                pauseJingle.Play();
                Time.timeScale = 0; // fungsi default unity kalo timescale 0 semua dilayar ngefreeze
                isPaused = true;
                Cursor.visible = true;
                levelMusic.Pause(); 
                pausedMenu.SetActive(true);
            } else if(isPaused == true){
                pausedMenu.SetActive(false);
                levelMusic.UnPause();
                Cursor.visible = false;
                isPaused = false;
                Time.timeScale = 1; // unfreeze
            }
        }    
    }

    public void ResumeGame(){
        pausedMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        isPaused = false;
        Time.timeScale = 1; // unfreeze
    }
   
    public void RestartLevel(){
        pausedMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = false;
        isPaused = false;
        Time.timeScale = 1; // unfreeze
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);
    }
    
    public void QuitToMenu(){
        pausedMenu.SetActive(false);
        levelMusic.UnPause();
        Cursor.visible = true;
        isPaused = false;
        Time.timeScale = 1; // unfreeze
        SceneManager.LoadScene(0);
    }
}
