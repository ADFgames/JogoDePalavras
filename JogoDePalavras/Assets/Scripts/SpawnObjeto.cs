using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnObjeto : MonoBehaviour 
{

	public float maxHeight;
	public float minHeight;

	public float rateSpawn;

	private float currentRateSpawn;

	public GameObject prefab;

	public int maxObjeto;

	public List<GameObject> objeto;

	private float randPosition;

    public int maxSpawn;
    public int minSpawn;
    public int A;
    public int B;

   

	// Use this for initialization
	void Start ()
	{
	
		for (int i=0; i < maxObjeto; i++)
		{
			GameObject tempObjeto = Instantiate(prefab)as GameObject;
			objeto.Add(tempObjeto);
			tempObjeto.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentRateSpawn += Time.deltaTime;
		if (currentRateSpawn > rateSpawn) 
		{
			currentRateSpawn = 0;
			Spawn ();
		}
		
	}

	private void Spawn()
	{
		int rand  = Random.Range (minSpawn, maxSpawn);

		if (rand < A) 
		{
			randPosition = minHeight;
		} 
		if (rand >= A && rand < B)
		{
			randPosition = maxHeight;
		}
		if (rand >= B)
		{
			randPosition = 0;
		}

		GameObject tempObjeto = null;

		for (int i=0; i < maxObjeto; i++) 
		{
			if (objeto [i].activeSelf == false) 
			{
				tempObjeto = objeto [i];
				break;
			}

		}

		if(tempObjeto != null)
		{
            tempObjeto.transform.position = new Vector3(randPosition, transform.position.y, transform.position.z);
            tempObjeto.SetActive(true);
		}

	}
}
