using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_StunState : StunState
{
    private Crab enemy;
    public Crab_StunState(Crab enemy) : base(enemy, "stun")
    {
        this.enemy = enemy;
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }
}
