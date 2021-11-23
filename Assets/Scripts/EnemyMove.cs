using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    public Transform[] points;

    private UnityEngine.AI.NavMeshAgent nav;
    private int destPoint;

    void Start()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void FixedUpdate()
    {
        if (!nav.pathPending && nav.remainingDistance < 0.5f)
  	    GoToNextPoint();
    }

    void GoToNextPoint()
    {
  	    if (points.Length == 0)
  	    {
  		    return;
  	    }
  	    nav.destination = points[destPoint].position;
  	    destPoint = (destPoint + 1) % points.Length;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
