using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GroundMovement : MonoBehaviour
{

    [SerializeField] private Transform ground4;
    [SerializeField] private Transform ground7;
    [SerializeField] private float animDuration;
    private void Start()
    {
        ground4.DOMoveX(6f, animDuration).SetLoops(-1, LoopType.Yoyo);
        ground7.DOMoveY(17f, animDuration).SetLoops(-1, LoopType.Yoyo);
    }
}
