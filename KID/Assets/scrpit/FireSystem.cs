using UnityEngine;

namespace KID
{
    /// <summary>
    /// �o�g�t�ΰ����O
    /// �ͦ��l�u
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;
        [SerializeField, Header("�o�g����")]
        private AudioClip soundFire;

        // �ۭq��k
        // �ͦ��l�u
        //protected �O�@�ŧO�G���\�l�u���O�s��
        protected void SpawnBullet()
        {
            // ��Ҥ�(����B�y�СB����)
            // �ͦ� �l�u�w�s�� ���׻P�y�и�l�u�ͦ��I�ۦP
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}
