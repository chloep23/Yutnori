//Pause Button - 
//Name: Chloe Park 
//Submission Date: Monday, December 6
//Purpose: Trigger for Buttons

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    //Object Var: 
    [SerializeField] GameObject pauseButton; //Private variable but also shows up in editor

    //Pause Function - 
    public void Pause()
    {
        GameControl.paused = true;
        pauseButton.SetActive(true);
        Time.timeScale = 0f; //Freezes game
    }

    //Resume Function - 
    public void Resume()
    {
        GameControl.paused = false;
        pauseButton.SetActive(false);
        Time.timeScale = 1f;
    }

    //MainMenu Function - 
    public void MainMenu()
    {
        GameControl.paused = false;
        Time.timeScale = 1f;
        GameControl.paused = false;
        GameControl.gameOver = false;
        GameControl.player1.GetComponent<FollowThePath>().waypointIndex = 1;
        GameControl.player2.GetComponent<FollowThePath>().waypointIndex = 1;
        GameControl.player1StartWaypoint = 0;
        GameControl.player2StartWaypoint = 0;
        GameControl.perMovePositionP1 = 0;
        GameControl.perMovePositionP2 = 0;
        GameControl.stickSideThrown = 0;
        GameControl.rightCorner1 = true;
        GameControl.rightCorner2 = true;
        GameControl.leftCorner1 = true;
        GameControl.leftCorner2 = true;
        GameControl.rightPathP1 = false;
        GameControl.rightPathP2 = false;
        GameControl.leftPathP1 = false;
        GameControl.leftPathP2 = false;
        GameControl.validWinP1 = false;
        GameControl.validWinP2 = false;
        GameControl.P1LeftCornerTurn = false;
        GameControl.P2LeftCornerTurn = false;
        GameControl.P1RightCornerTurn = false;
        GameControl.P2RightCornerTurn = false;
        GameControl.P1ButtonStop = false;
        GameControl.P2ButtonStop = false;
        UltimateStick.whosTurn = 1;
        SceneManager.LoadScene(0); //Switches Main Menu Scene
    }

    //Exit Function - 
    public void Exit()
    {
        GameControl.paused = false;
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; //Only in Unity Editor
#endif
        Application.Quit(); //On Separate Application 
    }
}
