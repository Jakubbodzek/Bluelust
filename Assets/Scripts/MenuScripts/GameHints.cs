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
            hintDisplay.GetComponent<TextMeshProUGUI>().DOFade(0f, 10f).SetLoops(-1);
        }
    }

    IEnumerator Hints()
    {
        hints = Random.Range(1, 6);
        if(hints == 1)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Remember to finish the tutorial before starting!";
        }
        if (hints == 2)
        {
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Diamonds are called Blue Lust here!";
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
            hintDisplay.GetComponent<TextMeshProUGUI>().text = "Complete the missions to unlock new player skins!";
        }
        yield return new WaitForSeconds(10);
        generateHints = false;
    }
}
