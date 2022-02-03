using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ReportSurvey : MonoBehaviour
{

    [SerializeField] private TMP_InputField report;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdEAFOHhdZwNESx4c_rTC0B4bTpClSy5Br1kkVrI3_durH-4w/formResponse";

    public void SendReport()
    {
        StartCoroutine(Send(report.text));
    }

    IEnumerator Send(string survey)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.1931663025", survey);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);
        yield return www.SendWebRequest();
        report.text = "Thank you for your report!";
    }
}
