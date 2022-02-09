using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    [SerializeField] private Image progressBar;
    [SerializeField] private Transform player, portal;

    private Vector3 portalPosition;
    private float distanceToPortal;

    private void Start()
    {
        portalPosition = portal.position;
        distanceToPortal = PortalDistance();
    }

    private float PortalDistance()
    {
        return Vector3.Distance (player.position, portalPosition);
        //return (portalPosition - player.position).sqrMagnitude;
    }


    private void UpdateProgressBar(float value)
    {
        progressBar.fillAmount = value;
    }

    private void Update()
    {
        if (player.position.y <= portalPosition.y)
        {
            float newDistance = PortalDistance();
            float progressValue = Mathf.InverseLerp(distanceToPortal, 2f, newDistance);

            UpdateProgressBar(progressValue);
        }
    }

}
