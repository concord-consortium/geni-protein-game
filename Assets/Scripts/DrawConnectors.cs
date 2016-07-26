using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawConnectors : MonoBehaviour {

	public LineRenderer lineRenderer;
	public Transform[] connectorJoints;
	private List<Vector3> connectorPositions;

	void Start () {
		lineRenderer = this.gameObject.GetComponent<LineRenderer> ();
		connectorPositions = new List<Vector3>();
		for (var i = 0; i < connectorJoints.Length; i++)
		{
			connectorPositions.Add(connectorJoints[i].position);
			var sprite = connectorJoints [i].gameObject.GetComponent<SpriteRenderer> ();
			if (sprite != null) {
				// hide the ugly sprites so we can show smoother lines between joints
				sprite.enabled = false;
			}
		}
	}
		
	void Update () {
		for (var i = 0; i < connectorJoints.Length; i++)
		{
			connectorPositions[i] = connectorJoints[i].position;
		}
	}

	void FixedUpdate () {
		lineRenderer.SetPositions (connectorPositions.ToArray());
	}
}
