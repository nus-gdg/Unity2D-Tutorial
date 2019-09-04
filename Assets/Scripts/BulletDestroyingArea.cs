using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyingArea : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject.transform.root.gameObject);
        }
    }
}
