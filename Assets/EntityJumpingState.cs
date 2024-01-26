using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityJumpingState : EntityState
{
    
    public override void EnterState(Entity entity)
    {
        entity.rigidBody.velocity = new Vector2(entity.rigidBody.velocity.x, 19);
    }

    public override void UpdateState(Entity entity)
    {
        
    }

    public override void FixedUpdateState(Entity entity)
    {
        entity.rigidBody.velocity = new Vector2(entity.horizontal * 8, entity.rigidBody.velocity.y - 1);
    }


    public override void OnCollisionEnter(Entity entity)
    {
        entity.currentState = entity.idleState;
    }

}
