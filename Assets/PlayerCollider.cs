using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
	private const string enemy = "Enemy";

	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log(collision.gameObject.CompareTag(enemy));

		EnemyCollider en = collision.gameObject.GetComponent<EnemyCollider>();
		en.Hit();
	}
}
