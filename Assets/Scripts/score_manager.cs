using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_manager : MonoBehaviour
{
    public Text money_total;
    int money = 0;
    public static score_manager instance;

    private void Awake()
    {
        instance = this;
        int numScoreMan = FindObjectsOfType<score_manager>().Length;
        if (numScoreMan != 1)
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        money_total.text = "$" + money.ToString();
        DontDestroyOnLoad(gameObject);
        
    }

    public void AddPoints()
    {
        money += 10;
        money_total.text = "$" + money.ToString();
    }
}
