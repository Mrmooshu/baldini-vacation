using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunState : State
{
    public StunState(Entity entity, string animBoolName) : base(entity, animBoolName)
    {
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
        entity.rb.velocity = Vector2.zero;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        if (entity.CheckGround())
        {
            entity.rb.velocity = new Vector2(entity.rb.velocity.x * 0.9f, entity.rb.velocity.y);
        }
    }
}
