using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ExitPopup : MonoBehaviour
{

    [SerializeField] private RectTransform exitPopup;

    [SerializeField] private Vector3 exitPositionFirst, exitPositionSecond;
    public void OpenPopupPanel()
    {
        exitPopup.DOMove(exitPositionFirst, .4f);
        exitPopup.DOScale(1f, .4f);
        
    }
    public void ExitPopupPanel()
    {
        exitPopup.DOScale(0f, .4f);
        exitPopup.DOMove(exitPositionSecond, .4f);
        //exitPopup.DOScale(new Vector3(0f, 0f, 1f), .4f);
    }
}
