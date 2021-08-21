using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper_MeleeAttackState : MeleeAttackState
{
    private MonkeySniper enemy;
    public MonkeySniper_MeleeAttackState(MonkeySniper enemy, Transform attackPosition, D_MeleeAttack stateData) : base(enemy, "meleeAttack1", attackPosition, stateData)
    {
        this.enemy = enemy;
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

        if(isAnimationFinished)
        {
            if(isPlayerInMinAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.playerDetectedState);
            }
            else if(!isPlayerInMinAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
            }
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

    public override void TriggerAttack()
    {
        base.TriggerAttack();
    }
}
