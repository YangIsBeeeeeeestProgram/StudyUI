using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReminController : MonoBehaviour {

    Text text;

    private static ReminController instance;
    public static ReminController Instance { get { return instance; } }


    private void Awake()
    {
        instance = this;
        text = this.GetComponent<Text>();
        text.enabled = false;
    }


    public void ShowReminding(string content,Color color)
    {
        string str =string.Format("温馨提示:｛0｝", content.Trim());
        text.text = content;
        text.color = color;
        StartCoroutine(Remind());
    }


    IEnumerator Remind()
    {
        text.enabled = true;
        yield return new WaitForSeconds(2.0f);
        text.enabled = false;
        yield break;
    }


}
