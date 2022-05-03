using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Map : MonoBehaviour
{
    [SerializeField] float respawnTime;
    [SerializeField] float rotationSpeed = 5f;
    private Quaternion targetRot;
    public GameObject gameBoard;
    public PlayerController playerController;


    void start()
    {
        playerController = GetComponent<PlayerController>();
        targetRot = transform.rotation;
    }

    void Update()
    {
        rotationControls();
    }


    // IEnumerator Start()
    // {
    //     yield return StartCoroutine(respawnPlayer(3f));
    // }

    // IEnumerator respawnPlayer(float respawnTime)
    // {
    //     yield return new WaitForSeconds(respawnTime);
    //     playerController.player.SetActive(true);
    // }

    void rotationControls()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            targetRot = Quaternion.AngleAxis(0, transform.forward);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            targetRot = Quaternion.AngleAxis(90, transform.forward);
            playerController.player.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            targetRot = Quaternion.AngleAxis(180, transform.forward);
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            targetRot = Quaternion.AngleAxis(-90, transform.forward);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);

        if (rotationSpeed < 0)
        {
            playerController.player.SetActive(true);
        }
    }



}
