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

    [Header("跳躍段數最大值"),Range(0,5)]
    public int countJumpMax = 2;

    public int countJump;

    [Header("偵測地板位移")]
    public Vector3 v3Groundoffset;

    [Header("地板大小")]
    public Vector3 v3GroungSize= Vector3.one;

    [Header("地板圖層")]
    public LayerMask LayerGround;

    private Animator ani;

    [Header("滑行按鈕")]
    public KeyCode KeySlide = KeyCode.DownArrow;


    private CapsuleCollider2D cc2d;
    //存取Transform第一種方式
    //public Transform traPlayer;


    //屬性面板...Debug模式可以看到私人資料
    private Rigidbody2D rig;



    #endregion





    #region 事件
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f, 0f, 0.5f, 0.5f);
        Gizmos.DrawCube(transform.position+v3Groundoffset, v3GroungSize);
    }

    private void Start()
    {

        // GetComponent<元件類型>();        所有元件
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        cc2d = GetComponent<CapsuleCollider2D>();
        countJump = countJumpMax;

       
    }




    private void Update()
    {
        Run();
        Jump();
        Silde();
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
        if (intJump && countJump > 0)
        {
            // print("跳躍");
            //鋼體添加推力
            rig.AddForce(new Vector2(0, jump));
            countJump--;

            ani.SetTrigger(parameterJump);
        }

            Collider2D hit = Physics2D.OverlapBox(transform.position + v3Groundoffset, v3GroungSize, 0, LayerGround);
        //print(hit.name);
        print("玩家重力家速度" + rig.velocity);
        if (hit && rig.velocity.y < 0)
        {
            countJump = countJumpMax;
        }
    }

    /// <summary>
    /// 滑行
    /// </summary>
    private void Silde()
    {
        if (Input.GetKey(KeySlide))
        {
            ani.SetBool(parameterisSlide,true);

            cc2d.offset = new Vector2(0.5f, -1f);
            cc2d.size = new Vector2(2f, 1.5f);
            cc2d.direction = CapsuleDirection2D.Horizontal;

            //滑行 0.5 -1 | 2  1.5  Horizontal
        }

        else
        {
            ani.SetBool(parameterisSlide, false);

            cc2d.offset = new Vector2(0.5f, -0.3f);
            cc2d.size = new Vector2(1.5f, 3f);
            cc2d.direction = CapsuleDirection2D.Vertical;


            //站立 0.5 -0.3 | 1.5 3 Vertical 

        }
    }




    
    #endregion

}
