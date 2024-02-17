//WP12 - 
//Name: Chloe Park 
//Submission Date: Monday, December 6
//Purpose: Waypoint 12 Function 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP12 : MonoBehaviour
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
        if (UltimateStick.whosTurn == -1 && GameControl.perMovePositionP1 == 11 && GameControl.P1ButtonStop == true){
            player1.GetComponent<FollowThePath>().waypointIndex = 11;
            GameControl.leftCorner1 = false;
            GameControl.P1ButtonStop = false;
            GameControl.P1LeftCornerTurn = false;
            UltimateStick.coroutineAllowed = true;
        }

        //Player2 Code - 
        else if (UltimateStick.whosTurn == 1 && GameControl.perMovePositionP2 == 11 && GameControl.P2ButtonStop == true)
        {
            player2.GetComponent<FollowThePath>().waypointIndex = 11;
            GameControl.leftCorner2 = false;
            GameControl.P2ButtonStop = false;
            GameControl.P2LeftCornerTurn = false;
            UltimateStick.coroutineAllowed = true;
        }
    }
}