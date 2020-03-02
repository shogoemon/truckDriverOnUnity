using System;
using System.Text;
using UnityEngine;

namespace PlayingScript
{
public static class PlayingScript
{
    public static bool gameOverBool=true;
    public static int currentCoinScore=0;
    public static int highScore=0;
    public static int totalScore=0;
    public static bool dropTrapBool=false;
    public static bool bridgeTrapBool=false;

    public static void saveScore(){
        totalScore+=currentCoinScore;
        PlayerPrefs.SetInt("TotalScore",totalScore);
        if(currentCoinScore>highScore){
              highScore=currentCoinScore;
              PlayerPrefs.SetInt("HighScore",highScore);
        }
        PlayerPrefs.Save();
    }

     public static void loadScore(){
            highScore=PlayerPrefs.GetInt("HighScore",0);
            totalScore=PlayerPrefs.GetInt("TotalScore",0);
     }
}
}