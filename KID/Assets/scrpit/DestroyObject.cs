using UnityEngine;

namespace KID
{
    /// <summary>
    ///  �R������
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            // gameObject ���}�����C������
            // �R��(����A�R���ɶ�)
            Destroy(gameObject, destroyTime);
        }

        // �i���ƥ�G���V���� (Randerer) �X�{�b Scence �� Game �ɰ���@��
        private void OnBecameVisible()
        {

        }

        // �i���ƥ�G���V���� (Randerer) �����b Scence �� Game �ɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

    }
}
