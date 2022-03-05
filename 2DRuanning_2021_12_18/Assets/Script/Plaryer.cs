using UnityEngine;
/// <summary>
/// 橫向卷軸玩家的跑酷遊戲系統
/// </summary>
public class Plaryer : MonoBehaviour
{
    #region 欄位


    //跑步速度，跳躍高度，是否滑行，是否死亡
    //動畫參數跳躍，滑行與死亡
    //Header註解
    //Renge範圍,只可以用數值類型資料如: float int

    [Header("跑步速度"),Range(0,500)]
    public float speed = 1.5f;
    [Header("跳躍高度"),Range(0,5000)]
    public int jump = 500;
    [Header("是否滑行")]
    public bool isSlide;
    [Header("是否滑行")]
    public bool isDead;

    public string parameterJump = "觸發跳躍";
    public string parameterisSlide = "開關滑行";
    public string parameterisDead = "觸發死亡";


    [Header("跳躍按鍵")]
    public  KeyCode KeyJump= KeyCode.Space;

    [Header("跳躍段數最大值"),Range(0, 5)]
    public int countjumpMax = 2;
    public int countjump;

    //存取Transform第一種方式
    //public Transform traPlayer;


    //屬性面板...Debug模式可以看到私人資料
    private Rigidbody2D rig;
    

    #endregion





    #region 事件
    private void Start()
    {

        // GetComponent<元件類型>();        所有元件
        rig = GetComponent<Rigidbody2D>();
       
    }




    private void Update()
    {
        Run();
        Jump();
    }


    #endregion



    #region 方法
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {


        //存取Transform第一種方式
        //Time.delatTime 一幀的時間
        //traPlayer.Translate(speed*Time.deltaTime,0,0);         //玩家變形 位移(X,Y,Z)


        //存取Transform第二種方式
        //transform.名稱;
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
       bool intJump= Input.GetKeyDown(KeyJump);
        //print("是否跳躍" + intJump);


        //如果按下按鍵    並且跳躍段數大於 0 往上跳
        if (intJump && countjump>0 )
        {
            // print("跳躍");
            //鋼體添加推力
            rig.AddForce(new Vector2(0, jump));
            countjump--;
        }
    }




    
    #endregion

}
