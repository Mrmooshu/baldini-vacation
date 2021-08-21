using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_DeadState : DeadState
{
    private Crab enemy;
    public Crab_DeadState(Crab enemy, D_DeadState stateData) : base(enemy, "dead", stateData)
    {
        this.enemy = enemy;
    }
}
