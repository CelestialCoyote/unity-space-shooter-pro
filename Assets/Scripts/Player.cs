using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField]
	private float _speed = 3.5f;
	[SerializeField]
	private GameObject _laserPrefab;

    void Start()
    {
		transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
		CalculateMovement();

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(_laserPrefab, transform.position, Quaternion.identity);
		}
    }

	void CalculateMovement()
	{
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");
		
		Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
		transform.Translate(direction * _speed * Time.deltaTime);

		if (transform.position.x > 11.3f)
		{
			transform.position = new Vector3(-11.3f, transform.position.y, 0);
		} else if (transform.position.x < -11.3f)
		{
			transform.position = new Vector3(11.3f, transform.position.y, 0);
		}

		if (transform.position.y  >= 0)
		{
			transform.position = new Vector3(transform.position.x, 0, 0);
		} else if (transform.position.y < -3.8f)
		{
			transform.position = new Vector3(transform.position.x, -3.8f, 0);
		}
	}
}
