using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

	//public Transform goal1;
	public Transform[] points;
	public GameObject[] rooms;
	private int destPoint = 0;
	private NavMeshAgent agent;


	void Start () {
	
		agent = GetComponent<NavMeshAgent> ();

		GotoNextPoint();

	}
	
	void GotoNextPoint(){

		if (points.Length == 0)
			return;

		agent.destination = points[destPoint].position;

		destPoint = (destPoint + 1) % points.Length;
	
	}

	IEnumerator Wait(){
			
			yield return new WaitForSeconds (2);

	}
	

	void Update(){

		if (agent.remainingDistance < 0.5f) 
//			StartCoroutine ("Wait");
//			agent.Resume ();
			GotoNextPoint();


	}

}
