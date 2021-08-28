using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{

    protected D_MoveState stateData;

    protected bool isDetectingWall;
    protected bool isDetectingLedge;
    protected bool isPlayerInMinAgroRange;
    public MoveState(Entity entity, string animBoolName, D_MoveState stateData) : base(entity, animBoolName)
    {
        this.stateData = stateData;
    }

    public override void DoChecks()
    {
        base.DoChecks();

        isDetectingLedge = entity.CheckLedge();
        isDetectingWall = entity.CheckWall();
        isPlayerInMinAgroRange = entity.CheckPlayerInMinAgroRange();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        if (entity.CheckWall())
        {
            entity.Flip();
        }
        else
        {
            entity.transform.position += new Vector3(stateData.movementSpeed * entity.facingDirection * Time.deltaTime, 0f, 0f);
        }
    }
}
