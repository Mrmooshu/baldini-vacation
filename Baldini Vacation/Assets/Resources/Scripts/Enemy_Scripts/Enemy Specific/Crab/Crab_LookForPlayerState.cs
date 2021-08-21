using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_LookForPlayerState : LookForPlayerState
{
    private Crab enemy;
    public Crab_LookForPlayerState(Crab enemy, D_LookForPlayer stateData) : base(enemy, "lookForPlayer", stateData)
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
        else if(isAllTurnsTimeDone)
        {
            enemy.stateMachine.ChangeState(enemy.moveState);
        }
    }
}
