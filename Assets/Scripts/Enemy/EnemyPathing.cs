using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    public GameObject nextNode;
    public GameObject midNode;
    public GameObject castleNode;
    public Rigidbody2D rigidBody;
    public float minDistToNode;
    public float moveSpeed;

    private Vector2 dirToNextNode;
    private float sqrDistToNextNode;

    public void Update()
    {
        dirToNextNode = nextNode.transform.position - this.transform.position;
        dirToNextNode = dirToNextNode.normalized;

        sqrDistToNextNode = GetSqrDistance();
        if (sqrDistToNextNode <= minDistToNode * minDistToNode 
            && nextNode != castleNode) 
        {
            nextNode = castleNode;
        }

        rigidBody.MovePosition((Vector2)rigidBody.position + dirToNextNode * moveSpeed * Time.fixedDeltaTime);
        Debug.DrawRay(this.transform.position, dirToNextNode);
    }

    public float GetSqrDistance()
    {

        float xdist = nextNode.transform.position.x- this.transform.position.x;
        float ydist = nextNode.transform.position.y - this.transform.position.y;


        return xdist * xdist + ydist * ydist;
    }

}
