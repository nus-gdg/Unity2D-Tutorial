using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowStubby : MonoBehaviour
{
    public float movementSpeed = 3.0f;

    private Transform objectTransform;
    private Transform jeffTransform;
    private Rigidbody2D jeffRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        objectTransform = GameObject.Find("Stubby").transform;
        
        GameObject go = this.gameObject;
        jeffTransform = go.transform;
        jeffRigidbody = go.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float diffx = objectTransform.position.x - jeffTransform.position.x;
        float diffy = objectTransform.position.y - jeffTransform.position.y;
        
        jeffRigidbody.velocity = new Vector2(diffx, diffy).normalized * movementSpeed;
    }
}
