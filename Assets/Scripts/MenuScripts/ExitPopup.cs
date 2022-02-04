using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ExitPopup : MonoBehaviour
{

    [SerializeField] private RectTransform exitPopup;
    public void OpenPopupPanel()
    {
        exitPopup.DOAnchorPos(new Vector2(0, 0), .4f);
        exitPopup.DOScale(1f, .4f);
    }
    public void ExitPopupPanel()
    {
        exitPopup.DOScale(0f, .4f);
        exitPopup.DOAnchorPos(new Vector2(0, -300), .4f);
        //exitPopup.DOScale(new Vector3(0f, 0f, 1f), .4f);
    }
}
