using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;

public class GameHints : MonoBehaviour
{

    [SerializeField] private int hints;

    [SerializeField] private GameObject hintDisplay;

    [SerializeField] private bool generateHints = false;

    void Update()
    {
        if(generateHints == false)
        {
            generateHints = true;
            StartCoroutine(Hints());
        }
    }

    IEnumerator Hints()
    {
        hints = Random.Range(1, 10);
        if(hints == 1)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Remember to finish the tutorial before starting!";
        }
        if (hints == 2)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Diamonds are called Lust.";
        }
        if (hints == 3)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Convert diamonds into player skins!";
        }
        if (hints == 4)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Complete the levels and find the legendary skin!";
        }
        if (hints == 5)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "The game is easy to learn... But hard to master!";
        }
        if (hints == 6)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Complete the missions to earn more Lust!";
        }
        if (hints == 7)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Finish the tutorial to unlock a new skin!";
        }
        if (hints == 8)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "You can tilt your phone to adjust the screen.";
        }
        if (hints == 9)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Explore the levels and earn more Lust!";
        }
        if (hints == 10)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "If you found a bug please report it!";
        }
        yield return new WaitForSeconds(7);
        generateHints = false;
    }
}
