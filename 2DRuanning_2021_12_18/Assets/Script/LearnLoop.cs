using UnityEngine;



/// <summary>
/// 迴圈
/// 1.while *
/// 2.for   *
/// 3.do while
/// 4.foreach
/// </summary>
public class LearnLoop : MonoBehaviour
{
    public int[] scores = new int [20];
    public float[] test = new float[10];


    private void Start()
    {


        //迴圈與列陣
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = 69+i;
        }

        for (int i = 0; i < test.Length; i++)
        {
            test[i] = 79.1f + i;
        }

        #region 迴圈while與for

     
        //處理重複性的程式

        //一般語法
        //五次嗨
        print("嗨");
        print("嗨");
        print("嗨");
        print("嗨");
        print("嗨");


        //while語法
        //語法與if完全相同
        //if(布林值){程式區域}
        //while(布林值){程式區域}

       
        //執行資料一次
        if (true)
        {
            print("判斷式");
        }

        //持續執行資料
        //一直執行,電腦會當掉
        /*
        while (true)
        {
            print("迴圈");
        }
        */

        //指定while次數

        int count = 0;
        while (count<5)
        {
            print("嗨while");
            count++;
        }

        //for(初始值,布林值,迴圈結束執行程式)

        for (int i = 0; i <5; i++)
        {
            print("嗨for");
        }

        //for輸出數字1~100
        for (int i = 1; i < 101; i++)
        {
            print("輸出數字"+i);
        }

        //輸出數字100~200
        for (int d = 100; d < 201; d++)
        {
            print("輸出數字" + d);
        }
#endregion




    }


}
