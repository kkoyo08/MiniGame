using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour
{
    Text text;
    public static int diceNumber1, diceNumber2, diceNumber3, diceNumber4, diceNumber5, diceEndNumber;


    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        diceEndNumber = diceNumber1 + diceNumber2 + diceNumber3 + diceNumber4 + diceNumber5;
        text.text = diceEndNumber.ToString();
    }
}
