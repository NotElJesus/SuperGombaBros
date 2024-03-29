using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//ScriptFolderPlayer

public class Player : Entity
{
    private bool isFacingRight = true;
    public CoinHealthBar coinbar;
    public Health health;
    public TextMeshProUGUI helpbtn;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Health playerHealth;
    public Transform headCheck;
    public LayerMask brickLayer;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;


    // Deal with the controls as well as the jumping of the character.
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        //Horizontal Debug Log. 
        //Debug.Log($"Horizontal: {horizontal}");                           

        if (Input.GetButtonDown("Jump") && currentState != jumpingState){
            audioSource.PlayOneShot(audioClip);
            currentState = jumpingState;
            currentState.EnterState(this);
        }
        flip();
        currentState.UpdateState(this);
        ShowControls();
        ShowCoin();
        ShowHealth();
    }

    // Move the player
    private void FixedUpdate()
    {
        currentState.FixedUpdateState(this);
    }

    //TODO: Move to Entity base class and make generic with other world things. 
    // Determine whether the player is touching the ground(or a brick) or not.
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer) || Physics2D.OverlapCircle(groundCheck.position, 0.2f, brickLayer);
    }

    // Determine whether the player colliders with a brick with its head.
    private bool isCollidingWithBrick()
    {
        return Physics2D.OverlapCircle(headCheck.position, 0.2f, brickLayer);
    }

    // Flip the direction of the player depending on the which direction the player is moved.
    private void flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    // Determine whether the player has come into contact with a brick from the bottom.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick" && isCollidingWithBrick())
        {
            Destroy(collision.gameObject);
        }
        currentState.OnCollisionEnter(this);
    }
    // Help Canvas
    public void ShowCoin()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            coinbar.ShowHealth();
        }
    }
    public void ShowControls()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Help Needed");
            Debug.Log(helpbtn.text);
            helpbtn.text = "Controls: A,D or Left, Right for Moving, Space for Jump";
            StartCoroutine(ResetTextAfterDelay(2f));
        }
    }

    public void ShowHealth()
    {

        if (Input.GetKeyDown(KeyCode.H))
        {
            health.ShowHealth();
        }
    }

    IEnumerator ResetTextAfterDelay(float delay)
    {
        Debug.Log("Resetting the Text");
        yield return new WaitForSeconds(delay);
        // Reset the text value
        helpbtn.text = "";
    }
}
