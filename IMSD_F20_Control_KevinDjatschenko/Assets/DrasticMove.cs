using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DrasticMove : MonoBehaviour
{
    public Transform myTransform;

    public float speed;

    private float timer;
     void Start()
    {
        myTransform.position = new Vector3(0, 5, 0);
        timer = 0;
    }

     void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            myTransform.position += new Vector3(1, 0, 0);
        }
    }
}
