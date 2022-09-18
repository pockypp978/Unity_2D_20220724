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


    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
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
            rig.velocity = Vector2.zero;
            ani.SetBool(parWalk, false);
        }
    }
}
