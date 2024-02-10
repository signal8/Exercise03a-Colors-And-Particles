using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
	private Color highlightColor = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	private float decay = 4.0f;

	public SpriteRenderer highlightRenderer;

	void Update()
	{
		if (highlightColor.a > 0.0f)
                {
                        highlightColor.a -= decay * Time.deltaTime;
                        highlightRenderer.color = highlightColor;
                }
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		highlightColor.a = 1.0f;
		highlightRenderer.color = highlightColor;
	}
}
