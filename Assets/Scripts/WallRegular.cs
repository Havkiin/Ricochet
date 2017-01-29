using UnityEngine;
using System.Collections;

public class WallRegular : MonoBehaviour {

	void Start () {

	}
	
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		GameObject ball = col.gameObject;

		if (ball.tag == "Player" && ball.GetComponent<Ball>().isMoving())
		{
			if (ball.GetComponent<Ball>().getBounces() > 0)
			{
				ball.transform.rotation = Quaternion.Inverse(ball.transform.rotation);
				ball.transform.Rotate(new Vector3(0, 0, 180.0f - 2 * (transform.eulerAngles.z)), Space.Self);
				ball.GetComponent<Ball>().bounced();
			}
			else
			{
				ball.GetComponent<Ball>().stop();
			}
		}
	}
}
