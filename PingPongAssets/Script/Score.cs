using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int Player1;
    private int Player2;

    public GameObject Playertext1;
    public GameObject Playertext2;

    public int goal;
    void Update()
    {
        if (Player1 >= goal || Player2 >= goal)
        {
            Debug.Log("Won the game");
        }
    }
    void FixedUpdate()
    {
        TextMeshProUGUI UiPlayer1text = this.Playertext1.GetComponent<TextMeshProUGUI>();
        UiPlayer1text.text = this.Player1.ToString();
        TextMeshProUGUI UiPlayer2text = this.Playertext2.GetComponent<TextMeshProUGUI>();
        UiPlayer2text.text = this.Player2.ToString();
    }
    public void Player1score()
    {
        Player1++;
    }
    public void Player2score()
    {
        Player2++;
    }
}
