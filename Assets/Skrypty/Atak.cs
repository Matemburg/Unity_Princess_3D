using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atak : MonoBehaviour
{
    public GameObject Gracz;
    // Use this for initialization
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Gracz)
        {
            Gracz.GetComponent<Staty>().HP--;
            Destroy(gameObject);
        }
   
    }
    private void Update()
    {
        if (Gracz.GetComponent<Staty>().koniec_poziomu == true && transform.position.y == 0)
        {
            Destroy(gameObject);
        }
    }
}
    // Update is called once per frame
