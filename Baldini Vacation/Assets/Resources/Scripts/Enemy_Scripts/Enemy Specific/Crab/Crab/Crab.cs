using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : Entity
{
    public Crab_IdleState idleState { get; private set; }
    public Crab_MoveState moveState { get; private set; }
    public Crab_ChargeState chargeState { get; private set; }
    public Crab_PlayerDetectedState playerDetectedState { get; private set; }
    public Crab_LookForPlayerState lookForPlayerState { get; private set; }
    public Crab_MeleeAttackState meleeAttackState { get; private set; }
    public Crab_StunState stunState { get; private set; }
    public Crab_DeadState deadState { get; private set; }

    [SerializeField]
    private D_IdleState idleStateData;
    [SerializeField]
    private D_MoveState moveStateData;
    [SerializeField]
    private D_PlayerDetected playerDetectedData;
    [SerializeField]
    private D_ChargeState chargeStateData;
    [SerializeField]
    private D_LookForPlayer lookForPlayerStateData;
    [SerializeField]
    private D_MeleeAttack meleeAttackStateData;
    [SerializeField]
    private D_StunState stunStateData;
    [SerializeField]
    private D_DeadState deadStateData;
    
    [SerializeField]
    private Transform meleeAttackPosition;

    public override void Start()
    {
        base.Start();

        moveState = new Crab_MoveState(this, stateMachine, "move", moveStateData, this);
        idleState = new Crab_IdleState(this, stateMachine, "idle", idleStateData, this);
        playerDetectedState = new Crab_PlayerDetectedState(this, stateMachine, "playerDetected", playerDetectedData, this);
        chargeState = new Crab_ChargeState(this, stateMachine, "charge", chargeStateData, this);
        lookForPlayerState = new Crab_LookForPlayerState(this, stateMachine, "lookForPlayer", lookForPlayerStateData, this);
        meleeAttackState = new Crab_MeleeAttackState(this, stateMachine, "meleeAttack", meleeAttackPosition, meleeAttackStateData, this);
        stunState = new Crab_StunState(this, stateMachine, "stun", stunStateData, this);
        deadState = new Crab_DeadState(this, stateMachine, "dead", deadStateData, this);

        stateMachine.Initialize(moveState);
    }

    public override void OnDrawGizmos()
    {
        base.OnDrawGizmos();

        Gizmos.DrawWireSphere(meleeAttackPosition.position, meleeAttackStateData.attackRadius);
    }

    public override void Damage(AttackDetails attackDetails)
    {
        base.Damage(attackDetails);

        if(isDead)
        {
            stateMachine.ChangeState(deadState);
        }

        else if(isStunned && stateMachine.currentState != stunState)
        {
            stateMachine.ChangeState(stunState);
        }
    }
}
