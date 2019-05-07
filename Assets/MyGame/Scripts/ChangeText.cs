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

	// Use this for initialization
	void Start () {
        myText.text = "Hallooooo";
        myTMPText.text = "Nochmaaaal";
        myText.fontSize = 30;
	}

    public void AddPress()
    {
        countPresses++;
        //countPresses = countPresses + 1;
        //countPresses += 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
        myTMPText.text = countPresses.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
