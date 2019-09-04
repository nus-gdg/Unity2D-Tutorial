using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeffScript : MonoBehaviour
{
    public float movementSpeed = 3.0f;
    public int maxHealth = 3;
    public int score = 100;

    Transform playerTransform;
    Transform jeffTransform;
    Rigidbody2D jeffRigidbody;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Stubby").transform;
        
        GameObject go = this.gameObject;
        jeffTransform = go.transform;
        jeffRigidbody = go.GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float diffx = playerTransform.position.x - jeffTransform.position.x;
        float diffy = playerTransform.position.y - jeffTransform.position.y;
        
        jeffRigidbody.velocity = new Vector2(diffx, diffy).normalized * movementSpeed;
    }

    void takeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GameObject.Find("ScoreManager").GetComponent<ScoreManager>().increaseScore(score);
        Destroy(this.gameObject.transform.root.gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            takeDamage(col.gameObject.GetComponent<Bullet>().damage);
            Destroy(col.gameObject.transform.root.gameObject);
        }
    }
}
