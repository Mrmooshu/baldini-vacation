using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : State
{
    protected D_DeadState stateData;
    public DeadState(Entity entity, string animBoolName, D_DeadState stateData) : base(entity, animBoolName)
    {
        this.stateData = stateData;
    }

    public override void Enter()
    {
        base.Enter();
        entity.rb.AddForce(new Vector2(0, 2), ForceMode2D.Impulse);
        entity.rb.gravityScale *= .5f;

        //entity.gameObject.SetActive(false);
    }

    /*public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(stateData.deathTimer <= 0)
        {
            entity.gameObject.SetActive(false);
        }
    } */
}
