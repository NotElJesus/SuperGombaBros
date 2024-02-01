using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float horizontal;
    public Rigidbody2D rigidBody;

    [SerializeField]
    public float speed;

    [SerializeField]
    public float jumpingPower;

    public EntityState currentState;
    public EntityIdleState idleState = new EntityIdleState();
    public EntityRunState runState = new EntityRunState();
    public EntityJumpingState jumpingState = new EntityJumpingState();
    public EntityDeadState deadState = new EntityDeadState();

    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
    }


}
