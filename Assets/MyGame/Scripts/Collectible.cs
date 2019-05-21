using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreVisualizer;

    void Start()
    {
        scoreVisualizer.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent" + collision.gameObject.name);

        if (collision.gameObject.name == "Fish")
        {
            score += 5;
            Debug.Log("score: " + score);
            scoreVisualizer.text = score.ToString();
        }
        else if (collision.gameObject.name == "GhostLine")
        {
            score -= 10;
            Debug.Log("score: " + score);
            scoreVisualizer.text = score.ToString();
            Destroy(gameObject, 1f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CollisionEvent");
    }

}
