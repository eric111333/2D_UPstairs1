using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float yPosition = 0;
    private float speed = 1.5f;
    private Vector3 posB;

    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(posB.y==yPosition)
        yPosition += 2.5f;
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        yPosition+=0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Track();
    }
    public void Track()
    {
        Vector3 posA = transform.position;
        
        posB = new Vector3(0, yPosition, -10);

        posA = Vector3.Lerp(posA, posB, speed * Time.deltaTime);

        transform.position = posA;
    }
}
