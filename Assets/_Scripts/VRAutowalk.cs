using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class VRAutowalk : MonoBehaviour {

	public float speed;
	private CharacterController controller;
//	private GvrViewer gvrViewer;
	private Transform vrHead;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
//		gvrViewer = transform.GetChild (0).GetComponent<GvrViewer> ();
		vrHead = Camera.main.transform;	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

//			Vector3 forward = vrHead.TransformDirection (Vector3.forward);
//			controller.SimpleMove (forward * speed);

		Vector3 moveDirection = vrHead.forward;
		moveDirection *= speed * Time.deltaTime;
		controller.Move (moveDirection);

	}
}
