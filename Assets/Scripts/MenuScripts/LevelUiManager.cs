using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class LevelUiManager : MonoBehaviour
{

    [SerializeField] private RectTransform theBeginning, noExit, blueDesire, hellishRebirth, finalRage;

    [SerializeField] private Button leftButton, rightButton;

    int menus = 5;
    int currentMenu = 0;
    private float diff = 2000f;

    public void RightButton()
    {
        if (currentMenu == 0)
            return;

        currentMenu--;
        theBeginning.DOAnchorPos(new Vector3(theBeginning.anchoredPosition.x + diff, 0), 1f);
        noExit.DOAnchorPos(new Vector3(noExit.anchoredPosition.x + diff, 0), 1f);
        blueDesire.DOAnchorPos(new Vector3(blueDesire.anchoredPosition.x + diff, 0), 1f);
        hellishRebirth.DOAnchorPos(new Vector3(hellishRebirth.anchoredPosition.x + diff, 0), 1f);
        finalRage.DOAnchorPos(new Vector3(finalRage.anchoredPosition.x + diff, 0), 1f);
    }

    public void LeftButton()
    {
        if (currentMenu == menus - 1)
            return;

        currentMenu++;
        theBeginning.DOAnchorPos(new Vector3(theBeginning.anchoredPosition.x - diff, 0), 1f);
        noExit.DOAnchorPos(new Vector3(noExit.anchoredPosition.x - diff, 0), 1f);
        blueDesire.DOAnchorPos(new Vector3(blueDesire.anchoredPosition.x - diff, 0), 1f);
        hellishRebirth.DOAnchorPos(new Vector3(hellishRebirth.anchoredPosition.x - diff, 0), 1f);
        finalRage.DOAnchorPos(new Vector3(finalRage.anchoredPosition.x - diff, 0), 1f);
    }



    public void StartTimer() //Call this from OnClick
    {
        StartCoroutine(TimeoutEndTurnButton());
    }
    IEnumerator TimeoutEndTurnButton()
    {
        leftButton.interactable = false;
        rightButton.interactable = false;
        yield return new WaitForSeconds(1f);
        leftButton.interactable = true;
        rightButton.interactable = true;
    }

    #region Unused
    //void Start()
    //{
    //    theBeginning.DOAnchorPos(Vector2.zero, 2f);
    //}

    //public void LeftButton()
    //{
    //    theBeginning.DOAnchorPos(new Vector2(-2000, 0), 2f);
    //    noExit.DOAnchorPos(new Vector2(0, 0), 2f);
    //    blueDesire.DOAnchorPos(new Vector2(2000, 0), 2f);
    //    theBeginning.DOAnchorPos(new Vector2(-4000, 0), 2f);
    //    noExit.DOAnchorPos(new Vector2(-2000, 0), 2f);
    //    blueDesire.DOAnchorPos(new Vector2(0, 0), 2f);
    //}

    //public void RightButton()
    //{
    //    theBeginning.DOAnchorPos(new Vector2(0, 0), 2f);
    //    noExit.DOAnchorPos(new Vector2(2000, 0), 2f);
    //    blueDesire.DOAnchorPos(new Vector2(4000, 0), 2f);
    //    theBeginning.DOAnchorPos(new Vector2(0, 0), 2f);
    //    noExit.DOAnchorPos(new Vector2(2000, 0), 2f);
    //    blueDesire.DOAnchorPos(new Vector2(4000, 0), 2f);
    //}

    //

    //public void LeftButton()
    //{
    //    theBeginning.DOAnchorPos(new Vector2(theBeginning.anchoredPosition.x - diff, 0), 2f);
    //    noExit.DOAnchorPos(new Vector2(noExit.anchoredPosition.x - diff, 0), 2f);
    //    blueDesire.DOAnchorPos(new Vector2(blueDesire.anchoredPosition.x - diff, 0), 2f);
    //}

    //public void RightButton()
    //{
    //    theBeginning.DOAnchorPos(new Vector2(theBeginning.anchoredPosition.x + diff, 0), 2f);
    //    noExit.DOAnchorPos(new Vector2(noExit.anchoredPosition.x + diff, 0), 2f);
    //    blueDesire.DOAnchorPos(new Vector2(blueDesire.anchoredPosition.x + diff, 0), 2f);
    //} 
    #endregion

}
