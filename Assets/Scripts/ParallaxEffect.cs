using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        
        if(position.x < -20f)
            position.x += 40f;
        position.x -= speed * Time.deltaTime;
        transform.position = position;
    }
}
