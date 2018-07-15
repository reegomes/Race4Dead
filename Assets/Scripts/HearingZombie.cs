using UnityEngine;
using UnityEngine.AI;

public class HearingZombie : MonoBehaviour {

	public float fieldOfViewAngle = 110f;
	public bool playerInSight;
	public Vector3 personalLastSighting;

	NavMeshAgent nav;
	CapsuleCollider col;
	GameObject player;
	Vector3 previousSighting;

	void Awake() {
		nav = GetComponent<NavMeshAgent>();
		col = GetComponent<CapsuleCollider>();
		player = GameObject.FindGameObjectWithTag("Player");
	}
	private void OnTriggerStay(Collider other) {
		if(other.gameObject.CompareTag("Player")){
			playerInSight = false;
			Vector3 direction = other.transform.position - transform.position;
			float angle = Vector3.Angle(direction, transform.forward);

			if(angle < fieldOfViewAngle){
				RaycastHit hit;

				if(Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius)){
					playerInSight = true;
				}
			}
		}
	}
	private void OnTriggerExit(Collider other) {
		if(other.gameObject.CompareTag("Player")){
			playerInSight = false;
		}
	}

}
