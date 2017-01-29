using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	[SerializeField]
	private GameObject ball;

	[SerializeField]
	private GameObject ballPrefab;

	[SerializeField]
	private int bounces;

	void Start () {
	
	}
	
	void Update () {
	
		if (!ball)
		{
			ball = Instantiate(ballPrefab, transform.position, transform.rotation) as GameObject;
			ball.GetComponent<Ball>().setBounces(bounces);
		}
	}
}
