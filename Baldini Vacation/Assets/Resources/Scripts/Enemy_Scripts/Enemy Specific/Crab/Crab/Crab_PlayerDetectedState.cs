using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_PlayerDetectedState : PlayerDetectedState
{

    private Crab enemy;
    public Crab_PlayerDetectedState(Entity etity, FiniteStateMachine stateMachine, string animBoolName, D_PlayerDetected stateData, Crab enemy) : base(etity, stateMachine, animBoolName, stateData)
    {
        this.enemy = enemy;
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

        if (performCloseRangeAction)
        {
            stateMachine.ChangeState(enemy.meleeAttackState);
        }

        else if(!performLongRangeAction)
        {
            stateMachine.ChangeState(enemy.chargeState);
        }
        else if(!isPlayerInMaxAgroRange)
        {
            stateMachine.ChangeState(enemy.lookForPlayerState);
        }

    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
