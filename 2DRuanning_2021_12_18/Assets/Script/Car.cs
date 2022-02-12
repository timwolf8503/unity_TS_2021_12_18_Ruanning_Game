using UnityEngine;  //引用Unity引擎空間

//類別    類別名必須與檔案名稱一致大小寫也要一樣
public class Car : MonoBehaviour
{
    #region 欄位  Field

    //*欄位語法
    //修飾詞  資料種類  欄位名稱  (指定  預設值)  尾語
    //*四大常用資料類型
    //整  數 int
    //浮點數   float
    //字  串  string
    //布林值   bool
    //*修飾詞
    //*修飾詞
    //私人:不給外部類別存取，預設，不顯示，private
    //公開:允許外部類別存取，顯示，public
    public  int cc   =2000;
    public  float weight=3.5f;    //尾語要加  f 或 F
    public  string brand="BMW";   //必須""包覆
    public  bool haswindow=true;  //只可填true或false
    //*Unity常用的資料類別
    //color
    public  Color   color;
    public Color red = Color.red;
    public Color blue = Color.blue;
    //*製自顏色
    //public color  名稱=new(小寫)  color(Rf,Gf,Bf,Af);   最大值都是1
    public Color colerA =new Color(0.5f, 0, 0.5f);
    public Color colorB = new Color(0, 0.5f, 0.5f, 0.5f);
    //向量 Vector 2~4 2維到4維
    public Vector2 vector2;
    public Vector2 Vector2 = Vector2.right;
    public Vector2 v2up = Vector2.up;
    public Vector2 v2one = Vector2.one;
    public Vector2 vector2A = new Vector2(0.1f, 0.5f);

    //輸入按鍵  KeyCode
    public KeyCode KeyCode;
    public KeyCode jump = KeyCode.Space;
    public KeyCode forwad = KeyCode.D;
    public KeyCode left= KeyCode.A;

    //遊戲物件(Hierearchy 內白色線條圖示)，預置物 Prefad
    public GameObject gogame;
    public GameObject gogamrea;

    //元件    Component
    //可以儲存屬性面板上所有粗體字元件
    //*有空格要去掉
    public Transform tra1;
    public Camera cam;
    public SpriteRenderer sr;


     #endregion
}

//非汽車類別資料