using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PrivateVoidStart : MonoBehaviour
{
    public Transform myTransform;

    public float speed;

    private float timer;
    void Start()
    {
        myTransform.position = new Vector3(0, Random.Range(0.0f, 6.0f), 5);
        timer = 0;
    }
    void Update()
    {
        //myTransform.position =
        //myTransform.position + myTransform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;

        timer += Time.deltaTime;
        if (timer >= 2)
        {
            timer = 0;
            myTransform.position += new Vector3(1, 0, 0);
        }
    }
}
