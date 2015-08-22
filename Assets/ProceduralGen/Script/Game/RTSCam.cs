using UnityEngine;

public class RTSCam : MonoBehaviour {

	[SerializeField]
	private float moveSpeed = 5f;
	Vector3 movement;
	Vector3 starLook; 

	/*void OnDrawGizmos(){
		Gizmos.color = Color.green;

		
		Quaternion rot = transform.rotation;
		Gizmos.DrawLine(transform.position,5*(transform.position+(rot*Vector3.forward)));
	}*/

	void Update () {
		MoveLeftRight ();
		MoveUpDown ();
		Look ();
	}

	void MoveUpDown ()
	{
		movement = Vector3.zero;
		if(Input.GetKey(KeyCode.R)){
			movement += new Vector3(0,moveSpeed,0);
		}
		if(Input.GetKey(KeyCode.F)){
			movement += new Vector3(0,-moveSpeed,0);
		}
		transform.position += movement;
	}

	void MoveLeftRight(){
		movement = Vector3.zero;

		// get normalized left/right movement vectors
		Quaternion rot = transform.rotation;
		rot.x = 0;
		rot.z = 0;
		if(Input.GetKey(KeyCode.W)){
			movement += rot * new Vector3(0,0,10);
		}
		if(Input.GetKey(KeyCode.S)){
			movement += rot * new Vector3(0,0,-10);
		}
		if(Input.GetKey(KeyCode.D)){
			movement += rot * new Vector3(10,0,0);
		}
		if(Input.GetKey(KeyCode.A)){
			movement += rot * new Vector3(-10,0,0);
		}
		movement.Normalize ();

		// add normalize movement vector multiplied by speed to position
		transform.position += (movement*moveSpeed);
	}

	void Look(){
		bool look = Input.GetMouseButton (0);

		if (Input.GetMouseButtonDown (0)) {
			starLook = Input.mousePosition;
		}
		if (look) {
			Vector3 delta = starLook-Input.mousePosition;
			float Dx = delta.x;
			float Dy = delta.y;
			Vector3 deltaY = new Vector3(0,-Dx,0);
			Vector3 deltaX = new Vector3(Dy,0,0);

			transform.Rotate(deltaY,Space.World);
			transform.Rotate(deltaX,Space.Self);
			starLook = Input.mousePosition;
		}
	}
}
