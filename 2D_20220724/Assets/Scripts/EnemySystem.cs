using LP;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("�ĤH���")]
    private EnemyData enemyData;

    private Rigidbody2D rig;
    private bool isGroundForward;
    private Animator ani;
    private string parWalk = "�����}��";
    private bool lookAttackTarget;
    private Transform traAttackTarget;


    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void OnDrawGizmos()
    {
		#region �ˬd�a�O
		Gizmos.color = enemyData.checkGroundColor;
        Gizmos.DrawCube(transform.position + transform.TransformDirection( enemyData.checkGroundOffset), enemyData.checkGroundSize);
        #endregion
        #region �ˬd�ؼ�
        Gizmos.color = enemyData.checkTargetColor;
        Gizmos.DrawCube(transform.position + transform.TransformDirection(enemyData.checkTargetOffset), enemyData.checkTargetSize);
        #endregion

        Gizmos.color = enemyData.attackRangeColor;
        Gizmos.DrawLine(transform.position, transform.position + -transform.right * enemyData.attackRange);

    }

	private void Update()
    {
        Wander();
        CheckGroundForward();
        Flip();
        CheckAttackTarget();
        LookAttackTarget();
    }
    /// <summary>
    /// �C���\��
    /// </summary>
    private void Wander()
    {
        if (lookAttackTarget) return;
        rig.velocity = transform.right * new Vector2(-enemyData.speed, rig.velocity.y);

        ani.SetBool(parWalk, rig.velocity.x != 0);
    }
    /// <summary>
    /// �����e��O�_���a�O
    /// </summary>
    private void CheckGroundForward()
    {
        Collider2D hit = Physics2D.OverlapBox(
            transform.position + transform.TransformDirection( enemyData.checkGroundOffset),
            enemyData.checkGroundSize, 0, enemyData.checkGroundLayer);
        isGroundForward = hit;
    }

    /// <summary>
    /// �����e��O�_�������ؼ�
    /// </summary>
    private void CheckAttackTarget()
    {
        Collider2D hit = Physics2D.OverlapBox(
            transform.position + transform.TransformDirection(enemyData.checkTargetOffset),
            enemyData.checkTargetSize, 0, enemyData.checkTargetLayer);
        //print("�e��I�����a" + hit.gameObject);

        lookAttackTarget = hit;
        if (hit) traAttackTarget = hit.transform;//�p�G�I�쪫��N�x�s�ܧΤ���
    }

    private void Flip()
    {
        if (!isGroundForward)
        {
            float yAngle = transform.eulerAngles.y;
            transform.eulerAngles = new Vector3(0, yAngle == 0 ? 180 : 0,0);
        }
    }

    private void LookAttackTarget() 
    {
        if (lookAttackTarget) 
        {
            float dis = Vector3.Distance(transform.position, traAttackTarget.position);
            //print("�Z��" + dis);
            rig.velocity = Vector2.zero;
            ani.SetBool(parWalk, false);
            if (dis > enemyData.attackRange)
            {
                rig.velocity = 2*transform.right * new Vector2(-enemyData.speed, rig.velocity.y);
            }
            else 
            {
                rig.velocity = Vector2.zero;
            }
            ani.SetBool(parWalk, rig.velocity.x != 0);
        }
    }
}
