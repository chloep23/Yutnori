//WP22 - 
//Name: Chloe Park 
//Submission Date: Monday, December 6
//Purpose: Waypoint 22 Function 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP22 : MonoBehaviour
{
    //Object Var: 
     public static GameObject player1, player2;

    //Used for initialization
    void Start()
    {
        //Declaring Players - 
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    //Mouse Clicks Waypoint Code - 
    public void OnMouseDown()
    {
        //Player1 Code - 
        if (UltimateStick.whosTurn == -1 && GameControl.perMovePositionP1 == 6 && GameControl.P1ButtonStop == true){
            player1.GetComponent<FollowThePath>().waypointIndex = 21;
            GameControl.player1StartWaypoint = 20;
            GameControl.rightPathP1 = true;
            GameControl.P1ButtonStop = false;
            GameControl.P1RightCornerTurn = false;
            UltimateStick.coroutineAllowed = true;
        }
        //Player2 Code - 
        else if (UltimateStick.whosTurn == 1 && GameControl.perMovePositionP2 == 6 && GameControl.P2ButtonStop == true){
            player2.GetComponent<FollowThePath>().waypointIndex = 21;
            GameControl.player2StartWaypoint = 20;
            GameControl.rightPathP2 = true;
            GameControl.P2ButtonStop = false;
            GameControl.P2RightCornerTurn = false;
            UltimateStick.coroutineAllowed = true;
        }
    }
}