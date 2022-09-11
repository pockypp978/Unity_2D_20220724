using LP;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("敵人資料")]
    private EnemyData enemyData;

    private Rigidbody2D rig;



    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = enemyData.checkGroundColor;
        Gizmos.DrawCube(transform.position + enemyData.checkGroundOffset, enemyData.checkGroundSize);

    }

    private void Update()
    {
        Wander();
        CheckGroundForward();
    }
    /// <summary>
    /// 遊走功能
    /// </summary>
    private void Wander()
    {
        rig.velocity = new Vector2(-enemyData.speed, rig.velocity.y);
    }
    /// <summary>
    /// 偵測前方是否有地板
    /// </summary>
    private void CheckGroundForward()
    {
        Collider2D hit = Physics2D.OverlapBox(
            transform.position + enemyData.checkGroundOffset,
            enemyData.checkGroundSize, 0, enemyData.checkGroundLayer);
        print("前方碰撞物件" + hit.gameObject);
    }
}
