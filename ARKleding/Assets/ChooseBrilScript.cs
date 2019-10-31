using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBrilScript : MonoBehaviour {


    public List<GameObject> Brillen = new List<GameObject>();

    int brilIndex;

    // Use this for initialization
    void Start () {
        brilIndex = -1;
        GameObject bril = Instantiate(Brillen[1], new Vector3(0, 0, 0), Quaternion.Euler(0, -0, 0)) as GameObject;
        bril.transform.parent = GameObject.Find("FaceAttachment").transform;
    }
	
	// Update is called once per frame
	void Update () {
		
    


	}

    public void NextBril()
    {
         brilIndex++;
        if (brilIndex == Brillen.Count)
        {
            brilIndex = 0;
        }

        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        GameObject bril = Instantiate(Brillen[brilIndex], new Vector3(0, 0, 0), Quaternion.Euler(0, -0, 0)) as GameObject;
        bril.transform.parent = GameObject.Find("FaceAttachment").transform;

    }

   public void PrevBril()
    {
        brilIndex--;
        if (brilIndex < 0)
        {
            brilIndex = Brillen.Count - 1;
        }

        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        GameObject bril = Instantiate(Brillen[brilIndex], new Vector3(0, 0, 0), Quaternion.Euler(0, -0, 0)) as GameObject;
        bril.transform.parent = GameObject.Find("FaceAttachment").transform;
       
    }
}
