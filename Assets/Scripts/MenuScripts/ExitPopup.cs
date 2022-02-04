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
        exitPopup.DOScale(1f, .4f);
    }
    public void ExitPopupPanel()
    {
        exitPopup.DOScale(0f, .4f);
        //exitPopup.DOScale(new Vector3(0f, 0f, 1f), .4f);
    }
}
