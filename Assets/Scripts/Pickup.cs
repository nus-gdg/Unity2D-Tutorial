using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int pickupValue;

    ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        scoreManager.increaseScore(pickupValue);
        Destroy(this.gameObject.transform.root.gameObject);
    }
}
