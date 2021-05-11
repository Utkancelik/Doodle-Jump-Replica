using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    
    
    void LateUpdate()
    {
        if (playerTransform.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, playerTransform.position.y, transform.position.z);
            transform.position = newPos;
        }
        

    }
}
