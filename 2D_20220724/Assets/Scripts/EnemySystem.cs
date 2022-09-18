using LP;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("敵人資料")]
    private EnemyData enemyData;

    private Rigidbody2D rig;
    private bool isGroundForward;
    private Animator ani;
    private string parWalk = "走路開關";
    private bool lookAttackTarget;
    private Transform traAttackTarget;
    private EnemyAttack enemyAttack;

    [SerializeField, Header("動畫控制器攻擊動畫名稱")]
    private string nameAnimationAttack = "敵人_attack";


    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        enemyAttack = GetComponent<EnemyAttack>();
    }
    private void OnDrawGizmos()
    {
		#region 檢查地板
		Gizmos.color = enemyData.checkGroundColor;
        Gizmos.DrawCube(transform.position + transform.TransformDirection( enemyData.checkGroundOffset), enemyData.checkGroundSize);
        #endregion
        #region 檢查目標
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
    /// 遊走功能
    /// </summary>
    private void Wander()
    {
        if (lookAttackTarget) return;
        rig.velocity = transform.right * new Vector2(-enemyData.speed, rig.velocity.y);

        ani.SetBool(parWalk, rig.velocity.x != 0);
    }
    /// <summary>
    /// 偵測前方是否有地板
    /// </summary>
    private void CheckGroundForward()
    {
        Collider2D hit = Physics2D.OverlapBox(
            transform.position + transform.TransformDirection( enemyData.checkGroundOffset),
            enemyData.checkGroundSize, 0, enemyData.checkGroundLayer);
        isGroundForward = hit;
    }

    /// <summary>
    /// 偵測前方是否有攻擊目標
    /// </summary>
    private void CheckAttackTarget()
    {
        Collider2D hit = Physics2D.OverlapBox(
            transform.position + transform.TransformDirection(enemyData.checkTargetOffset),
            enemyData.checkTargetSize, 0, enemyData.checkTargetLayer);
        //print("前方碰撞玩家" + hit.gameObject);

        lookAttackTarget = hit;
        if (hit) traAttackTarget = hit.transform;//如果碰到物件就儲存變形元件
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
            //如果 目前動畫名稱 為 敵人_atack 就跳出
            if (ani.GetCurrentAnimatorStateInfo(0).IsName(nameAnimationAttack)) return;

            if (dis > enemyData.attackRange)
            {
                rig.velocity = 2*transform.right * new Vector2(-enemyData.speed, rig.velocity.y);
            }
            else 
            {
                Attack();
            }
            ani.SetBool(parWalk, rig.velocity.x != 0);
        }
    }
    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack() 
    {
        rig.velocity = Vector2.zero;
        enemyAttack.StartAttack();
    }
}
