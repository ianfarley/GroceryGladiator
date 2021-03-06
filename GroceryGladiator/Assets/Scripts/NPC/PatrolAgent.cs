using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolAgent : MonoBehaviour
{
    [SerializeField]
    private Transform[] points;

    [SerializeField]
    private float minRemainingDistance = 0.5f;

    private int destinationPoint = 0;

    private NavMeshAgent agent;

    public Animator jjAnim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        GoToNextPoint();
        jjAnim = gameObject.GetComponent<Animator>();
    }

    void GoToNextPoint()
    {
        if(points.Length ==0)
        {
            Debug.LogError("You Must Setup at Least 1 Destination Point");
            enabled = false;
            return;
        }
        agent.destination = points[destinationPoint].position;

        destinationPoint = (destinationPoint + 1) % points.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(!agent.pathPending && agent.remainingDistance < minRemainingDistance)
        {
            GoToNextPoint();
        }
    }
}
