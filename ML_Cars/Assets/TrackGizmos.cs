using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackGizmos : MonoBehaviour
{
 void OnDrawGizmosSelected()
    {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.green;
            Gizmos.DrawLine(
                transform.position + Vector3.up * 2, 
                transform.position + Vector3.up * 2 + transform.forward * 3
                );
        
    }
}
