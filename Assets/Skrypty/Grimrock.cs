using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grimrock : MonoBehaviour {
    public float z=0;
    public float speedrotation = 1;
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(-9.0f, 1, 9.0f);
    }
	
	// Update is called once per frame
	void Update () {
        if (z > 0)
        {
            transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z , transform.rotation.w);
            z-=speedrotation;    
        }
        if (z < 0)
        {
            transform.rotation = new Quaternion(transform.rotation.x - speedrotation, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            z +=speedrotation;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            z += 90;
        }
 
    }
}
