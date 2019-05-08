using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//adding namespaces
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour {

    public Text myText;
    public TextMeshProUGUI myTMPText;
    private int countPresses = 0;
    private System.Random rnd = new System.Random();
    private System.Random seedRnd = new System.Random(123);
   
    public TestingRandom myScript;

    // Use this for initialization
    void Start () {
        myText.text = "Hallooooo";
        myTMPText.text = "Nochmaaaal";
        myText.fontSize = 30;
        Debug.Log("System Random: " + rnd.Next(0, 5));
        Debug.Log("System Random with seed: " + seedRnd.Next(0, 5));
        Debug.Log("UnityEngine Random: " + UnityEngine.Random.Range(0, 5));
    }

    public void AddPress()
    {
        countPresses++;
        //countPresses = countPresses + 1;
        //countPresses += 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
        myTMPText.text = countPresses.ToString();
        Debug.Log("seed " + seedRnd.Next(0, 5));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
