using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int playScore;
    public int PlayScore 
    { 
        get { return playScore; } 
        set { playScore = value; }
    }
    [SerializeField]
    private GameObject ballPrefab;
    [SerializeField]
    private GameObject[] ballPositions;
    public static GameManager Instance;
    void Start()
    {
        Instance = this;
    }
    private void SetBall(ColorBall col, int i)
    {
        GameObject obj = Instantiate(ballPrefab,
            ballPositions[i].transform.position,
            Quaternion.identity);
        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }
}