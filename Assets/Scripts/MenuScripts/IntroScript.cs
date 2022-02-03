using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroScript : MonoBehaviour
{


    private float introTime = 6f;

    void Start()
    {
        StartCoroutine(WaitForIntro());
    }
    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(introTime);
        SceneManager.LoadScene("MenuView");
    }
}
