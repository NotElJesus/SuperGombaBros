using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.TextCore.Text;

public class EntityJumpingState : EntityState
{
    //private Animation anim;

    public override void EnterState(Entity entity)
    {
        Debug.Log("Enter Jump State");
        entity.rigidBody.velocity = new Vector2(entity.rigidBody.velocity.x, entity.jumpingPower);
        //anim = entity.GetComponent<Animation>();
        Debug.Log("Trying Animation Play");
        //anim.Play("MushrioJump_Clip");

        Animator animator = entity.GetComponent<Animator>();
        animator.runtimeAnimatorController = Resources.Load("MushrioJump.controller") as RuntimeAnimatorController;
         
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
