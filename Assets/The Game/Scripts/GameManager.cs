using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	// Place holders to allow connecting to other objects WE NEED THESE
	public Transform spawnPoint;
	public GameObject player;

	// Flags that control the state of the game WE NEED THESE?
	private float elapsedTime = 0;
	private bool isRunning = false;
	private bool isFinished = false;

	// So that we can access the player's controller from this script REPLACE WITH OUR CONTROLLER
	private PlayerMovement PlayerController;


	// Use this for initialization
	void Start()
	{
		//Tell Unity to allow character controllers to have their position set directly. This will enable our respawn to work WE NEED THIS
		Physics.autoSyncTransforms = true;

		// Finds the First Person Controller script on the Player REPLACE WITH OUT CONTROLLER
		PlayerController = player.GetComponent<PlayerMovement>();

		// Disables controls at the start. WE NEED THIS?
		PlayerController.enabled = false;
	}


	//This resets to game back to the way it started NEED THIS
	private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;

		// Move the player to the spawn point, and allow it to move. NEED THIS
		PositionPlayer();
		PlayerController.enabled = true;
	}


	// Update is called once per frame DELETE THIS LATER
	void Update()
	{
		// Add time to the clock if the game is running
		if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
		}
	}


	//Runs when the player needs to be positioned back at the spawn point NEED THIS
	public void PositionPlayer()
	{
		player.transform.position = spawnPoint.position;
		player.transform.rotation = spawnPoint.rotation;
	}


	// Runs when the player enters the finish zone NEED THIS CHANGE CONTROLLER
	public void FinishedGame()
	{
		isRunning = false;
		isFinished = true;
		PlayerController.enabled = false;
	}


	//This section creates the Graphical User Interface (GUI)
	void OnGUI()
	{

		if (!isRunning)
		{
			string message;

			if (isFinished)
			{
				message = "Click or Press Enter to Play Again";
			}
			else
			{
				message = "Click or Press Enter to Play";
			}

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width / 2 - 120, Screen.height / 2, 240, 30);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				//start the game if the user clicks to play
				StartGame();
			}
		}
	}

}
