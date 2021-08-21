using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttackState : AttackState
{
    public GameObject shootingItem;
    public Transform shootingPoint;

    public RangedAttackState(Entity entity, string animBoolName, Transform attackPosition, D_RangedAttackState stateData) : base(entity, animBoolName, attackPosition)
    {
        shootingItem = stateData.projectile;
        shootingPoint = attackPosition;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void FinishAttack()
    {
        base.FinishAttack();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void TriggerAttack()
    {
        base.TriggerAttack();

        GameObject bullet = GameObject.Instantiate(shootingItem, shootingPoint);
        bullet.transform.parent = null;
    }
}
