using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player
{
	/// <summary>
	/// The zugie balls that the player has at their disposal for this game.
	/// </summary>
	private IList<PlayerBall> playerBalls; 
	/// <summary>
	/// The player's score.
	/// </summary>
	private int score; 
	/// <summary>
	/// The facebook ID of the user
	/// </summary>
	private string userID; 
	/// <summary>
	/// Initializes a new instance of the <see cref="Player"/> class with facebook information
	/// </summary>
	/// <param name="playerballs">Playerballs.</param>
	/// <param name="newScore">New score.</param>
	/// <param name="newUserID">New user I.</param>
	public Player(List<PlayerBall> newPlayerballs, int newScore, string newUserID)
	{
		playerBalls = newPlayerballs; 
		score = newScore; 
		userID = newUserID;
	}
	/// <summary>
	/// Initializes a new instance of the <see cref="Player"/> class without facebook information
	/// </summary>
	/// <param name="playerballs">Playerballs.</param>
	/// <param name="newScore">New score.</param>
	public Player(List<PlayerBall> playerballs, int newScore)
	{
		playerBalls = playerballs; 
		score = newScore; 

	}
	/// <summary>
	/// Gets the next ball.
	/// </summary>
	/// <returns>The next ball.</returns>
	public PlayerBall getNextBall()
	{
		return null;
	}

	/// <summary>
	/// Gets the score.
	/// </summary>
	/// <returns>The score.</returns>
	public int getScore()
	{
		return score; 
	}

	/// <summary>
	/// Sets the score.
	/// </summary>
	/// <param name="newScore">New score.</param>
	public void setScore(int newScore)
	{
		score = newScore; 
	}

	/// <summary>
	/// Gets the user ID.
	/// </summary>
	/// <returns>The user ID.</returns>
	public string getUserID()
	{
		return userID;
	}


}
