using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameBoard : MonoBehaviour
{


    [SerializeField] float waitTime;
    public GameObject barrierPrefab;
    public GameObject wallPrefab;

    // void Start()
    // {
    //     // rotationHappening = GetComponent<Rotate_Map>().isRotating = false;
    // }

    void Update()
    {
        // if(rotationHappening==true)
        // {
        //     Debug.Log("We are rotating now!");
        // }
    }

    IEnumerator Start()
    {
        yield return StartCoroutine(WaitForInput(0.1f));
    }

    IEnumerator WaitForInput(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Instantiate(barrierPrefab);
        Instantiate(wallPrefab);
    }
}
