using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	public float minSpeed = 8f;
	public float maxSpeed = 12f;
	public float distanceTraveled = 0;

	float speed = 1f;

	void Start ()
	{
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
		distanceTraveled += 1;
		if (distanceTraveled >= 150)
        {
			Destroy(gameObject);
        }
	}

}
