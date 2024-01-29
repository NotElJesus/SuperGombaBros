using System.Xml;
using UnityEngine;

public abstract class EntityState{

    public abstract void EnterState(Entity entity);

    public abstract void UpdateState(Entity entity);

    public abstract void FixedUpdateState(Entity entity);

    public abstract void OnCollisionEnter(Entity entity);


}
