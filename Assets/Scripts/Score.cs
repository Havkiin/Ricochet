using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	private Text ricochets;
	private GameObject ball;

	void Start () {

		ricochets = GetComponent<Text>();
	}
	
	void Update () {

		ball = GameObject.FindGameObjectWithTag("Player");

		if (ball)
		{
			ricochets.text = "Ricochets: " + ball.GetComponent<Ball>().getBounces();
		}
		else
		{
			ricochets.text = "Ricochets: 0";
		}
	}
}
