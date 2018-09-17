using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staty : MonoBehaviour {
    public int HP = 3;
    public int XP = 0;
    public int lvl = 1;
    public bool koniec_poziomu = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (HP <= 0)
            Destroy(GetComponent<Ruch_Princces>());
	}
}
