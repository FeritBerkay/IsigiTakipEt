using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject playerBody;
    public GameObject spiritBody;
    private Vector3 followDes;
    private Vector3 target;
    private Vector3 referance = Vector3.zero;
    public float sharpnessValue = 0.3f;

    private void Start()
    {
        followDes = new Vector3(0, 0, -5);
    }

    void LateUpdate()
    {
        if (!dimensionControl.isTurned)
        {
            cameraFollowPlayer();
        }
        else if (dimensionControl.isTurned)
        {
            cameraFollowSpirit();
        }
    }
    void cameraFollowPlayer()
    {
        target = playerBody.transform.position + followDes;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref referance, sharpnessValue);
    }
    void cameraFollowSpirit()
    {
        target = spiritBody.transform.position + followDes;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref referance, sharpnessValue);
    }
}
