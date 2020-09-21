using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sphere;

    public GameObject SpherePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Sphere != null)
                Destroy(Sphere);
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if (Sphere == null)
            Sphere = Instantiate(SpherePrefab, new Vector3(0, -5, 0), Quaternion.identity); 
        }
    }
}
