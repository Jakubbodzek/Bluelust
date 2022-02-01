using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI myScore;
    [SerializeField] private int score = 0;

    public void Start()
    {
        myScore.text = "Score: 0";
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Diamond"))
        {
            myScore.text = "Score: " + ++score;
            Destroy(other.gameObject);
        }
    }
}
