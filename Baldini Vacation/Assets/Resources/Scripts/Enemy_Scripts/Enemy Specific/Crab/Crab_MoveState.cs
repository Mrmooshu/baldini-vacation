using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_MoveState : MoveState
{
    private Crab enemy;
    public Crab_MoveState(Crab enemy, D_MoveState stateData) : base(enemy, "move", stateData)
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

        else if(isDetectingWall || !isDetectingLedge)
        {
            enemy.idleState.SetFlipAfterIdle(true);
            enemy.stateMachine.ChangeState(enemy.idleState);
        }
    }
}
