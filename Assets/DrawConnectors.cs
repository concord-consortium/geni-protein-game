using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DrawConnectors : MonoBehaviour {

  	public LineRenderer lineRenderer;
	public Transform[] connectorJoints;
	private List<Vector3> connectorPositions;

	// Use this for initialization
	void Start () {
		lineRenderer = this.gameObject.GetComponent<LineRenderer> ();
		connectorPositions = new List<Vector3>();
		for (var i = 0; i < connectorJoints.Length; i++)
		{
			connectorPositions.Add(connectorJoints[i].position);
			var sprite = connectorJoints [i].gameObject.GetComponent<SpriteRenderer> ();
			if (sprite != null) {
				Debug.Log ("disabling sprite");
				sprite.enabled = false;
			}
		}
	}

	// Update is called once per frame
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
