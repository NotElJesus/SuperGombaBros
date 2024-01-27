using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Transform player;

    // Have the camera follow the player but also respect the borders of the game.
    void Update()
    {
        if (player.transform.position.x > 0)
        {
            transform.position = new Vector3(player.transform.position.x, 0, 0) + new Vector3(0, 0, -10);
        }
    }
}
