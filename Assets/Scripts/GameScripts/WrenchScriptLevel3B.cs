using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class WrenchScriptLevel3B : MonoBehaviour
{

    [SerializeField] private GameObject killingPlatform1, killingPlatform2;
    [SerializeField] private Transform wrench1, wrench2;
    [SerializeField] private float animDuration;

    private void Start()
    {
        wrench1.DOMoveY(19.8f, animDuration).SetLoops(-1, LoopType.Yoyo);
        wrench2.DOMoveY(-2.8f, animDuration).SetLoops(-1, LoopType.Yoyo);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wrench"))
        {
            Destroy(killingPlatform1);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Wrench2"))
        {
            Destroy(killingPlatform2);
            Destroy(other.gameObject);
        }
    }
}
