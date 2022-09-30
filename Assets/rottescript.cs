using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rottescript : MonoBehaviour
{

    [SerializeField] Transform[] Positions;
    [SerializeField] float ObjectSpeed;

    int NextPosIndex;
    Transform NextPos;

    void Start()
    {
        NextPos = Positions[0];
    }

    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        Vector3 localScale = transform.localScale;

        if (transform.position == NextPos.position)
        {
            localScale.x *= -1;
            transform.localScale = localScale;
            NextPosIndex++;
            if (NextPosIndex >= Positions.Length)
            {
                
                NextPosIndex = 0;
            }
            NextPos = Positions[NextPosIndex];

        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);
        }
        

    }



}

