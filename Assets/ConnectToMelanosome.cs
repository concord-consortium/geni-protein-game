using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConnectToMelanosome : MonoBehaviour {

	public Transform connectionPoint;
	private List<AttachPoint> attachmentPoints;
	public float attachDistance = 0.5f;
	public float breakForce = 20f;
	public HingeJoint2D hinge;

	void Start () {
		attachmentPoints = new List<AttachPoint> ();
		var attachmentPointList = GameObject.FindGameObjectsWithTag ("AttachmentPoint");
		if (attachmentPointList != null && attachmentPointList.Length > 0) {
			foreach (var point in attachmentPointList) {
				attachmentPoints.Add (new AttachPoint {Position = point.transform.position, HasBeenConnected = false});
			}
		}
			
	}

	void FixedUpdate () {
		if (hinge == null) {
			foreach (var p in attachmentPoints) {
				if (!p.HasBeenConnected) {
					if (Vector3.Distance (connectionPoint.position, p.Position) < attachDistance) {
						Debug.Log ("I am close to: " + p);
						hinge = this.gameObject.AddComponent<HingeJoint2D> ();
						hinge.anchor = connectionPoint.position;
						hinge.connectedAnchor = p.Position;
						hinge.breakForce = this.breakForce;
						p.HasBeenConnected = true;
						break;
					}
				}
			}
		}
	}
}

public class AttachPoint{
	public Vector3 Position;
	public bool HasBeenConnected;
}