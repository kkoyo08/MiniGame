using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour
{
    Vector3 diceVelocity;

    void FixedUpdate()
    {
        diceVelocity = DiceScript.diceVelocity;
    }

    void OnTriggerStay(Collider col)
    {
        // 주사위가 멈출 때
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            // 점수 지정
            switch (col.gameObject.name)
            {
                case "Side1_1":
                    DiceNumberTextScript.diceNumber1 = 6;
                    break;
                case "Side2_1":
                    DiceNumberTextScript.diceNumber1 = 5;
                    break;
                case "Side3_1":
                    DiceNumberTextScript.diceNumber1 = 4;
                    break;
                case "Side4_1":
                    DiceNumberTextScript.diceNumber1 = 3;
                    break;
                case "Side5_1":
                    DiceNumberTextScript.diceNumber1 = 2;
                    break;
                case "Side6_1":
                    DiceNumberTextScript.diceNumber1 = 1;
                    break;
            }
            switch (col.gameObject.name)
            {
                case "Side1_2":
                    DiceNumberTextScript.diceNumber2 = 6;
                    break;
                case "Side2_2":
                    DiceNumberTextScript.diceNumber2 = 5;
                    break;
                case "Side3_2":
                    DiceNumberTextScript.diceNumber2 = 4;
                    break;
                case "Side4_2":
                    DiceNumberTextScript.diceNumber2 = 3;
                    break;
                case "Side5_2":
                    DiceNumberTextScript.diceNumber2 = 2;
                    break;
                case "Side6_2":
                    DiceNumberTextScript.diceNumber2 = 1;
                    break;
            }
            switch (col.gameObject.name)
            {
                case "Side1_3":
                    DiceNumberTextScript.diceNumber3 = 6;
                    break;
                case "Side2_3":
                    DiceNumberTextScript.diceNumber3 = 5;
                    break;
                case "Side3_3":
                    DiceNumberTextScript.diceNumber3 = 4;
                    break;
                case "Side4_3":
                    DiceNumberTextScript.diceNumber3 = 3;
                    break;
                case "Side5_3":
                    DiceNumberTextScript.diceNumber3 = 2;
                    break;
                case "Side6_3":
                    DiceNumberTextScript.diceNumber3 = 1;
                    break;
            }
            switch (col.gameObject.name)
            {
                case "Side1_4":
                    DiceNumberTextScript.diceNumber4 = 6;
                    break;
                case "Side2_4":
                    DiceNumberTextScript.diceNumber4 = 5;
                    break;
                case "Side3_4":
                    DiceNumberTextScript.diceNumber4 = 4;
                    break;
                case "Side4_4":
                    DiceNumberTextScript.diceNumber4 = 3;
                    break;
                case "Side5_4":
                    DiceNumberTextScript.diceNumber4 = 2;
                    break;
                case "Side6_4":
                    DiceNumberTextScript.diceNumber4 = 1;
                    break;
            }
            switch (col.gameObject.name)
            {
                case "Side1_5":
                    DiceNumberTextScript.diceNumber5 = 6;
                    break;
                case "Side2_5":
                    DiceNumberTextScript.diceNumber5 = 5;
                    break;
                case "Side3_5":
                    DiceNumberTextScript.diceNumber5 = 4;
                    break;
                case "Side4_5":
                    DiceNumberTextScript.diceNumber5 = 3;
                    break;
                case "Side5_5":
                    DiceNumberTextScript.diceNumber5 = 2;
                    break;
                case "Side6_5":
                    DiceNumberTextScript.diceNumber5 = 1;
                    break;
            }
        }
    }
}
