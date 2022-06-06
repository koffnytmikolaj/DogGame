using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    private int gamePoints;
    [SerializeField] Text pointsText;
    [SerializeField] Text pointsTextMenu;

    // Update is called once per frame
    void FixedUpdate()
    {
        gamePoints = (int)GetComponent<Transform>().position.x;
        pointsText.text = "Score: " + gamePoints.ToString();
        pointsTextMenu.text = "Score: " + gamePoints.ToString();
    }
}
