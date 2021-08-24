using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine
{
    public State currentState { get; private set; }
    private State previousState, defaultState;

    public void Initialize(State startingState)
    {
        defaultState = startingState;
        currentState = startingState;
        previousState = startingState;
        currentState.Enter();
    }

    public void ChangeState(State newState)
    {
        currentState.Exit();
        previousState = currentState;
        currentState = newState;
        currentState.Enter();
    }

    public void returnToPreviousState()
    {
        ChangeState(previousState);
    }

    public void returnToDefaultState()
    {
        ChangeState(defaultState);
    }
}
