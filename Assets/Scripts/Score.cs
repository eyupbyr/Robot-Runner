using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = (playerTransform.position.z + Game_Manager.totalCoinPoints).ToString("0");
    }
}
