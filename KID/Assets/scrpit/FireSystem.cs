using UnityEngine;

namespace KID
{
    /// <summary>
    /// �o�g�t��
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("�l�u���m��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        //�ۭq��k
        //�ͦ��l�u
        protected void SpawnBullet()
        {
            // ��O��(�ͦ�����,�y�СA����)
            // �ͦ� �l�u���m�� �y�лP���׸�ͦ��I�ۦP
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }
    }
}
