using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class EntityIdleState : EntityState
{

    public override void EnterState(Entity entity)
    {
        Debug.Log("Enter Idle State");
        if (entity.horizontal != 0)
        {
            entity.currentState = entity.runState;
            entity.currentState.EnterState(entity);
        }
    }

    public override void UpdateState(Entity entity)
    {
        entity.transform.localScale += new Vector3(0.01f, 0, 0);
    }

    public override void FixedUpdateState(Entity entity)
    {
        entity.rigidBody.velocity = new Vector2(entity.horizontal * entity.speed, entity.rigidBody.velocity.y);
    }

    public override void OnCollisionEnter(Entity entity)
    {

    }

}
