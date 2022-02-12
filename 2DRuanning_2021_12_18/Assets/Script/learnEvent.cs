using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnEvent : MonoBehaviour
{
    //開始遊戲
    //遊戲開始時事件發生一次
    //只有一次
    private void Start()
    {
        //輸出 (); print(); (小寫)
        print("哈摟，沃德");
          
    }
    //遊戲開始時持續輸出，每秒60次 60FPS
    //持續循環
    private void Update()
    {
        print("Update 練習");
    }
}