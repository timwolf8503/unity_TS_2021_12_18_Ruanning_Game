using TMPro;
using UnityEngine;


/// <summary>
/// 學習陣列
/// </summary>
public class LearnArray : MonoBehaviour
{

    //陣列語法
    //資料類型[]
    //儲存多筆相同類型的資料



    //欄位語法
    public int atk1 = 10;
    public int atk2 = 20;
    public int atk3 = 30;

    //陣列語法
    public int[] atk;

    //指定初始值
    //只指定列陣資料數量不指定值
    public float[] speeds = new float[5];

    //只指定列陣資料值{}
    public bool[] complete = { true, false, true };
    public string[] props = { "回血藥", "回魔藥" };
    public Vector3[] position = { new Vector3(0, 2, 1), new Vector3(0, 0, 0) };
    

    private void Start()
    {
        //1.存取列陣資料
        //名稱[編號]=值;
        //攻擊力第一個改70
        atk[0] = 70;

        //編號不可超出範圍
        //atk[3]=70;    (會出現錯誤)
        //IndexOutOfRange--=超出範圍


        //2.取得陣列資料
        print("第二筆道具資料" + props[1]);
        print("第一筆座標資料" + position[0]);

        //3.取得列陣資料數量Lenght
        print("布林值資料數量" + complete.Length);




    }

 


}
