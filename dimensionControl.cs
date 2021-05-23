using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dimensionControl : MonoBehaviour
{
    public BoxCollider2D playerMaditateMode;
    public BoxCollider2D playerActiveMode;
    public PhysicsMaterial2D playerMat;
    public Rigidbody2D playerBody_rb2d;
    public GameObject playerBody_CMcam;
    public GameObject playerBody_pointLight;
    public GameObject playerBodyMaditate_pointLight;
    public GameObject explosionPosition;
    public GameObject playerBody;
    public GameObject playerBodyMovement;
    public GameObject spiritualPlayer;
    public GameObject playerCamera;
    public GameObject spiritCamera;
    public Animator spiritPanel;
    public Animator animControl;
    public Animator explosionControl;
    public static bool isTurned = false;

    private void Start()
    {
        playerBody_CMcam.SetActive(true);
        playerCamera.SetActive(true);
        spiritCamera.SetActive(false);
        playerBodyMovement.SetActive(true);
        spiritualPlayer.SetActive(false);
        playerActiveMode.enabled = true;
        playerMaditateMode.enabled = false;
        playerBody_pointLight.SetActive(true);
        playerBodyMaditate_pointLight.SetActive(false);
        animControl.SetBool("is_turned", false);
        spiritPanel.SetBool("is_Turned", false);
    }
    private void Update()
    {
        explosionPosition.transform.position = spiritualPlayer.transform.position;
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!isTurned)
            {
                enterSpiritWorld();
            }
            else if(isTurned)
            {
                exitSpiritWorld();
            }
        }
        if (spiritEnvirementB.mustTurnSpirit == true)
        {
            exitSpiritWorld();
            spiritEnvirementB.mustTurnSpirit = false;
        }

        // Player Animasyon________
       /* if (isTurned)
        {
            animControl.SetBool("is_turned", true);
            animControl.SetBool("is_Walking", false);
            animControl.SetBool("is_Jumping", false);
        }else
        {
            animControl.SetBool("is_turned", false);
            if(player_movement.isGrounded)
            {
                animControl.SetBool("is_Jumping", false);
                if(player_movement.moveInput != 0f)
                {
                    animControl.SetBool("is_Walking", true);
                }else
                {
                    animControl.SetBool("is_Walking", false);
                }
            }
            else if (!player_movement.isGrounded)
            {
                animControl.SetBool("is_Jumping", true);
                animControl.SetBool("is_Walking", false);
                animControl.SetBool("is_Jumping", false);
            }
        }
        */
    }
    private void enterSpiritWorld()
    {
        spiritCamera.transform.position = playerCamera.transform.position;
        playerBody_CMcam.SetActive(false);
        spiritCamera.SetActive(true);
        playerCamera.SetActive(false);
        playerActiveMode.enabled = false;
        playerMaditateMode.enabled = true;
        playerBody_pointLight.SetActive(false);
        playerBodyMaditate_pointLight.SetActive(true);
        animControl.SetBool("is_turned", true);
        spiritualPlayer.transform.position = playerBody.transform.position;
        playerBodyMovement.SetActive(false);
        spiritualPlayer.SetActive(true);
        isTurned = true;
        explosionControl.SetBool("isSpiritExit", false);
        spiritPanel.SetBool("is_Turned", true);
    }
    private void exitSpiritWorld()
    {
        playerCamera.transform.position = spiritCamera.transform.position;
        playerBody_CMcam.SetActive(true);
        playerCamera.SetActive(true);
        spiritCamera.SetActive(false);
        playerActiveMode.enabled = true;
        playerMaditateMode.enabled = false;
        playerBody_pointLight.SetActive(true);
        playerBodyMaditate_pointLight.SetActive(false);
        animControl.SetBool("is_turned", false);
        playerBodyMovement.SetActive(true);
        spiritualPlayer.SetActive(false);
        isTurned = false;
        explosionControl.SetBool("isSpiritExit", true);
        spiritPanel.SetBool("is_Turned", false);
    }
}
