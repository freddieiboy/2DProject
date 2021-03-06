using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
		public float speed = 5;

		private Rigidbody2D rb;
		private Collider2D col;
		private SpriteRenderer rend;
		private Animator anim;
		private Vector2 move;
		private bool isColliding = false;


		// Start is called before the first frame update
		void Start() {
				rb = GetComponent<Rigidbody2D>();
				// col = GetComponent<Collider2D>();
				rend = GetComponent<SpriteRenderer>();
				anim = GetComponent<Animator>();
				col = GetComponent<CapsuleCollider2D>();

				// fix to the down idle
				anim.SetFloat("lastY", -0.01f);
		}

		public void OnMove(InputValue value) {
				move = value.Get<Vector2>();
				// Debug.Log(move);
				if (move != Vector2.zero) {
						anim.SetFloat("lastX", move.x);
						anim.SetFloat("lastY", move.y);
				}
				else {
						isColliding = false;
				}

		}

		private void OnCancel() {
				Debug.Log("OnCancel");
		}

		// Update is called once per frame
		void FixedUpdate() {
				// rb.AddForce(rb.position + move * speed * Time.deltaTime); // apply force over time
				// rb.velocity =  dmove * speed * Time.deltaTime;
				if (!isColliding) {
						// rb.MovePosition(rb.position + (move * speed * Time.deltaTime));
						rb.velocity = move * speed * Time.deltaTime;
				}
		}

		void Update() {
				anim.SetFloat("x", move.x);
				anim.SetFloat("y", move.y);
				anim.SetFloat("magnitude", move.sqrMagnitude);
		}

}
