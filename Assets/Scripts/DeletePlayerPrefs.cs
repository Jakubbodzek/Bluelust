using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerPrefs : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayerPrefs.DeleteAll();
            Debug.Log("PlayerPrefsDeleted");
        }
    }
}
