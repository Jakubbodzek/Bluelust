using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class WrenchScript : MonoBehaviour
{

    [SerializeField] private GameObject killingPlatform;
    [SerializeField] private Transform wrench;
    [SerializeField] private float animDuration;
    private void Start()
    {
        wrench.DOMoveY(19.8f, animDuration).SetLoops(-1, LoopType.Yoyo);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wrench"))
        {
            Destroy(killingPlatform);
            Destroy(other.gameObject);
        }
    }
}
