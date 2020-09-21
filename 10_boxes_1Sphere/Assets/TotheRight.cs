using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotheRight : MonoBehaviour
{
    private Transform myTransform;
    private float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
        speed = Random.Range(1.00f, 3.00f);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position += Vector3.right * Time.deltaTime * speed;

        if (myTransform.position.x > 8)
        {
            myTransform.position += Vector3.left * 16;
        }
    }
}
