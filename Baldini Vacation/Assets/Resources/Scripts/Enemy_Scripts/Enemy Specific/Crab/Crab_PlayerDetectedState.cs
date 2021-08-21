using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_PlayerDetectedState : PlayerDetectedState
{

    private Crab enemy;
    public Crab_PlayerDetectedState(Crab enemy, D_PlayerDetected stateData) : base(enemy, "playerDetected", stateData)
    {
        this.enemy = enemy;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (performCloseRangeAction)
        {
            enemy.stateMachine.ChangeState(enemy.meleeAttackState);
        }

        else if(!performLongRangeAction)
        {
            enemy.stateMachine.ChangeState(enemy.chargeState);
        }
        else if(!isPlayerInMaxAgroRange)
        {
            enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
        }

    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
