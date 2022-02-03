using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class KillingPlatformAnimationsLevel2B : MonoBehaviour
{
    // d1 stands for diamond1 etc...
    [SerializeField] private Transform killingPlatform1, killingPlatform2;
    [SerializeField] private float animDuration, animDuration2;
    [SerializeField] private Vector3 platformPosition;

    private void Start()
    {
        killingPlatform1.DOMoveY(5, animDuration).SetLoops(-1, LoopType.Yoyo);
        killingPlatform2.DOMove(platformPosition, animDuration2).SetLoops(-1, LoopType.Yoyo);
    }
}
