using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistanceDecision : MonoBehaviour
{
    //public variables
    public float distanceForDecision;
    public Transform target;

    //private variables
    private EnemyPatrol patrolBehaviour;
    private EnemyChase chaseBehaviour;
    
    
    
    
    //called when script is first loaded
    void Awake()
    {
        //get behaviours so we can turn them off and on
        patrolBehaviour = GetComponent<EnemyPatrol>();
        chaseBehaviour = GetComponent<EnemyChase>();

        //turn off chase behaviour to start with
        chaseBehaviour.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = ((Vector2)target.position - (Vector2)transform.position).magnitude;

        //if closer to target than minimum distance
        if (distance <= distanceForDecision)
        {
            //disable patrol and enable chasing
            patrolBehaviour.enabled = false;
            chaseBehaviour.enabled = true;
        }
        else
        {
            //enable patrol, disable chasing
            patrolBehaviour.enabled = true;
            chaseBehaviour.enabled = false;
        }
    }
}
