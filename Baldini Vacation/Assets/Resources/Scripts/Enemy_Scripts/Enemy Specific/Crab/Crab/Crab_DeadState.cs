using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_DeadState : DeadState
{
    private Crab enemy;
    public Crab_DeadState(Entity etity, FiniteStateMachine stateMachine, string animBoolName, D_DeadState stateData, Crab enemy) : base(etity, stateMachine, animBoolName, stateData)
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
