using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpandDown2 : MonoBehaviour
{
    public Transform mytransform;

    public float speed;
    
    public int roger = 5;
    void Start()
    {
        mytransform.position = new Vector3(0, 5, 15);
    }

    private void Update()
    {
        mytransform.position =
            mytransform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}
