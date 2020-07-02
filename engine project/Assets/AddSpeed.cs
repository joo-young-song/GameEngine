using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSpeed : MonoBehaviour
{
    Rigidbody rigidbody;

    int count;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        count = 0;
    }

    void Update()
    {
        if(count == 0 && TimeCheck.nowTime > 60)
        {
            count = count + 1;
            SpeedUp();
        }
        if (count == 1 && TimeCheck.nowTime > 70)
        {
            count = count + 1;
            SpeedUp();
        }
        if (count == 2 && TimeCheck.nowTime > 80)
        {
            count = count + 1;
            SpeedUp();
        }
        if (count == 3 && TimeCheck.nowTime > 90)
        {
            count = count + 1;
            SpeedUp();
        }
        if (count == 4 && TimeCheck.nowTime > 95)
        {
            count = count + 1;
            SpeedUp();
        }
    }

    void SpeedUp()
    {
        rigidbody.velocity = rigidbody.velocity * 2;
    }
}
