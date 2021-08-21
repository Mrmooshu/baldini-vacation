using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_StunState : StunState
{
    private Crab enemy;
    public Crab_StunState(Crab enemy, D_StunState stateData) : base(enemy, "stun", stateData)
    {
        this.enemy = enemy;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(isStunTimeOver)
        {
            if(performCloseRangeAction)
            {
                enemy.stateMachine.ChangeState(enemy.meleeAttackState);
            }
            else if(isPlayerInMinAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.chargeState);
            }
            else
            {
                enemy.lookForPlayerState.SetTurnImmediately(true);
                enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
            }
        }
    }
}
