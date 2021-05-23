using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyGfx : MonoBehaviour
{
    public AIPath enemyAIPath;
    void Start()
    {
        enemyAIPath.canMove = false;
        Debug.Log("Kod Calýstý");
    }

    // Update is called once per frame
    void Update()
    {
        if (dimensionControl.isTurned == true)
        {
            enemyAIPath.canMove = true;
        }
        else if(dimensionControl.isTurned == false)
        {
            enemyAIPath.canMove = false;
        }
    }
    //private void OnTriggerEnter2D()
    //{
    //    if (collision.gameObject.tag == "spiritual_player")
    //    {
    //        spiritEnvirementB.mustTurnSpirit = true;
    //        Debug.Log("oldu");
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "spiritual_player")
       {
          spiritEnvirementB.mustTurnSpirit = true;
         Debug.Log("oldu");
      }
    }

}
