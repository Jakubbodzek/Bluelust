using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
