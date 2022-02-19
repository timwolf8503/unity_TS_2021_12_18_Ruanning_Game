using System.Net;
using UnityEngine;
using UnityEngine.PlayerLoop;

/// <summary>
/// 學習判斷式
/// </summary>

public class Learncondition : MonoBehaviour
{
    //判斷式語法if(布林值){程式，演算法，陳述式}
    //快速完成 if  +   tad*2
    //if(true)執行{}內程式
    //if(false)不執行{}內程式



    public bool haskey =false;
    public int combo = 0;


    private void Start()
    {
        if (true)
        {
            print("我式判斷式if");
        }


        //布林值為true會執行{}
        //布林值為false會執行else{}

        if (haskey)
        {
            print("開門");

        }
        else
        {

            print("不能開門");
        }

        //持續進行方式
        //else  if(布林值){程式，演算法，陳述式}
        //必須寫在if下方
        //數量沒有限制
        
   



    }

    private  void Update() 
    {
        if (combo == 10)
        {
            print("攻擊加10");
        }
        else if (combo == 100)
        {
            print("攻擊加100");
        }
        else if (combo == 1000)
        {
            print("攻擊加1000");
        }



    }

}