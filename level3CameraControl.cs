using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3CameraControl : MonoBehaviour
{
    public GameObject level3SpiritualCamera;
    public GameObject level3PhysicyCamera;
    public GameObject level3Cameras;
    public GameObject Cameras;
    void Start()
    {
        level3Cameras.SetActive(false);
        Cameras.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            level3Cameras.SetActive(true);
            Cameras.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(dimensionControl.isTurned)
            {
                level3SpiritualCamera.SetActive(true);
                level3PhysicyCamera.SetActive(false);
                   
            }else
            {
                level3SpiritualCamera.SetActive(false);
                level3PhysicyCamera.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Cameras.SetActive(true);
            level3Cameras.SetActive(false);
        }
    }
}
