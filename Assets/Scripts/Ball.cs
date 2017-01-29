using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Rigidbody2D rb;
	private int bounces;
	private bool moving;

	void Start () {

		rb = GetComponent<Rigidbody2D>();
		moving = false;
	}
	
	void FixedUpdate () {
	
		if (Input.GetButtonDown("Fire1") && !moving && bounces > 0)
		{
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = 10.0f;
			Vector3 ballPos = Camera.main.WorldToScreenPoint(transform.position);
			mousePos.x = mousePos.x - ballPos.x;
			mousePos.y = mousePos.y - ballPos.y;
			float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
			moving = true;
		}

		if (Input.GetKeyDown("k"))
		{
			Destroy(gameObject);
		}

		if (moving)
		{
			rb.velocity = transform.right * speed;
		}
	}

	public void bounced()
	{
		if (bounces > 0)
		{
			bounces--;
		}
	}

	public int getBounces()
	{
		return bounces;
	}

	public void setBounces(int num)
	{
		bounces = num;
	}

	public bool isMoving()
	{
		return moving;
	}

	public void stop()
	{
		moving = false;
		StartCoroutine(destroy());
	}

	IEnumerator destroy()
	{
		yield return new WaitForSecondsRealtime(5);
		Destroy(gameObject);
	}
}
