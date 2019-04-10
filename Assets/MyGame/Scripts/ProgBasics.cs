using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Operators();
        //XY();
        //VoidMethod();
        //AddNumbers(5, 3);
        //MultNumbers(4, 2, 3, 8);
        Combine();
        Debug.Log(MyText("alexh"));
        string drama = MyText("alexh");
        Debug.Log("neu " + drama);
        
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

    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("add numbers = " + c);
    }

    public void MultNumbers(int a, int b, int c, int d)
    {
        int e = a * b * c * d;
        Debug.Log("multiply numbers = " + e);
    }

    public void Combine()
    {
        AddNumbers(7, 2);
        MultNumbers(5, 2, 4, 6);
    }

    public string MyText(string myName)
    {
        return "Drama" + " " + myName;
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
