using UnityEngine;

namespace LP
{
    /// <summary>
    /// 生成敵人系統
    /// </summary>
    /// 預設執行順序：數字越大越慢執行
    [DefaultExecutionOrder(200)]
    public class SpawnEnmySystem : MonoBehaviour
    {
        [SerializeField, Header("生成時間範圍")]
        private Vector2 rangeSpawn = new Vector2(0.5f, 1.5f);

        private GameObject tempEnemy;

        private void Start()
        {
            SpawnEnemy();
        }
        /// <summary>
        ///  生成敵人
        /// </summary>
        private void SpawnEnemy()
        {
            tempEnemy = ObjectPoolEnemy.instance.GetPoolObject();
            tempEnemy.transform.position = transform.position;
            tempEnemy.GetComponent<EnemyHealth>().onDead = EnemyRelease;
        }
        /// <summary>
        /// 回收敵人物件
        /// </summary>
        private void EnemyRelease()
        {
            ObjectPoolEnemy.instance.ReleasePoolObject(tempEnemy);
            //延遲呼叫("生成敵人",隨機秒數);
            Invoke("SpawnEnemy", Random.Range(rangeSpawn.x, rangeSpawn.y));
        }
    }

}
