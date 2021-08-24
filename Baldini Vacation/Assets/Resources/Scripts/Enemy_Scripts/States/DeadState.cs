using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : State
{
    protected D_DeadState stateData;
    private GameObject player;

    public DeadState(Entity entity, string animBoolName, D_DeadState stateData) : base(entity, animBoolName)
    {
        this.stateData = stateData;
    }

    public override void Enter()
    {
        base.Enter();

        player = GameObject.Find("Player");
        entity.rb.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
        entity.rb.gravityScale *= .5f;

        // disable colliders if they exist
        if (entity.GetComponent<CircleCollider2D>() != null)
        {
            entity.GetComponent<CircleCollider2D>().enabled = false;
        }
        if (entity.GetComponent<BoxCollider2D>() != null)
        {
            entity.GetComponent<BoxCollider2D>().enabled = false;
        }

    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (Vector2.Distance(player.transform.position, entity.transform.position) > 50)
        {
            MonoBehaviour.Destroy(entity.gameObject);
        }
    }
}
