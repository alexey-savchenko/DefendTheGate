using UnityEngine;
using System.Collections;
using System.Linq;

[ExecuteInEditMode]
public class ActionArea : MonoBehaviour
{
	static float x = 0;
	static float y = 100f;

	void Update ()
	{
		x = Camera.main.ScreenToWorldPoint(new Vector2(0.5f, 0f)).x; 
		//print (x);
		var points = new[] {
			new Vector3 (-x, -y, 0),
			new Vector3 (-x, y, 0),
			new Vector3 (x, y, 0),
			new Vector3 (x, -y, 0)
		};

		Color lineColor = new Color (1f, 0.5f, 0.4f, 1f);

		Debug.DrawLine (points [0], points [1], lineColor);
		Debug.DrawLine (points [1], points [2], lineColor);
		Debug.DrawLine (points [2], points [3], lineColor);
		Debug.DrawLine (points [3], points [0], lineColor);
	}

	public static bool OutOfBounds (Vector3 position)
	{
		return position.x > x ||
		position.x < -x ||
		position.y > y ||
		position.y < -y;
	}
}
