using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySniper : Entity
{
    public MonkeySniper_MoveState moveState { get; private set; }
    public MonkeySniper_IdleState idleState { get; private set; }
    public MonkeySniper_PlayerDetectedState playerDetectedState { get; private set; }
    public MonkeySniper_MeleeAttackState meleeAttackState { get; private set; }
    public MonkeySniper_LookForPlayerState lookForPlayerState { get; private set; }
    public MonkeySniper_StunState stunState { get; private set; }
    public MonkeySniper_DodgeState dodgeState { get; private set; }
    public MonkeySniper_DeadState deadState { get; private set; }
    public MonkeySniper_RangedAttackState rangedAttackState { get; private set; }

    [SerializeField]
    private D_MoveState moveStateData;
    [SerializeField]
    private D_IdleState idleStateData;
    [SerializeField]
    private D_PlayerDetected playerDetectedStateData;
    [SerializeField]
    private D_MeleeAttack meleeAttackStateData;
    [SerializeField]
    private D_LookForPlayer lookForPlayerStateData;
    [SerializeField]
    private D_StunState stunStateData;
    [SerializeField]
    private D_DeadState deadStateData;
    [SerializeField]
    public D_DodgeState dodgeStateData;
    [SerializeField]
    private D_RangedAttackState rangedAttackStateData;
    [SerializeField]
    private Transform meleeAttackPosition;
    [SerializeField]
    private Transform rangedAttackPosition;

    public override void Start()
    {
        base.Start();

        moveState = new MonkeySniper_MoveState(this, moveStateData);
        idleState = new MonkeySniper_IdleState(this, idleStateData);
        playerDetectedState = new MonkeySniper_PlayerDetectedState(this, playerDetectedStateData);
        meleeAttackState = new MonkeySniper_MeleeAttackState(this, meleeAttackPosition, meleeAttackStateData);
        lookForPlayerState = new MonkeySniper_LookForPlayerState(this, lookForPlayerStateData);
        stunState = new MonkeySniper_StunState(this);
        deadState = new MonkeySniper_DeadState(this, deadStateData);
        dodgeState = new MonkeySniper_DodgeState(this, dodgeStateData);
        rangedAttackState = new MonkeySniper_RangedAttackState(this, rangedAttackPosition, rangedAttackStateData);

        stateMachine.Initialize(moveState);
    }

    public override void Damage(AttackDetails attackDetails)
    {
        base.Damage(attackDetails);

        if (isDead)
        {
            if (stateMachine.currentState != deadState)
            {
                stateMachine.ChangeState(deadState);
            }
        }

        else if (isStunned)
        {
            if (stateMachine.currentState != stunState)
            {
                stateMachine.ChangeState(stunState);
            }
        }
    }

    public override void OnDrawGizmos()
    {
        base.OnDrawGizmos();

        Gizmos.DrawWireSphere(meleeAttackPosition.position, meleeAttackStateData.attackRadius);
    }
}
