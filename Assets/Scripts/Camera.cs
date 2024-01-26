using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 0, 0) + new Vector3(0, 0, -10);
    }
}
