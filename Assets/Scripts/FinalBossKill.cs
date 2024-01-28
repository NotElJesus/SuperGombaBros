using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalBossKill : MonoBehaviour
{
    public Entity boss; // Reference to the EntityBoss script

    public void HandleFinalBoss(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            // Access the EntityBoss script to change the state to deadState
            Entity boss = GetComponent<Entity>();
            if (boss != null)
            {
                boss.currentState = boss.deadState;
            }

            // Additional logic if needed, e.g., play death animation, disable controls, etc.
            Animator animator = GetComponent<Animator>();
            if (animator != null)
            {
                animator.runtimeAnimatorController = boss.MushrioDead as RuntimeAnimatorController;
            }

            // Wait for 2.5 seconds before loading the "EndMenu" scene
            StartCoroutine(LoadGameOverSceneAfterDelay(2.5f));
        }
    }

    private IEnumerator LoadGameOverSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Load the game over scene
        SceneManager.LoadScene("EndMenu");
    }
}

