using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper_IdleState : IdleState
{
    private MonkeySniper enemy;
    public MonkeySniper_IdleState(MonkeySniper enemy, D_IdleState stateData) : base(enemy, "idle", stateData)
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

        if(isPlayerInMinAgroRange)
        {
            enemy.stateMachine.ChangeState(enemy.playerDetectedState);
        }

        else if(isIdleTimeOver)
        {
            enemy.stateMachine.ChangeState(enemy.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
