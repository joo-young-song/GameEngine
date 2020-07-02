using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject ball;
    public GameObject point;

    Vector3 shootingDegree;

    float ball_speed = 250f;

    void Start()
    {
       
        InvokeRepeating("BallShoot", 0, 5);
                 
    }

    void BallShoot()
    {
        GameObject instantItem = Instantiate(ball, point.transform.position, point.transform.rotation);

        shootingDegree = Vector3.Normalize(point.transform.position);

        Rigidbody rigidbody = instantItem.GetComponent<Rigidbody>();
        rigidbody.AddForce(-(shootingDegree * ball_speed), ForceMode.Impulse);
    }

}
