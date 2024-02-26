using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float horizontal;
    public Rigidbody2D rigidBody;

    [SerializeField]
    public float speed;

    [SerializeField]
    public float jumpingPower;

    //public Animator anim;
    public RuntimeAnimatorController MushrioJump;
    public RuntimeAnimatorController MushrioWalkR;
    public RuntimeAnimatorController MushrioIdle;
    public RuntimeAnimatorController MushrioDead;

    // public RuntimeAnimatorController MehrioIdle;
    // public RuntimeAnimatorController MehrioDead; 

    public EntityState currentState;
    public EntityIdleState idleState = new EntityIdleState();
    public EntityDeadState deadState = new EntityDeadState();
    public EntityJumpingState jumpingState = new EntityJumpingState();
    public EntityRunState runState = new EntityRunState();

    // public EntityRunState BossDeadState = new EntityDeadState();

    // public EntityRunState BossIdleState = new EntityIdleState();

    //public bool isGrounded()
    //{
    //   return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer) || Physics2D.OverlapCircle(groundCheck.position, 0.2f, brickLayer);
    //}
    // Start is called before the first frame update
    //Start in idle state
    void Start()
    {
        currentState = idleState;

        currentState.EnterState(this);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
