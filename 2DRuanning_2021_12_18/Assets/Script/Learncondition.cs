using System.Net;
using UnityEngine;
using UnityEngine.PlayerLoop;

/// <summary>
/// �ǲߧP�_��
/// 1.if
/// 2.switch
/// </summary>

public class Learncondition : MonoBehaviour
{
    //�P�_���y�kif(���L��){�{���A�t��k�A���z��}
    //�ֳt���� if  +   tad*2
    //if(true)����{}���{��
    //if(false)������{}���{��



    public bool haskey = false;
    public int combo = 0;
    public string weapon;


    //�C�|public  enum �W��{���W��}
    //1.�s�@�C�|(�U�Կ��)
    public enum Season
    {
        spring, summer, fall, winter
    }

    //2.��@�C�|
    public Season season;

    private void Start()
    {
        #region if�P�_��


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

            #endregion
        }
            #region switch�P�_��



            //swith�y�k()
            //{
            //  case    ��1:
            //            �{�����e;
            //            �{�����e;
            //            �{�����e;
            //            �{�����e;
            //          �_�}break;
            //  default
            //            �{�����e;
            //            �{�����e;
            //            �{�����e;
            //            �{�����e;
            //          �_�}break;
            //}
            switch (weapon)
            {
                case "�p�M":
                    print("�����O10");
                    break;
                case "�}�b":
                    print("�����O100");
                    break;
                case "��j":
                    print("�����O200");
                    break;
                default:
                    print("�S���Z��");
                    break;
            }
            #endregion


            //swith +   enum
            switch (season)
            {
                case Season.spring:
                    print("�K��");
                    break;
                case Season.summer:
                    print("�L��");
                    break;
                case Season.fall:
                    print("���");
                    break;
                case Season.winter:
                    print("�V��");
                    break;

            }


       

        //����i��覡
        //else  if(���L��){�{���A�t��k�A���z��}
        //�����g�bif�U��
        //�ƶq�S������





    }

    private void Update()
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