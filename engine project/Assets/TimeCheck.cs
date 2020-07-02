using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCheck : MonoBehaviour
{
    Text timeLabel;

    public static float nowTime;

    float clearTime = 100f;

    void Start()
    {
        nowTime = Time.deltaTime;
        timeLabel = GetComponent<Text>();

    }

    void Update()
    {
        nowTime = nowTime + Time.deltaTime;
        if (nowTime < 100f)
        {
            timeLabel.text = "TIME : " + nowTime.ToString();
        }
        else
        {
            timeLabel.text = "Time : " + clearTime.ToString();
        }
    }
}
