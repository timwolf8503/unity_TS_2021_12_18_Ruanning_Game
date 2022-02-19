using System.Net;
using UnityEngine;
using UnityEngine.PlayerLoop;

/// <summary>
/// 學習判斷式
/// 1.if
/// 2.switch
/// </summary>

public class Learncondition : MonoBehaviour
{
    //判斷式語法if(布林值){程式，演算法，陳述式}
    //快速完成 if  +   tad*2
    //if(true)執行{}內程式
    //if(false)不執行{}內程式



    public bool haskey =false;
    public int combo = 0;
    public string weapon;


    //列舉public  enum 名稱{選單名稱}
    //1.製作列舉(下拉選單)
    public enum Season
    {
        spring,summer,fall,winter   
    }

    //2.實作列舉
    public Season season;

    private void Start()
    {
        #region if判斷式

     
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

            #endregion

            #region swith判斷式



            //swith語法()
            //{
            //  case    值1:
            //            程式內容;
            //            程式內容;
            //            程式內容;
            //            程式內容;
            //          斷開break;
            //  default
            //            程式內容;
            //            程式內容;
            //            程式內容;
            //            程式內容;
            //          斷開break;
            //}
            switch (weapon)
            {
                case "小刀":
                    print("攻擊力10");
                        break;
                case "弓箭":
                    print("攻擊力100");
                    break;
                case "手槍":
                    print("攻擊力200");
                    break;
                default:
                    print("沒有武器");
                    break;
            }
            #endregion


            //swith +   enum
            switch (season)
            {
                case Season.spring:
                    print("春天");
                    break;
                case Season.summer:
                    print("夏天");
                    break;
                case Season.fall:
                    print("秋天");
                    break;
                case Season.winter:
                    print("冬天");
                    break;
            
            }


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