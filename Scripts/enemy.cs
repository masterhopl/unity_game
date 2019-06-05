using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform player;
    public NavMeshAgent agent;
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
    void OnCollisionEnter(Collision collision)
    { 
		if(collision.gameObject.CompareTag("Bullet"))
        {
        	Destroy(gameObject);
        }
    }
}
