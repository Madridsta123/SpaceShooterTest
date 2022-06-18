using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI FinalScore_holder;
    public TextMeshProUGUI SCORE_HOLDER;
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SCORE_HOLDER.text = score.ToString();
    }
}
