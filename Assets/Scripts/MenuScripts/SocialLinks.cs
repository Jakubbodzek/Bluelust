using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialLinks : MonoBehaviour
{
    public void OpenLinkedIn()
    {
        Application.OpenURL("https://www.linkedin.com/in/jakub-bodzek-7520881a4/");
    }

    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/Jakubbodzek");
    }

    public void OpenTrello()
    {
        Application.OpenURL("https://trello.com/b/YOuzYwOB/blue-lust");
    }

    public void OpenDiscord()
    {
        Application.OpenURL("https://discord.gg/CThKykdhu2");
    }

    public void OpenDataPrivacy()
    {
        Application.OpenURL("https://dataoptout-ui-prd.uca.cloud.unity3d.com/?token=jqsbknglovp1ms94usf2ehus9k09ov61dk39nad8jae7bksh");
    }
}
