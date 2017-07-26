using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWorld : MonoBehaviour {
    public int WorldRadius;
    public GameObject[] Bioms;
    public int radius;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject MakeRandomTile(GameObject optNeighboringBiom) {
        if (optNeighboringBiom) { }
        //Random r = new Random();
        int r = (int)Random.Range(0, Bioms.Length - 1);
        //int rInt = r.Next(0, Bioms.Length-1); //for ints
        return Bioms[r];
    }

    public List<float>[][] TileCoordinates(int radius) {
        List<float>[][] result;
        int x, y;
        while (radius >= 0) {
            x = --radius;
        }

        return result;
    }
}
