using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml;
using UnityEngine;

public class EntityDeadState : EntityState
{

    public override void EnterState(Entity entity)
    {
        Animator animator = entity.GetComponent<Animator>();
        animator.runtimeAnimatorController = entity.MushrioDead as RuntimeAnimatorController;
    }

    public override void UpdateState(Entity entity)
    {
    }

    public override void FixedUpdateState(Entity entity)
    {

    }

    public override void OnCollisionEnter(Entity entity)
    {

    }


}
