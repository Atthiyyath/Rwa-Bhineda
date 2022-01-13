using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text text;
    public static int coinAmount;
    public GameObject WinCanvas;
    private int MinCoin = 37;

    void Start()
    {
        WinCanvas.SetActive(false);
        text = GetComponent<Text>();
    }
    void Update()
    {
        Debug.Log(coinAmount);
        text.text = coinAmount.ToString();
        if(coinAmount > MinCoin)
        {
            FindObjectOfType<SoundManager>().WinScreen();
            WinCanvas.SetActive(true);
        }

        /*
        score = coinAmount;
        PlayerPrefs.SetInt("score", score);
        winScreen.coinText.text = PlayerPrefs.GetInt("score").ToString();
        */
    }

#if UNITY_EDITOR
    //this code block only compiled on unity editor, wont be taken on build
   
    [ContextMenu("TestUnlockStage")]
    void TestUnlockStage()
    {
        coinAmount = 3;
    }
#endif

    

}
