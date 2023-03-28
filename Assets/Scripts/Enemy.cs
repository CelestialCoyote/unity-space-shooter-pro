using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField]
	private float _speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        CalculateMovement();
    }

	void CalculateMovement()
	{
		transform.Translate(Vector3.down * _speed * Time.deltaTime);


		if (transform.position.y < -5.0f)
		{
			float randomX = Random.Range(-9.0f, 9.0f);
			transform.position = new Vector3(randomX, 6.0f, 0);
		}
	}
}
