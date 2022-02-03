using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PortalScript : MonoBehaviour
{

    [SerializeField] private Transform portal;
    [SerializeField] private float animDuration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            portal.DOScaleY(1.7f, animDuration);
            NextLevel();
            //victoryPanel.DOAnchorPos(new Vector2(0, 0), 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            portal.DOScaleY(0.1f, animDuration);
        }
    }
    //Fix portal bug (unlocks all levels...)
    public void NextLevel()
    {
        StartCoroutine(LevelFinished());
    }
    IEnumerator LevelFinished()
    {
        yield return new WaitForSeconds(1.1f);
        PlayerPrefs.SetInt("levelReached", PlayerPrefs.GetInt("levelReached") + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
