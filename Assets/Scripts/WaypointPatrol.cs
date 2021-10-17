using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMashAgent;
    public Transform[] wayPoints;
    int m_CurrentWaypointIndex;
    void Start()
    {
        navMashAgent.SetDestination(wayPoints[0].position);
    }


    void Update()
    {
        if(navMashAgent.remainingDistance < navMashAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % wayPoints.Length;
            navMashAgent.SetDestination(wayPoints[m_CurrentWaypointIndex].position);
        }
    }
}
