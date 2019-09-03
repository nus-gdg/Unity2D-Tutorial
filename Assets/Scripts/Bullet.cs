using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float bulletSpeed = 7.5f;
    
    public void Push(Vector2 startCoordinates, Vector2 endCoordinates)
    {
        float differenceInX = endCoordinates.x - startCoordinates.x;
        float differenceInY = endCoordinates.y - startCoordinates.y;

        this.gameObject.GetComponent<Rigidbody2D>().velocity = (new Vector2(differenceInX, differenceInY)).normalized * bulletSpeed;
    }
}