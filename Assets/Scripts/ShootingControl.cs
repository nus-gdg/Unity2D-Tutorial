using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingControl : MonoBehaviour
{
    public GameObject bullet;

    public float cooldown = 0.5f;
    public ParticleSystem additionalEffect;
    private bool readyToShoot;

    private Transform playerTransform;
    private Camera sceneCamera;

    void Start()
    {
        readyToShoot = true;
        playerTransform = GetComponent<Transform>();
        sceneCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        bool leftClickDown = Input.GetMouseButton(0);

        if(leftClickDown)
        {
            TryToShoot();
        }
    }

    void TryToShoot()
    {
        if(readyToShoot)
        {
            readyToShoot = false;
            
            Vector2 mouseCoordinates = sceneCamera.ScreenPointToRay(Input.mousePosition).origin;
            Vector2 playerCoordinates = playerTransform.position;

            Bullet clone = Instantiate(bullet, playerTransform.position, Quaternion.identity).GetComponent<Bullet>();
            clone.Push(playerCoordinates, mouseCoordinates);

            StartCoroutine("CooldownRoutine");

            if(additionalEffect != null) 
            {
                additionalEffect.Play();
            }
        }
    }

    IEnumerator CooldownRoutine()
    {
        yield return new WaitForSeconds(cooldown);
        readyToShoot = true;
    }
}