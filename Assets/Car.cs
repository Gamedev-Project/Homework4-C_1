using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;
	float speed = 3f;
	[Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
	void Start ()
	{
		speed = 8f;
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Boarder" && this.tag=="Car" ) {
            //Debug.Log("i am "+this.tag);
            //Debug.Log("i am "+this.tag +"Start CollisionLogger on "+other.tag);
            Destroy(this.gameObject);
		}
	}

}
