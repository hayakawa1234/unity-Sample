using System;
using System.Collections;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject explosionPrefab;

    void Update()
    {
        Debug.Log("Bullet");
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("OnTriggerEnter2D");
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();
        
        GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(effect, 1.0f);

        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}

 