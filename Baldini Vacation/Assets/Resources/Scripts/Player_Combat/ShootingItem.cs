using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingItem : MonoBehaviour
{
    public float speed;
    public float damage;

    public void Update()
    {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            float[] attackDetails = new float[2];
            attackDetails[0] = damage;
            attackDetails[1] = transform.position.x;
            collision.transform.parent.SendMessage("Damage", attackDetails);
            Destroy(gameObject);
        }
        else if (collision.tag == "Player")
        {
            return;
        }
        Destroy(gameObject);
    }
}
