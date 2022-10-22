using UnityEngine;

namespace LP
{
    /// <summary>
    /// �ͦ��ĤH�t��
    /// </summary>
    /// �w�]���涶�ǡG�Ʀr�V�j�V�C����
    [DefaultExecutionOrder(200)]
    public class SpawnEnmySystem : MonoBehaviour
    {
        [SerializeField, Header("�ͦ��ɶ��d��")]
        private Vector2 rangeSpawn = new Vector2(0.5f, 1.5f);

        private GameObject tempEnemy;

        private void Start()
        {
            SpawnEnemy();
        }
        /// <summary>
        ///  �ͦ��ĤH
        /// </summary>
        private void SpawnEnemy()
        {
            tempEnemy = ObjectPoolEnemy.instance.GetPoolObject();
            tempEnemy.transform.position = transform.position;
            tempEnemy.GetComponent<EnemyHealth>().onDead = EnemyRelease;
        }
        /// <summary>
        /// �^���ĤH����
        /// </summary>
        private void EnemyRelease()
        {
            ObjectPoolEnemy.instance.ReleasePoolObject(tempEnemy);
            //����I�s("�ͦ��ĤH",�H�����);
            Invoke("SpawnEnemy", Random.Range(rangeSpawn.x, rangeSpawn.y));
        }
    }

}
