using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityRunState : EntityState
{

    public override void EnterState(Entity entity)
    {
        Debug.Log("Enter Run State");

        Debug.Log("Trying Run Animation");
        Animator animator = entity.GetComponent<Animator>();
        animator.runtimeAnimatorController = entity.MushrioWalkR as RuntimeAnimatorController;
    }

    public override void UpdateState(Entity entity)
    {
        if (entity.horizontal == 0f)
        {
            entity.currentState = entity.idleState;
            entity.currentState.EnterState(entity);
        }
    }

    public override void FixedUpdateState(Entity entity)
    {
        entity.rigidBody.velocity = new Vector2(entity.horizontal * entity.speed, entity.rigidBody.velocity.y);
    }

    public override void OnCollisionEnter(Entity entity)
    {

    }

}
