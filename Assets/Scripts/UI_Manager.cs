using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Runs;
    [SerializeField]
    private TextMeshProUGUI Stats;
    [SerializeField]
    private TextMeshProUGUI BallStats;

    private RunGenerator PlayerReference;
    public GameObject Ball;
    public GameObject Bat;

    private BallPhysics BallPhy;
    //private BatPhysics BatPhy;


    void Start()
    {
        PlayerReference = GameObject.FindWithTag("Player").GetComponent<RunGenerator>();
        BallPhy = GameObject.FindWithTag("Ball").GetComponent<BallPhysics>();
    }

    public void OnButtonPressed(int RunCount)
    {
        bool Solution;
        Solution = PlayerReference.GenerateNumber(RunCount);

        if (Solution)
            Runs.text = RunCount.ToString();
        else
            Runs.text = "0";

        Stats.text = "Runs: " + PlayerReference.UpdateTotalRuns().ToString() + "\nBalls Left: " + PlayerReference.UpdateBallsLeft().ToString();
    }

    public void SetBallStats(string Stats)
    {
        BallStats.text = BallStats.text + Stats;
    }

    public void ContinueButton()
    {
        BallStats.text = "";
    }

    public void BallFunction()
    {
        Ball.SetActive(true);
        Bat.SetActive(true);
    }

    public void ResetData()
    {
        BallPhy.ResetStats();
        Ball.SetActive(false);
    }
}
