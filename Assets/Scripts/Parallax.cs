using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    [SerializeField] float checker;
    [SerializeField]private GameObject cam;

    [SerializeField]private float parallaxEffect;
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1 - parallaxEffect));

        float distance = (cam.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);
        if(checker != 1)
        {
            if(temp > startpos + length) startpos += 2*length;
            else if(temp < startpos - length) startpos -= 2*length;
        }

    }
}
