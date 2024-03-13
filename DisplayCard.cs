using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int attack;
    public int defense;
    public string cardDescription;

    public Text nameText;
    public Text costText;
    public Text attackText;
    public Text defenseText;
    public Text descriptionText;

    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        attack = displayCard[0].attack;
        defense = displayCard[0].defense;
        cardDescription = displayCard[0].cardDescription;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        attackText.text = " " + attack;
        defenseText.text = " " + defense;
        descriptionText.text = " " + cardDescription;
    }
}
