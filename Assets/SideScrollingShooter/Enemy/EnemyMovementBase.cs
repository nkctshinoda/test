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
    /// �ړ��R���|�[�l���g�̊��N���X
    /// </summary>
    public abstract class EnemyMovementBase : MonoBehaviour
    {
        private float speed;
        private Vector2 directon;

        protected virtual void Initialize(float spd,Vector2 dir)
        {
            speed = spd;
            directon = dir;
        }

        public abstract void Move();

        protected virtual void Update()
        {
            Move();
        }
    }
}