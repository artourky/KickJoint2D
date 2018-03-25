using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Force : MonoBehaviour {

	public float x = 50f;
	public float y = 10f;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.X))
		{
			rb.AddForce(new Vector2(x, y), ForceMode2D.Impulse);
		}
	}
}
