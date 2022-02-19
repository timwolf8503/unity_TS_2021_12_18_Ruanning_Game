using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //方法語法
    //修飾詞  回傳資料類型  方法名稱  (參數){程式內容，陳述式，演算法}
    //void 無傳回，此資料不會回傳資料


    //呼叫方法 名稱();
    private void Start()
    {
        Test();
        Test();
        ShootIce();
        Shootfire();
        //有幾個參數，就要加幾個引數
        //有預設值可以不用寫 跟換值直接打要換的值
        //有多個參數可使用指名的方式 參數名稱:值
        //發射電球 速度100 音效滋滋滋 爆炸
        Shoot("電球", 100, effect: "爆炸");
        Shoot("火球", 150, "蹦蹦蹦");
        Shoot("冰球", 70);
        Shoot("光球", 200);
        int Water3 = BuyWater(3);
        print("買三灌" + Water3);
        float test= BMI (60,1.6f);
        print("test BMI" + test);
        float me = BMI(60, 1.68f);
        print("me BMI" + test);
    }


    //自訂方法:不會自動執行
    //會自動執行的叫事件
    private void Test()
    {
        print("測試");

    }

    private void Shootfire()
    {
        print("發射火球");
        print("發射速度100");
        print("發射音效");


    }
    private void ShootIce()
    {
        print("發射冰球");
        print("發射速度50");
        print("發射音效");


    }
    //維護與擴充方法
    //參數語法:參數1類型 參數1名稱,參數2類型 參數2名稱
    //預設值語法:參數類型 參數名稱= 預設值
    private void Shoot(string type, int speed, string sound = "滋滋滋", string effect = "爆炸")
    {
        print("<color=Red>發射" + type + "</color>");
        print("<color=0000FF>發射速度" + speed + "</color>");
        print("<color=yellow>發射音效" + sound + "</color>");
        print("<color=yellow>發射特效" + effect + "</color>");
    }
    //一罐藥水100
    private int BuyWater(int count)
    {
        int price = count * 100;
        return price;
    }

    private float BMI(float weight, float height)
    {
        float result = weight / (height * height);
        return result;
     
    }

   
}
