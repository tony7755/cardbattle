using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    Player player1;
    Player player2;

    Player currentPlayer;
    Player currentOpponent;

    public int initialHealth = 100;
    public int initialPip = 0;
    public UnityEngine.UI.Button backButton;
    public UnityEngine.UI.Button replayButton;
    public UnityEngine.UI.Button finishTurnButton;


    void switchPlayer()
    {
        if (currentPlayer = player1)
        {
            currentPlayer = player2;
            currentOpponent = player1;
        }
        else
        {
            currentPlayer = player1;
            currentOpponent = player2;
        }
            
    }

    

    // Use this for initialization
    void Start () {
        player1 = new global::Player(initialHealth, initialPip);
        player2 = new global::Player(initialHealth, initialPip);
        backButton.gameObject.SetActive(false);
        replayButton.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //check game ends
	    if (!player1.isAlive() || !player2.isAlive()) // one of the player die
        {
            backButton.gameObject.SetActive(true);
            backButton.gameObject.SetActive(true);
        }
	}
}
