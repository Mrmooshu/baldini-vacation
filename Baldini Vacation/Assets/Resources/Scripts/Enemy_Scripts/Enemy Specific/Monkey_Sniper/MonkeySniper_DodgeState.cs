using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper_DodgeState : DodgeState
{

    private MonkeySniper enemy;
    public MonkeySniper_DodgeState(MonkeySniper enemy, D_DodgeState stateData) : base(enemy, "dodge", stateData)
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

        if(isDodgeOver)
        {
            if(isPlayerInMaxAgroRange && performCloseRangeAction)
            {
                enemy.stateMachine.ChangeState(enemy.meleeAttackState);
            }
            else if(isPlayerInMaxAgroRange && !performCloseRangeAction)
            {
                enemy.stateMachine.ChangeState(enemy.rangedAttackState);
            }
            else if(!isPlayerInMaxAgroRange)
            {
                enemy.stateMachine.ChangeState(enemy.lookForPlayerState);
            }

            //TODO:
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
