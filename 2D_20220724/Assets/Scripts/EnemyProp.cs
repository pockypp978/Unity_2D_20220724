using UnityEngine;
namespace LP
{
    /// <summary>
    /// �ĤH�D��:�Q�ؼиI���^���쪫�����
    /// </summary>
    public class EnemyProp : MonoBehaviour
    {
        [SerializeField, Header("�ؼЪ���W��")]
        private string nameTarget = "Knight";

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains(nameTarget))
            {
                ObjectPoolEnemyProp.instance.ReleasePoolObject(gameObject);
            }
        }


    }

}
