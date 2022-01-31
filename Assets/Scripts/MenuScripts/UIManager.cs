using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private RectTransform mainMenu, creditsMenu, optionsMenu, startMenu;

    void Start()
    {
        mainMenu.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void StartButton()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 1100), 0.5f);
        startMenu.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void StartButtonExit()
    {
        startMenu.DOAnchorPos(new Vector2(2000, 0), 0.5f);
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void CreditsButton()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 1100), 0.5f);
        creditsMenu.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void CreditsButtonExit()
    {
        creditsMenu.DOAnchorPos(new Vector2(-2000, 0), 0.5f);
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void OptionsButton()
    {
        mainMenu.DOAnchorPos(new Vector2(0, 1100), 0.5f);
        optionsMenu.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void OptionsButtonExit()
    {
        optionsMenu.DOAnchorPos(new Vector2(0, -1100), 0.5f);
        mainMenu.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }




}
