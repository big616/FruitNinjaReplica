using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawner : MonoBehaviour {

	public GameObject fruitPrefab;
	public Transform[] spawnPoints;
	// Use this for initialization
	public float minDelay = .1f;
	public float maxDelay = 1f;
	void Start () {
		StartCoroutine (SpawnFruits ());
	}
	
	IEnumerator SpawnFruits ()
	{
		while (true)
		{
			//spawn
			float delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range (0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints [spawnIndex];

			GameObject spawnedFruit = Instantiate (fruitPrefab, spawnPoint.position, spawnPoint.rotation);
			Destroy (spawnedFruit, 4f);
		}
	}
}