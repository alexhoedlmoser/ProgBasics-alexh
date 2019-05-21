using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    private bool spawn = true;

    public Fly flyPrefab;
    public GameObject flyParent;

    public float minSpawnDelay = 1.0f;
    public float maxSpawnDelay = 5.0f;
   
    public int xMinLeft;
    public int xMaxLeft;
    public int yPos;

    public float flyMinSize = 0.1f;
    public float flyMaxSize = 0.5f;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            CloneFly();
        }

    }


    private void CloneFly()
    {
        float flySize = Random.Range(flyMinSize, flyMaxSize);

        Fly flyClone = (Fly)Instantiate(flyPrefab, transform.position, transform.rotation);
        flyClone.transform.SetParent(flyParent.transform);
        flyClone.transform.localPosition = new Vector3(Random.Range(xMinLeft, xMaxLeft), flyParent.transform.position.y, 0f);
        flyClone.transform.localScale = new Vector3(flySize, flySize, 0);
        flyClone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Random.Range(-6, -2));
    }
}
