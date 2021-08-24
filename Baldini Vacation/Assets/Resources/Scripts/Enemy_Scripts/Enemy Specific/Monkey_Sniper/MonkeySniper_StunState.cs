using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper_StunState : StunState
{

    private MonkeySniper enemy;
    public MonkeySniper_StunState(MonkeySniper enemy) : base(enemy, "stun")
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
