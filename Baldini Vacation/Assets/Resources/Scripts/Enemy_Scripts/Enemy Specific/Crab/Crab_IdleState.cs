using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Crab_IdleState : IdleState
{
    private Crab enemy;
    public Crab_IdleState(Crab enemy, D_IdleState stateData) : base(enemy, "idle", stateData)
    {
        this.enemy = enemy;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(isPlayerInMinAgroRange)
        {
            enemy.stateMachine.ChangeState(enemy.playerDetectedState);
        }

        else if (isIdleTimeOver)
        {
            enemy.stateMachine.ChangeState(enemy.moveState);
        }
    }
}

