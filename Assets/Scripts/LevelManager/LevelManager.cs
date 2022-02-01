using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private Button[] levelButton;

    private void Awake()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        if (PlayerPrefs.GetInt("Level") >= 1)
        {
            levelReached = PlayerPrefs.GetInt("Level");
        }
        for (int i = 0; i < levelButton.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButton[i].interactable = false;
            }
        }
    }

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
