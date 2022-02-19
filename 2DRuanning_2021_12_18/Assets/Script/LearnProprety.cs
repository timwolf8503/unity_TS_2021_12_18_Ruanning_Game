using UnityEngine;
/// <summary>
/// 學習屬性    Property
/// </summary>
public class LearnProprety : MonoBehaviour
#region 屬性

//屬性語法
//修飾詞  資料種類 屬性名稱{存取子}
//快速完成  prop    +TAb*2
//get取得
//set存放
{

    public int l1 { get; set; }
    public int test1 {get; set; }

    //唯獨屬性把set刪掉 無法指定
    //唯獨屬性給與值的方法: {  get +   =>值;}

    public string passwordProprety { get => "123456789"; }
    public int password1{ get    =>8888; }
  

    //欄位屬性(對照存取)
    public string passwordField;

    private void Start()
    {
        //存放屬性set
    
        l1 = 100;
        test1 = 200;
        //取得get
        print("等級" + l1);
        print("測試"+test1);

        passwordField = "123456";
        print("取得欄位密碼" + passwordField);

        //passwordProprety="123456";
        print("取得屬性密碼" + passwordProprety);
        print(password1);

#endregion

    }

}
