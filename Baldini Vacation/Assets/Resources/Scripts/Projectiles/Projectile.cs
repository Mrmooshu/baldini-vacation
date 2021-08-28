using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    public AttackDetails attackDetails;
    public int damage;
    public float hitStun;
    public Vector2 knockbackForce;
    public float speed;
    public string senderTag;
    public string targetTag;
    private GameObject player;

    public virtual void Start()
    {
        player = GameObject.Find("Player");
        attackDetails.knockbackForce = knockbackForce;
        attackDetails.damageAmount = damage;
        attackDetails.hitStun = hitStun;
    }

    public virtual void Update()
    {
        transform.Translate(transform.right * transform.localScale.x * speed * Time.deltaTime);
        if (Vector2.Distance(player.transform.position, transform.position) > 50)
        {
            Destroy(gameObject);
        }
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == targetTag)
        {
            attackDetails.knockbackForce.x *= transform.localScale.x;
            collision.transform.SendMessage("Damage", attackDetails);
            Destroy(gameObject);
        }
        else if (collision.tag == senderTag)
        {
            return;
        }
        Destroy(gameObject);
    }
}
