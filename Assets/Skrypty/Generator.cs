using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject Gracz;
    public GameObject PRZECIWNIK1;
    public GameObject apteczka;
    // Use this for initialization


    void Start()
    {
        //// przeciwnicy
        System.Random random = new System.Random();
        int Liczba_losowa;
        for (int i = -3; i < 4; i++)
        {
            for (int j = -3; j < 4; j++)
            {
                Liczba_losowa = random.Next(100);
                if (i == -3 && j == 3)
                { }
                else if (i == 3 && j == -3)
                { }
                else if (Liczba_losowa <= 25)
                {
                    Instantiate(PRZECIWNIK1, new Vector3(3 * i, 0, 3 * j), new Quaternion(0, 180, 0, 0));
                }
                else if (Liczba_losowa < 40)
                {
                    Instantiate(apteczka, new Vector3(3 * i, 1, 3 * j), new Quaternion(0, 180, 0, 0));
                }

            }
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if(Gracz.GetComponent<Staty>().koniec_poziomu==true)
        {
            System.Random random = new System.Random();
            int Liczba_losowa;
            for (int i = -3; i < 4; i++)
            {
                for (int j = -3; j < 4; j++)
                {
                    Liczba_losowa = random.Next(100);
                    if (i == -3 && j == 3)
                    { }
                    else if (i == 3 && j == -3)
                    { }
                    else if (Liczba_losowa <= 25)
                    {
                        Instantiate(PRZECIWNIK1, new Vector3(3 * i, 0, 3 * j), new Quaternion(0, 180, 0, 0));
                    }
                    else if (Liczba_losowa < 40 )
                    {
                        Instantiate(apteczka, new Vector3(3 * i, 1, 3 * j), new Quaternion(0, 180, 0, 0));
                    }
                }
            }
            Gracz.GetComponent<Staty>().koniec_poziomu = false;
        }
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}
