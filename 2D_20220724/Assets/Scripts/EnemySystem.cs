using LP;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("�ĤH���")]
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
    }
    /// <summary>
    /// �C���\��
    /// </summary>
    private void Wander()
    {
        rig.velocity = new Vector2(-enemyData.speed, rig.velocity.y);
    }
}
