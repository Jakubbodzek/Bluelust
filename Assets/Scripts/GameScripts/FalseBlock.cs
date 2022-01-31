using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseBlock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D hitFalseBlock)
    {
        if(hitFalseBlock.CompareTag("Respawn"))
        {
            transform.position = new Vector3(0, -4, 0);
        }
    }
}
