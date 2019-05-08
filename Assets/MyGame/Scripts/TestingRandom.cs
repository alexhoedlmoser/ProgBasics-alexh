using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingRandom : MonoBehaviour {

    public float minValX = -6f;
    public float maxValX = 6f;
    private float rndVal;
    private float rndVal2;
    private System.Random rnd = new System.Random();

    private 

	// Use this for initialization
	void Start () {
        rndVal = rnd.Next(0, 10);
        Debug.Log("System Random: " + rndVal);
        rndVal2 = UnityEngine.Random.Range(4, 100);
        Debug.Log("Unity Random: " + rndVal2);
    }

    public void ChangeCollectible()
    {
        gameObject.transform.position = new Vector3(UnityEngine.Random.Range(minValX, maxValX), 0f, 0f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
