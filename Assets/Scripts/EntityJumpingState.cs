using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.TextCore.Text;

public class EntityJumpingState : EntityState
{

    public override void EnterState(Entity entity)
    {
        Debug.Log("Enter Jump State");
        //Jump
        entity.rigidBody.velocity = new Vector2(entity.rigidBody.velocity.x, entity.jumpingPower);

        Debug.Log("Trying Animation Play");
        Animator animator = entity.GetComponent<Animator>();
        animator.runtimeAnimatorController = entity.MushrioJump as RuntimeAnimatorController;
         
    }
    public override void UpdateState(Entity entity)
    {
        
    }

    public override void FixedUpdateState(Entity entity)
    {
        entity.rigidBody.velocity = new Vector2(entity.horizontal * entity.speed, entity.rigidBody.velocity.y);
    }


    public override void OnCollisionEnter(Entity entity)
    {
        Debug.Log("Leaving Jump State");
        entity.currentState = entity.idleState;
        entity.currentState.EnterState(entity);

    }

}