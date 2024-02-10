using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleScript : MonoBehaviour
{
	private Color highlightColor = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	private float decayTime = 4.0f;
	private ParticleSystem ps;

	public SpriteRenderer highlightRenderer;

	void Start()
	{
		ps = gameObject.GetComponent<ParticleSystem>();
	}

	void Update()
	{
		if (highlightColor.a > 0.0f)
		{
			highlightColor.a -= decayTime * Time.deltaTime;
			highlightRenderer.color = highlightColor;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.collider.CompareTag("ball"))
		{
			highlightColor.a = 1.0f;
			highlightRenderer.color = highlightColor;
			ps.Play();
		}
	}
}
