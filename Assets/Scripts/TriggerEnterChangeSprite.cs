using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterChangeSprite : MonoBehaviour
{
    public Sprite redScreen;
    public Sprite greenScreen;

    SpriteRenderer sr;

    void Start()
    {
        this.sr = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        sr.sprite = greenScreen;
    }
    
    void OnTriggerExit2D (Collider2D col)
    {
        sr.sprite = redScreen;
    }
}
