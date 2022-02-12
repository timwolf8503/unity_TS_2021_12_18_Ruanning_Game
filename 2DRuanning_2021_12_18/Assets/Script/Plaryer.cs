using UnityEngine;
/// <summary>
/// 橫向卷軸玩家的跑褲遊戲系統
/// </summary>
public class Plaryer : MonoBehaviour
{

    //跑步速度，跳躍高度，是否滑行，是否死亡
    //動畫參數跳躍，滑行與死亡
    //Header註解
    //Renge範圍,只可以用數值類型資料如: float int

    [Header("跑步速度"),Range(0,500)]
    public float speed = 1.5f;
    [Header("跳躍高度"),Range(0,5000)]
    public int Jump = 500;
    [Header("是否滑行")]
    public bool isSlide;
    [Header("是否滑行")]
    public bool isDead;

    public string parameterJump = "觸發跳躍";
    public string parameterisSlide = "開關滑行";
    public string parameterisDead = "觸發死亡";


}
