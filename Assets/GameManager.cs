using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player;
    public List<Stage> stages;
    public int currentStage;

    public int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start() {
        currentStage = 0;
        stages[currentStage].Enter();
    }

    public void StageClear() {
        stages[currentStage].Exit();

        currentStage++;

        stages[currentStage].Enter();
    }
}
