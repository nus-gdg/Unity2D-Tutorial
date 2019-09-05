using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int maxHealth = 3;
    public int score = 100;

    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
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
