using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{

	private Animator animator;
	private const string enemyDeath = "enemy_death";
	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void Hit()
	{
		animator.Play(enemyDeath);
	}

	public void Destroy()
	{
		Destroy(gameObject);
		Debug.Log("destroy");
	}
}
