using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour {

	public NavMeshAgent navMeshAgent;
	public Transform exitTarget;
	// Use this for initialization
	void Start () {
		
		navMeshAgent.destination = exitTarget.position;


	}


}