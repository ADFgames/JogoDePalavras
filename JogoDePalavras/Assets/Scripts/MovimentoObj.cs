using UnityEngine;
using System.Collections;

public class MovimentoObj : MonoBehaviour {

	public Transform player;
	public float maxPosition;
	public float velocidadeX;
	public bool esquerda;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () 
	{
		if (esquerda) 
		{
			if (player.transform.position.x >= maxPosition)
			{
				player.transform.Translate (velocidadeX, 0, 0);
			}
		} 
		else 
		{
			if (player.transform.position.x <= maxPosition)
			{
				player.transform.Translate(velocidadeX, 0, 0);
			}
		}

	}
}