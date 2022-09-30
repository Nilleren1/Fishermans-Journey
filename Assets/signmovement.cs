using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signmovement : MonoBehaviour
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
        if (transform.position == NextPos.position)
        {
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
