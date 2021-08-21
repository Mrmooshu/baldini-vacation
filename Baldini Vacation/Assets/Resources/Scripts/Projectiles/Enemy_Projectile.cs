using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Projectile : Projectile
{
    public override void Start()
    {
        base.Start();

        senderTag = "Enemy";
        targetTag = "Player";
    }
}
