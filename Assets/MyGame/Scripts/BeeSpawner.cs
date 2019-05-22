using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpawner : MonoBehaviour
{
    private bool spawn = true;

    public Bee beePrefab;
    public GameObject beeParent;
    public GameObject boundaryLeft;
    public GameObject boundaryRight;
    public GameObject boundaryTop;

    public float minSpawnDelay = 1.0f;
    public float maxSpawnDelay = 5.0f;

    public int xMinPos;
    public int xMaxPos;
    public int yPos;

    public float beeMinSize = 0.1f;
    public float beeMaxSize = 0.5f;

    /*private void Awake()
    {
        xMinPos = (int)boundaryLeft.transform.position.x;
        xMaxPos = (int)boundaryRight.transform.position.x;
        yPos = (int)boundaryTop.transform.position.y;
    }*/

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            CloneBee();
        }
    }

    private void CloneBee()
    {
        float beeSize = Random.Range(beeMinSize, beeMaxSize);

        Bee beeClone = (Bee)Instantiate(beePrefab, transform.position, transform.rotation);
        beeClone.transform.SetParent(beeParent.transform);
        beeClone.transform.localPosition = new Vector3(Random.Range(xMinPos, xMaxPos), beeParent.transform.position.y, 0f);
        beeClone.transform.localScale = new Vector3(beeSize, beeSize, 0);
        beeClone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2, 2), Random.Range(-6, -2));
    }
}
