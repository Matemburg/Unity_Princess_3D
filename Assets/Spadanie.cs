using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spadanie : MonoBehaviour {
    public GameObject gracz;
    private bool byla = false;

    private void FixedUpdate()
    {
       
    }

    private void Update()
    {
        if (gracz.GetComponent<Staty>().koniec_poziomu == true)
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
            byla = false;
        }

        if (byla == true)
            {
                GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Rigidbody>().isKinematic = false;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        byla = true;
     }
	}
