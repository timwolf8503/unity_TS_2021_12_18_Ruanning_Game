using UnityEngine;  //�ޥ�Unity�����Ŷ�

//���O    ���O�W�����P�ɮצW�٤@�P�j�p�g�]�n�@��
public class Car : MonoBehaviour
{
    #region ���  Field

    //*���y�k
    //�׹���  ��ƺ���  ���W��  (���w  �w�]��)  ���y
    //*�|�j�`�θ������
    //��  �� int
    //�B�I��   float
    //�r  ��  string
    //���L��   bool
    //*�׹���
    //*�׹���
    //�p�H:�����~�����O�s���A�w�]�A����ܡAprivate
    //���}:���\�~�����O�s���A��ܡApublic
    public  int cc   =2000;
    public  float weight=3.5f;    //���y�n�[  f �� F
    public  string brand="BMW";   //����""�]��
    public  bool haswindow=true;  //�u�i��true��false
    //*Unity�`�Ϊ�������O
    //color
    public  Color   color;
    public Color red = Color.red;
    public Color blue = Color.blue;
    //*�s���C��
    //public color  �W��=new(�p�g)  color(Rf,Gf,Bf,Af);   �̤j�ȳ��O1
    public Color colerA =new Color(0.5f, 0, 0.5f);
    public Color colorB = new Color(0, 0.5f, 0.5f, 0.5f);
    //�V�q Vector 2~4 2����4��
    public Vector2 vector2;
    public Vector2 Vector2 = Vector2.right;
    public Vector2 v2up = Vector2.up;
    public Vector2 v2one = Vector2.one;
    public Vector2 vector2A = new Vector2(0.1f, 0.5f);

    //��J����  KeyCode
    public KeyCode KeyCode;
    public KeyCode jump = KeyCode.Space;
    public KeyCode forwad = KeyCode.D;
    public KeyCode left= KeyCode.A;

    //�C������(Hierearchy ���զ�u���ϥ�)�A�w�m�� Prefad
    public GameObject gogame;
    public GameObject gogamrea;

    //����    Component
    //�i�H�x�s�ݩʭ��O�W�Ҧ�����r����
    //*���Ů�n�h��
    public Transform tra1;
    public Camera cam;
    public SpriteRenderer sr;


     #endregion
}

//�D�T�����O���