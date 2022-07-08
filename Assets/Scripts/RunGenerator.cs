using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGenerator : MonoBehaviour
{
    [SerializeField]
    private int[] RunTable;
    [SerializeField]
    private int[] Run;
    private int Score;
    private int RandomRun;
    private int TotalRunProbability = 0;

    private int TotalRuns = 0;
    private int MaxBalls = 30;
    private int BallsLeft;

    void Start()
    {
        BallsLeft = MaxBalls;
        foreach(var item in RunTable)
        {
            TotalRunProbability += item;
        }
    }

    public bool GenerateNumber(int PlayerRun)
    {
        int RunCounter = 0;

        RandomRun = Random.Range(0, TotalRunProbability);

        foreach(var Weight in RunTable)
        {
            if(RandomRun <= Weight)
            {
                RandomRun = Run[RunCounter];
                break;
            }
            else
            {
                RunCounter++;
                RandomRun = RandomRun - Weight;
            }
        }

        BallsLeft--;

        if (RandomRun == PlayerRun)
        {
            TotalRuns += PlayerRun;
            return true;
        }
        else
            return false;
    }

    public int UpdateTotalRuns()
    {
        return TotalRuns;
    }
    public int UpdateBallsLeft()
    {
        return BallsLeft;
    }
}
