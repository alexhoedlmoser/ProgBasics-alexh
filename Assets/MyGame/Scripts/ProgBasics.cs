using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {
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
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
