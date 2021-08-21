using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper_PlayerDetectedState : PlayerDetectedState
{

    private MonkeySniper enemy;
    public MonkeySniper_PlayerDetectedState(MonkeySniper enemy, D_PlayerDetected stateData) : base(enemy, "playerDetected", stateData)
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

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(performCloseRangeAction)
        {
            if(Time.time >= enemy.dodgeState.startTime + enemy.dodgeStateData.dodgeCooldown)
            {
                enemy.stateMachine.ChangeState(enemy.dodgeState);
            }
            else
            {
                enemy.stateMachine.ChangeState(enemy.meleeAttackState);
            }
        }
        else if(performLongRangeAction)
        {
            enemy.stateMachine.ChangeState(enemy.rangedAttackState);
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
