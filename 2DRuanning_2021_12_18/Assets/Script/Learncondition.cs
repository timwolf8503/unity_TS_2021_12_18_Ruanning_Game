using System.Net;
using UnityEngine;
using UnityEngine.PlayerLoop;

/// <summary>
/// �ǲߧP�_��
/// </summary>

public class Learncondition : MonoBehaviour
{
    //�P�_���y�kif(���L��){�{���A�t��k�A���z��}
    //�ֳt���� if  +   tad*2
    //if(true)����{}���{��
    //if(false)������{}���{��



    public bool haskey =false;
    public int combo = 0;


    private void Start()
    {
        if (true)
        {
            print("�ڦ��P�_��if");
        }


        //���L�Ȭ�true�|����{}
        //���L�Ȭ�false�|����else{}

        if (haskey)
        {
            print("�}��");

        }
        else
        {

            print("����}��");
        }

        //����i��覡
        //else  if(���L��){�{���A�t��k�A���z��}
        //�����g�bif�U��
        //�ƶq�S������
        
   



    }

    private  void Update() 
    {
        if (combo == 10)
        {
            print("�����[10");
        }
        else if (combo == 100)
        {
            print("�����[100");
        }
        else if (combo == 1000)
        {
            print("�����[1000");
        }



    }

}