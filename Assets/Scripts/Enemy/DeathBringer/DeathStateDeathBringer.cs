using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathStateDeathBringer : EnemyState
{
    public static System.Action clearHealthBar;
    public override void AnimationFinishTrigger()
    {
        base.AnimationFinishTrigger();
    }

    public override void Enter()
    {
        base.Enter();
        blackboard.animator.Play("Death");
    }

    public override void Exit()
    {
        base.Exit();
       
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(isAnimationFinished)
        {
            clearHealthBar?.Invoke();
        }
    }
}