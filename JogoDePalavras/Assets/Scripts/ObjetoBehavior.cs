using UnityEngine;
using System.Collections;

public class ObjetoBehavior : MonoBehaviour 
{

	public float velocidade;

	public GameObject Objeto;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += new Vector3 (0, -velocidade, 0) * Time.deltaTime;

		if (transform.position.y < -4.5f) 
		{
			Objeto.SetActive (false);
		}
	}
}