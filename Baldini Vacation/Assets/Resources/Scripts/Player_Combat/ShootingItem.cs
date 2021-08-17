using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingItem : MonoBehaviour
{
    public float speed;

    public void Update()
    {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            return;
        }

        if (collision.GetComponent<ShootingAction>())
        collision.GetComponent<ShootingAction>().Action();

        Destroy(gameObject);
    }
}
