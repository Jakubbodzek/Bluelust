using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DiamondsAnimationsLevel2B : MonoBehaviour
{
    // d1 stands for diamond1 etc...
    [SerializeField] private Transform d1, d2, d3, d4;
    [SerializeField] private float animDuration;

    private void Start()
    {
        d1.DOMoveY(3.8f, animDuration).SetLoops(-1, LoopType.Yoyo);
        d2.DOMoveY(7.8f, animDuration).SetLoops(-1, LoopType.Yoyo);
        d3.DOMoveY(19.8f, animDuration).SetLoops(-1, LoopType.Yoyo);
        d4.DOMoveY(24.8f, animDuration).SetLoops(-1, LoopType.Yoyo);
    }
}
