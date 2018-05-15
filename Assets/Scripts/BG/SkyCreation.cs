using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creates tiled sky backgrounds. Takes the game object as the origin and tiles them to the right.
public class SkyCreation : MonoBehaviour {

    public GameObject SkyPrefab;
    public Vector3 StartingPosition;
    public int NumberOfSkies;
    public float TileWidth;

	// Use this for initialization
	void Start () {

        for (int i = 1; i <= NumberOfSkies; i++)
        {
            Vector3 position = new Vector3(StartingPosition.x + TileWidth * i, StartingPosition.y, StartingPosition.z);
            Instantiate(SkyPrefab, position, Quaternion.identity, gameObject.transform);
        }
		
	}
}
