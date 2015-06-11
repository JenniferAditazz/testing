using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour {

	public NavMeshAgent agent;
	public MeshCollider spot;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter (){

	}
	// Update is called once per frame
	void Update () {
		OnCollisionEnter ();
	}
}
