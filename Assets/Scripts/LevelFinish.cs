using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject finalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScoreCalc;
    public GameObject lockPosition;
    public GameObject fadeOut;

    void OnTriggerEnter(){
        GetComponent<BoxCollider>().enabled = false;
        lockPosition.SetActive(true);
        lockPosition.transform.parent = null;
        timeCalc = GlobalTimer.extendScore * 10;
        timeLeft.GetComponent<Text>().text = "Time Left : " +GlobalTimer.extendScore+" x 10";
        theScore.GetComponent<Text>().text = "Score : " +GlobalScore.currentScore;
        totalScoreCalc = GlobalScore.currentScore + timeCalc;
        finalScore.GetComponent<Text>().text = "Final Score : "+totalScoreCalc; 
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore(){
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        finalScore.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = 0;
        SceneManager.LoadScene(RedirectToLevel.nextLevel);
    }
}
