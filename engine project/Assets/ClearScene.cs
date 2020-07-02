using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearScene : MonoBehaviour
{
    Text clearLabel;
    void Start()
    {
        clearLabel = GetComponent<Text>();
    }

    void Update()
    {
        if (Collide.check_game_over == true)
        {
            clearLabel.text = "FAIL!!";
            Application.Quit();
        }

        if (TimeCheck.nowTime > 100f)
        {
            clearLabel.text = "CLEAR";
        }
        else if(TimeCheck.nowTime > 110f)
        {
            // 끝내기
            Application.Quit();
        }



    }
}
