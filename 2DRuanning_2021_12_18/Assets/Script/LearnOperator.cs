using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float B = 5;
    public int C = 50;
    public int D = 10;
    private void Start()
    {

        #region 運算子:數學
        //加 +
        print("加法 :"+(a + B));
        print(a + B + B);
        //減 -
        print("減法 :" + (a - B));
        //乘 *
        print("乘法 :" + (a * B)); 
        print(B * B * B);
        //除 /
        print("除法 :" + (a / B));
        //餘數 %
        print("餘法 :" + (a % B));
        #endregion
        #region 運算子:比較
        //結果為布林值  true or false
        //大於 >
        print("大於" + (C > D));   //true
        print(a > B);
        //小於 <
        print("小於" + (C < D));  //false
        //大於等於 >=
        print("大於等於" + (C >= D));  // true
        //小於等於 <=
        print("小於等於" + (C <= D)); //false
        //等於 ==
        print("等於" + (C == D));   //false
        print(a == D);
        //不等於 !=
        print("不等於" + (C !> D));  //true

        #endregion
        #region 運算子:邏輯
        //結果為布林值  true or false
        // 布林值與布林值的運算
        // 並且 && (shift+7(&))
        //只要一個有false結果就是false
        print(true && true);       //true
        print(true && false);      //false
        print(false && true);     //false
        print(false && false);    //false
        // 或者 || (shift+鎮)
        //節我有一個true結果就是true
        print(true || true);    //true
        print(true || false);   //true
        print(false || true);   //true
        print(false || false);  //false
        //顛倒 !
        //將布林值相反
        print(!true);  //false
        print(!false); //true


        #endregion
    }

}
