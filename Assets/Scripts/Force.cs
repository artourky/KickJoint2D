using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Force : MonoBehaviour {

	public class amon {
		public int a;

		public void data() {
			print("" + a);
		}
	}

	public Vector2 forceApplied = new Vector2(80f, 15f);
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		amon a = new amon();
		a.data();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(forceApplied, ForceMode2D.Impulse);
		}
	}
}
