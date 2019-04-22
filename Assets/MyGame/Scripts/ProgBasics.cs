using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

    public int test1;
    public float test2;
    public string test3;
    public string test4part2;
    public double test5;
    public decimal test6;
    public sbyte test7;
    public short test8;
    public long test9;
    public int test10;
    public byte test11;
    public int myGrade;


    // Use this for initialization
    void Start ()
    {
        Operators();
        //XY();
        //VoidMethod();

        test1 = 1;
        Debug.Log("test 1 in Start = " + test1);
        OverwriteTest();

        //AddNumbers(5, 3);
        //MultNumbers(4, 2, 3, 8);
        CombineOperations();

        Debug.Log(MyText("alexh"));
        string drama = MyText("alexh");
        Debug.Log("neu " + drama);

        StringTesting();
        FloatingPointTesting();
        DecimalTesting();
        BoolTesting(true);
        IntegralTesting("short");

        Debug.Log(ReturnAge(17));
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

    // Experiments we did in class together

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

    public void CombineOperations()
    {
        AddNumbers(7, 2);
        MultNumbers(5, 2, 4, 6);
    }

    public string MyText(string myName)
    {
        return "Drama" + " " + myName;
    }

    public void OverwriteTest()
    {
        test1 = 3;
        Debug.Log("test1 in OverwriteTest = " + test1);
    }

    // Experimenting with various Variable-Types and different Methods

    public void StringTesting()
    {
        test3 = "hello!";
        Debug.Log("The computer says " + test3);
    } 

    public void FloatingPointTesting()
    {
        test2 = 4.2222f;
        Debug.Log("float value is " + test2);

        test5 = 13.5672356;
        Debug.Log("double value is " + test5);
    }

    public void DecimalTesting()
    {
        test6 = 250.4596444656m;
        Debug.Log("decimal value is " + test6);
    }

    public void BoolTesting(bool test4)
    {
        if (test4 == true)
        {
            test4part2 = "Yes.";
        }
        else
        {
            test4part2 = "No.";
        }
        Debug.Log("Is it true? " + test4part2);
    }

    public void IntegralTesting(string testIntegralType)
    {
        test7 = -128;
        test8 = 32767;
        test9 = 9223372036854775807;
        test10 = 2147483647;
        test11 = 255;

        if (testIntegralType=="sbyte")
        {
            Debug.Log("this variables minimum range is: " + test7);
        }
        if (testIntegralType == "short")
        {
            Debug.Log("this variables maximum range is: " + test8);
        }
        if (testIntegralType == "long")
        {
            Debug.Log("this variables maximum range is: " + test9);
        }
        if (testIntegralType == "int")
        {
            Debug.Log("this variables maximum range is: " + test10);
        }
        if (testIntegralType == "byte")
        {
            Debug.Log("this variables maximum range is: " + test11);
        }
    }

    public string ReturnAge(int myAge)
    {
        return "My age is " + myAge;
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

}
