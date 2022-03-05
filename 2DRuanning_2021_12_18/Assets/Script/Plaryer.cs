using UnityEngine;
/// <summary>
/// ��V���b���a���]�ŹC���t��
/// </summary>
public class Plaryer : MonoBehaviour
{
    #region ���


    //�]�B�t�סA���D���סA�O�_�Ʀ�A�O�_���`
    //�ʵe�ѼƸ��D�A�Ʀ�P���`
    //Header����
    //Renge�d��,�u�i�H�μƭ�������Ʀp: float int

    [Header("�]�B�t��"),Range(0,500)]
    public float speed = 1.5f;
    [Header("���D����"),Range(0,5000)]
    public int jump = 500;
    [Header("�O�_�Ʀ�")]
    public bool isSlide;
    [Header("�O�_�Ʀ�")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterisSlide = "�}���Ʀ�";
    public string parameterisDead = "Ĳ�o���`";


    [Header("���D����")]
    public  KeyCode KeyJump= KeyCode.Space;

    [Header("���D�q�Ƴ̤j��"),Range(0,5)]
    public int countJumpMax = 2;

    public int countJump;

    [Header("�����a�O�첾")]
    public Vector3 v3Groundoffset;

    [Header("�a�O�j�p")]
    public Vector3 v3GroungSize= Vector3.one;

    [Header("�a�O�ϼh")]
    public LayerMask LayerGround;

    private Animator ani;

    [Header("�Ʀ���s")]
    public KeyCode KeySlide = KeyCode.DownArrow;


    private CapsuleCollider2D cc2d;
    //�s��Transform�Ĥ@�ؤ覡
    //public Transform traPlayer;


    //�ݩʭ��O...Debug�Ҧ��i�H�ݨ�p�H���
    private Rigidbody2D rig;



    #endregion





    #region �ƥ�
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f, 0f, 0.5f, 0.5f);
        Gizmos.DrawCube(transform.position+v3Groundoffset, v3GroungSize);
    }

    private void Start()
    {

        // GetComponent<��������>();        �Ҧ�����
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



    #region ��k
    /// <summary>
    /// �]�B
    /// </summary>
    private void Run()
    {


        //�s��Transform�Ĥ@�ؤ覡
        //Time.delatTime �@�V���ɶ�
        //traPlayer.Translate(speed*Time.deltaTime,0,0);         //���a�ܧ� �첾(X,Y,Z)


        //�s��Transform�ĤG�ؤ覡
        //transform.�W��;
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
       bool intJump= Input.GetKeyDown(KeyJump);
        //print("�O�_���D" + intJump);

    

        //�p�G���U����    �åB���D�q�Ƥj�� 0 ���W��
        if (intJump && countJump > 0)
        {
            // print("���D");
            //����K�[���O
            rig.AddForce(new Vector2(0, jump));
            countJump--;

            ani.SetTrigger(parameterJump);
        }

            Collider2D hit = Physics2D.OverlapBox(transform.position + v3Groundoffset, v3GroungSize, 0, LayerGround);
        //print(hit.name);
        print("���a���O�a�t��" + rig.velocity);
        if (hit && rig.velocity.y < 0)
        {
            countJump = countJumpMax;
        }
    }

    /// <summary>
    /// �Ʀ�
    /// </summary>
    private void Silde()
    {
        if (Input.GetKey(KeySlide))
        {
            ani.SetBool(parameterisSlide,true);

            cc2d.offset = new Vector2(0.5f, -1f);
            cc2d.size = new Vector2(2f, 1.5f);
            cc2d.direction = CapsuleDirection2D.Horizontal;

            //�Ʀ� 0.5 -1 | 2  1.5  Horizontal
        }

        else
        {
            ani.SetBool(parameterisSlide, false);

            cc2d.offset = new Vector2(0.5f, -0.3f);
            cc2d.size = new Vector2(1.5f, 3f);
            cc2d.direction = CapsuleDirection2D.Vertical;


            //���� 0.5 -0.3 | 1.5 3 Vertical 

        }
    }




    
    #endregion

}
