using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    [SerializeField] private Transform pointToFollow;

    [SerializeField] private bool followX = false;
    [SerializeField] private bool followY = false;
    [SerializeField] private bool followZ = false;
    
    
    
    // Update is called once per frame
    void Update()
    {
        if (followX)
        {
            transform.position = new Vector3(pointToFollow.position.x, transform.position.y, transform.position.z);
        }
        
        if (followY)
        {
            transform.position = new Vector3(transform.position.x, pointToFollow.position.y, transform.position.z);
        }
        
        if (followZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, pointToFollow.position.z);
        }
    }
}
