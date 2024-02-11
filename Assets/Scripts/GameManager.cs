using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text scoreCount;

    
    void Start()
    {
        score = 0;
    }

    
    void Update()
    {
        scoreCount.text = score.ToString();
    }
}
