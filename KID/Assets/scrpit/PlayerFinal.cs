using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���a�����޲z�G���`�ιL��
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        // �Q�R���ɷ|����@��
        private void OnDestroy()
        {
            // ���`
            FinalManager.instance.GameOver("�D�ԥ��ѡI");
        }

        // �I��Ŀ� Is Trigger ����ɷ|����@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // �L��
            FinalManager.instance.GameOver("�C���q��");
        }
    }
}
