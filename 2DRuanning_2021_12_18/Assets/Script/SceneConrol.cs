using UnityEngine;
using UnityEngine.SceneManagement;      //�ޥγ����޲z

/// <summary>
/// 1.�i�H�}�l�C��
/// 2.�i�H���}�C��
/// </summary>


public class SceneConrol : MonoBehaviour
{
    
    /// <summary>
    /// �}�l�C��
    /// </summary>
    public void LoadSence()
    {

        SceneManager.LoadScene("���d 1");

    }

    //Unity���}�C��
    //1.���}����k
    //2.Button���� on cick �i�H���w����k
   /// <summary>
   /// ���}�C��
   /// </summary>
    public void QuitGame()
    {
        print("���}�C��");
        Application.Quit();     //���ε{�����}

    }




}
