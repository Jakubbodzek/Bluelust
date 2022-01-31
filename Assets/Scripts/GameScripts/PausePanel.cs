using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PausePanel : MonoBehaviour
{

    [SerializeField] private RectTransform pausePanel;
    public void PauseButton()
    {
        pausePanel.DOAnchorPos(new Vector2(0, 0), 1f);
    }

    public void PauseButtonExit()
    {
        pausePanel.DOAnchorPos(new Vector2(0, 2000), 1f);
    }
}
