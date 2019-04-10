using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Operators();
        XY();
        VoidMethod();
    }
    
    public void Operators()
    {
        Debug.Log("erste Tests mit Operatoren");

        //Multiplikative Operatoren
        Debug.Log("Multiplikative Operatoren: 10*3 = " + (10 * 3));
        Debug.Log("Multiplikative Operatoren: 9/3 = " + (9 / 3));
        Debug.Log("Multiplikative Operatoren: 10%3 = " + (10 % 3));

        //Additive Operatoren
        Debug.Log("Additive Operatoren: 10+3 = " + (10 + 3));
        Debug.Log("Additive Operatoren: 10-3 = " + (10 - 3));

        //Relationale Operatoren
        Debug.Log("Relationale Operatoren: 10<3 = " + (10 < 3));
        Debug.Log("Relationale Operatoren: 10<=10 = " + (10 <= 10));
        Debug.Log("Relationale Operatoren: 10>3 = " + (10 > 3));
        Debug.Log("Relationale Operatoren: 10>=3 = " + (10 >= 11));

        //Gleichheits Operatoren
        Debug.Log("Gleichheits Operatoren: 10==10 = " + (10 == 10));
        Debug.Log("Gleichheits Operatoren: 10!=10 = " + (10 != 10));

        //Logische Operatoren
        Debug.Log("Logische Operatoren: true&true = " + (true & true));
        Debug.Log("Logische Operatoren: false&&true = " + (false && true));
        Debug.Log("Logische Operatoren: false|true = " + (false | true));
        Debug.Log("Logische Operatoren: true||false = " + (true || false));
    }

    public void XY()
    {
        Debug.Log("XY");
    }

    public void VoidMethod()
    {
        Debug.Log("This is a method with no return type");
    }

	// Update is called once per frame
	void Update ()
    {
		
	}
}
