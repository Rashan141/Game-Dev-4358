﻿using UnityEngine;
using System.Collections;

namespace AssemblyCSharp{

public class PlayerBall {

		public PlayerBall(Player owner, GameObject ballObject){
			this.playerOwner=owner;
			this.ballObject=ballObject;
			onGameBoard=false;
		}

	///<summary>
	/// the different players that can possibly own a player ball. 
	/// </summary>
	public  enum PLAYERS
	{
		player1, player2
	}

	/// <summary>
	/// The player that owns this ball.
	/// </summary>
		private Player playerOwner; 

	/// <summary>
	/// <c>true</c> if the ball is on the game board, <c> false if it is not.</c>
	/// </summary>
	private bool onGameBoard; 

	private GameObject ballObject;

	public void initialize(){
		AimPlayerBall aimScript =this.ballObject.GetComponentInChildren<AimPlayerBall>() as AimPlayerBall;
		if(aimScript!=null){
			aimScript.playerBall=this;
		}
	}


	/// <summary>
	/// toggles player control of the game ball.  
	/// </summary>
	/// <param name="active"> if set to <c>true</c> gives the player control of the game ball 
	/// </param>
	public void possess ()
	{
			getBallObject().GetComponentInChildren<AimPlayerBall>().enabled=true;
			getBallObject().GetComponentInChildren<LaunchController>().enabled=true;
	}

		public Player getPlayer(){return playerOwner;}
		public void setPlayer(Player newOwner){playerOwner=newOwner;}
		public bool isOnBoard(){return onGameBoard;}
		public void setOnGameBoard(bool onGameBoard){this.onGameBoard= onGameBoard;}
		public GameObject getBallObject(){return ballObject;}
		public void setBallObject(GameObject ballObject)
		{
			this.ballObject=ballObject;
			AimPlayerBall aimScript =this.ballObject.GetComponentInChildren<AimPlayerBall>() as AimPlayerBall;
			if(aimScript!=null){
				aimScript.playerBall=this;
			}
		}
	
}
}
