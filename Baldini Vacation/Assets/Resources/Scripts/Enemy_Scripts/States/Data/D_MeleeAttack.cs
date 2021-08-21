using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newMeleeAttackStateData", menuName = "Data/State Data/Melee Attack State")]
public class D_MeleeAttack : ScriptableObject
{
    public float attackRadius = 0.5f;
    public int attackDamage = 10;
    public Vector2 knockbackForce = new Vector2(5, 5);
    public float hitStun = 1f;

    public LayerMask whatIsPlayer;
}
