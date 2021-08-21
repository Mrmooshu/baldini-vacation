using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Projectile : Projectile
{
    public override void Start()
    {
        base.Start();

        senderTag = "Player";
        targetTag = "Enemy";
    }
}
