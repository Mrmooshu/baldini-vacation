using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_ChargeState : ChargeState
{
    private Crab enemy;
    public Crab_ChargeState(Crab enemy, D_ChargeState stateData) : base(enemy, "charge", stateData)
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

        else if (!isDetectingLedge || isDetectingWall)
        {
            enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
        }

        else if (isChargeTimeOver)
        {

            if(isPlayerInMinAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.playerDetectedState);
            }
            else
            {
                enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
            }
        }
    }
}
