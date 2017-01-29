using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
	
	void Start () {
	
	}
	
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			Destroy(col.gameObject);
		}
	}
}
