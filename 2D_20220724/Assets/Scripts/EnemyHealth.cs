using UnityEngine;

namespace LP
{
    /// <summary>
    /// ��q�t��
    /// </summary>
    public class EnemyHealth : HealthSystem
    {
        protected override void Dead()
        {
            base.Dead();

            DropProp();

            gameObject.layer = 9;
        }

        private void DropProp()
        {
            float probability = Random.value;

            print("�������v" + probability);
            DataHealthEnemy dataEnemy = (DataHealthEnemy)dataHealth;
            if (probability <= dataEnemy.dropProbility)
            {
                Vector3 pos = transform.position + Vector3.up * 1.5f;
                Instantiate(dataEnemy.prefabProp, pos, Quaternion.identity);
            }
        }
    }
}

