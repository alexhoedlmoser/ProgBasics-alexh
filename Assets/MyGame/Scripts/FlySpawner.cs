using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    public Fly flyPrefab;

    void Update()
    {
        CloneFly();
    }

    private void CloneFly()
    {
        Fly flyClone = (Fly)Instantiate(flyPrefab, transform.position, transform.rotation);
    }
}
