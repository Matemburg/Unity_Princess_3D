using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruch_Princces : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(-9.0f, 1, 9.0f);
    }
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(transform.position.x>-9)
            transform.position += new Vector3(-3.0f, 0, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(transform.position.x<9)
            transform.position += new Vector3(3.0f, 0, 0.0f);
        }

        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (transform.position.z < 9)
            transform.position += new Vector3(0, 0, 3.0f);
        }
         else  if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (transform.position.z > -9)
            transform.position += new Vector3(0.0f, 0, -3.0f);
        }

    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Portal")
        {
            GetComponent<Staty>().koniec_poziomu = true;
            Debug.Log("portal");
            transform.position = new Vector3(-9.0f, 1, 9.0f);
        }
    }


}
