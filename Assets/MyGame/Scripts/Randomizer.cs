using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour {

    private System.Random rnd = new System.Random();
    private System.Random seedRnd = new System.Random(123);

    // Use this for initialization
    void Start () {
        Debug.Log("System Random: " + rnd.Next(0, 5));
        Debug.Log("System Random with seed: " + seedRnd.Next(0, 5));
        Debug.Log("UnityEngine Random: " + UnityEngine.Random.Range(0, 5));

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
