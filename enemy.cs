using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public AIPath enemyAIPath;
    void Start()
    {
        enemyAIPath.canMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dimensionControl.isTurned == false)
        {
            enemyAIPath.canMove = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "spiritual_player")
        {
            spiritEnvirementB.mustTurnSpirit = true;
            Debug.Log("oldu");
        }
    }

}
