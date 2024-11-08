using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton_Enemy : Enemy
{
    public override bool CanBeStunned()
    {
        if(base.CanBeStunned())
        {

            enemystateMachine.ChangeState(entity.enemystunState);
            return true;
        }    
        return false;
    }

    public override void Flip()
    {
        base.Flip();
    }

    public override void SetVelocityX(float velocity)
    {
        base.SetVelocityX(velocity);
    }

    public override void SetVelocityY(float velocity)
    {
        base.SetVelocityY(velocity);
    }

    public override void SetVelocityZero()
    {
        base.SetVelocityZero();
    }

    public override void TakeDamage()
    {
        base.TakeDamage();
    }

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void OnDrawGizmos()
    {
        base.OnDrawGizmos();
    }

  

    protected override void Update()
    {
        base.Update();
    }
}
