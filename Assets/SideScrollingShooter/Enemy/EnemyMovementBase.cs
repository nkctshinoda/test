using UnityEngine;

/*
 * �N���X���̏Փ˂Ȃǂ�h������namespace���g��
 * �h���N���X��override���郁�\�b�h��virtual�L�[���[�h�����ĉ��z���\�b�h�ɂ��Ă���
 * private�ɂ��ׂ����\�b�h��h���N���X����ł��A�N�Z�X�ł���悤��protected�ɂ��Ă���
 * Move���\�b�h�͒��ۃN���X�Ƃ��h���N���X�Ŏ�������
 */

namespace SSShooter
{
    /// <summary>
    /// �G�̈ړ��R���|�[�l���g�̊��N���X
    /// </summary>
    public abstract class EnemyMovementBase : MonoBehaviour
    {
        protected float speed;          //���x
        protected Vector2 direction;    //����

        /// <summary>
        /// ���������\�b�h
        /// </summary>
        /// <param name="spd">���x</param>
        /// <param name="dir">����</param>

        protected virtual void Initialize(float spd, Vector2 dir)
        {
            speed = spd;
            direction = dir;
        }

        /// <summary>
        /// �ړ����\�b�h�i���ۃ��\�b�h�j
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// �I�[�o�[���C�h�\��Start
        /// </summary>
        protected virtual void Start()
        {
            Initialize(0f, Vector2.zero);
        }

        /// <summary>
        /// �I�[�o�[���C�h�\��Update
        /// </summary>
        protected virtual void Update()
        {
            Move();
        }
    }
}