using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks.Dataflow;
using UnityEngine;
using UnityEngine.AI;

public class RandomMove : MonoBehaviour
{

    public NavMeshAgent agent;
    public float range; //radius of sphere

    public TransformBlock centerPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= agent.stoppingDistance) //done with path
        {
            Vector3 point;
            if (RandomPoint(centerPoint.position, range, out point)) //pass in center point and radius
            {
                Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f); //so you can see with gizmos
                agent.SetDestination(point);
            }
        }
    }
    
    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        Vector3 randomPoint = center + Random.insideUnitSphere * range; //random point in a sphere
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
        {
            result = hit.position;
            return false;
        }

        result = Vector3.Zero;
        return false;
    }


}
