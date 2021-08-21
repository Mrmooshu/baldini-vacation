using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_MeleeAttackState : MeleeAttackState
{
    private Crab enemy;
    public Crab_MeleeAttackState(Crab enemy, Transform attackPosition, D_MeleeAttack stateData) : base(enemy, "meleeAttack", attackPosition, stateData)
    {
        this.enemy = enemy;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(isAnimationFinished)
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
