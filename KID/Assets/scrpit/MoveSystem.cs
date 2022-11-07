using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            //transform �������� transform ����
            //Translate(x,y,z) �첾
            // * ���k
            // Time.deltaTime �C�s���ɶ�
            transform.Translate(speed* Time.deltaTime, 0, 0);
        }
    }
}
