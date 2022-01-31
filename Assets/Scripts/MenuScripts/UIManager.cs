using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] private RectTransform mainPanel, creditsPanel, optionsPanel, startPanel, eulaPanel, shopPanel, missionsPanel, reportPanel, scorePanel;

    void Start()
    {
        mainPanel.DOAnchorPos(Vector2.zero, 0.5f);
    }
    public void StartButton()
    {
        mainPanel.DOAnchorPos(new Vector2(-1920, 0), 0.5f);
        startPanel.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void StartButtonExit()
    {
        startPanel.DOAnchorPos(new Vector2(1920, 0), 0.5f);
        mainPanel.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void CreditsButton()
    {
        mainPanel.DOAnchorPos(new Vector2(1920, 0), 0.5f);
        creditsPanel.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void CreditsButtonExit()
    {
        creditsPanel.DOAnchorPos(new Vector2(-1920, 0), 0.5f);
        mainPanel.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void OptionsButton()
    {
        mainPanel.DOAnchorPos(new Vector2(0, 1100), 0.5f);
        optionsPanel.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void OptionsButtonExit()
    {
        optionsPanel.DOAnchorPos(new Vector2(0, -1100), 0.5f);
        mainPanel.DOAnchorPos(new Vector2(0, 0), 0.5f);
    }

    public void EulaButton()
    {
        eulaPanel.DOAnchorPos(new Vector2(0, 0), 1f);
    }

    public void EulaButtonExit()
    {
        eulaPanel.DOAnchorPos(new Vector2(0, 2000), 1f);
    }

    public void ShopButton()
    {
        shopPanel.DOAnchorPos(new Vector2(0, 0), 1f);
    }

    public void ShopButtonExit()
    {
        shopPanel.DOAnchorPos(new Vector2(0, 2000), 1f);
    }

    public void MissionButton()
    {
        missionsPanel.DOAnchorPos(new Vector2(0, 0), 1f);
    }

    public void MissionButtonExit()
    {
        missionsPanel.DOAnchorPos(new Vector2(0, 2000), 1f);
    }

    public void ReportButton()
    {
        reportPanel.DOAnchorPos(new Vector2(0, 0), 1f);
    }

    public void ReportButtonExit()
    {
        reportPanel.DOAnchorPos(new Vector2(0, 2000), 1f);
    }

    public void ScoreButton()
    {
        scorePanel.DOAnchorPos(new Vector2(0, 0), 1f);
    }

    public void ScoreButtonExit()
    {
        scorePanel.DOAnchorPos(new Vector2(0, 2000), 1f);
    }
}
