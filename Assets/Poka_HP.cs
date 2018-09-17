using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poka_HP : MonoBehaviour {
   public  GameObject Gracz;
    // Use this for initialization
    void Start () {
        GetComponent<Text>().text = Gracz.GetComponent<Staty>().HP.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "HP " + Gracz.GetComponent<Staty>().HP.ToString();
    }
}
