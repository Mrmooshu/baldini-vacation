using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper_DeadState : DeadState
{
    private MonkeySniper enemy;
    public MonkeySniper_DeadState(MonkeySniper enemy, D_DeadState stateData) : base(enemy, "dead", stateData)
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
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
