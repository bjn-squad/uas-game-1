using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectToLevel.redirectToLevel = 2;
        RedirectToLevel.nextLevel = 5;
        StartCoroutine(fadeInOff());
    }

    IEnumerator fadeInOff(){
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}
