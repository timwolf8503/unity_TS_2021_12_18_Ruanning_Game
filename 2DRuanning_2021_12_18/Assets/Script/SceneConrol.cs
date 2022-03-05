using UnityEngine;
using UnityEngine.SceneManagement;      //引用場景管理

/// <summary>
/// 1.可以開始遊戲
/// 2.可以離開遊戲
/// </summary>


public class SceneConrol : MonoBehaviour
{
    

    /// <summary>
    /// 延遲開始有遊戲
    /// </summary>
 public void DelayLoadScene()
    {
        //有MonoBehehaviour語法
        //方法名稱(對應引數);
        Invoke("LoadSence", 0.5f);      //延遲呼叫  (方法名稱,延遲秒數)



    }



    /// <summary>
    /// 開始遊戲
    /// </summary>
    public void LoadSence()
    {

        SceneManager.LoadScene("關卡 1");

    }







    //延遲離開遊戲
    public void DelayQuitGame()
    {
        Invoke("QuitGame", 0.5f);
    }

    //Unity離開遊戲
    //1.公開此方法
    //2.Button元件 on cick 可以指定此方法
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();     //應用程式離開  Unity裡不會執行

    }




}
