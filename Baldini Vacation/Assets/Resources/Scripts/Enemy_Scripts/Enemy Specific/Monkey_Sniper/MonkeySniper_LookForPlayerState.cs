using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper_LookForPlayerState : LookForPlayerState
{

    private MonkeySniper enemy;
    public MonkeySniper_LookForPlayerState(MonkeySniper enemy, D_LookForPlayer stateData) : base(enemy, "lookForPlayer", stateData)
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
        else if(isAllTurnsTimeDone)
        {
            enemy.stateMachine.ChangeState(enemy.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
