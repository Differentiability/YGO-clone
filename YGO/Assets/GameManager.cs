using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Card[] playerCardsInDeck;
    private Card[] opponentCardsInDeck;
    private Card[] playerCardsInHand;
    private Card[] opponentCardsInHand;
    private Card[] cardsOnField;
    private Card[] playerCardsInGraveyard;
    private Card[] opponentCardsInGraveyard;

    // Start is called before the first frame update
    void Start()
    {
        loadPlayerDeck();
        loadOpponentDeck();
        initializeDecks();
    }

    public void initializeDecks()
    {
        // shuffel and populate playerCardsInDeck
        // shuffel and populate opponentCardsInDeck
    }

    public void loadPlayerDeck()
    {
        // loads saved JSON file with PASSCODES of selected cards
    }

    public void loadOpponentDeck()
    {
        // requests from the PC a JSON file with PASSCODES of selected cards
    }
}
