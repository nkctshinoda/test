using UnityEngine;

/*
 * �N���X���̏Փ˂Ȃǂ�h������namespace���g��
 * �h���N���X��override���郁�\�b�h��virtual�L�[���[�h�����ĉ��z���\�b�h�ɂ��Ă���
 * private�ɂ��ׂ����\�b�h��h���N���X����ł��A�N�Z�X�ł���悤��protected�ɂ��Ă���
 */

namespace SSShooter
{
    /// <summary>
    /// �G�L�����N�^�[�̊��N���X
    /// </summary>
    public class EnemyBase : MonoBehaviour
    {
        // --- ���� ---
        public int hp;                // �̗�
        public float speed;            // �ړ����x
        public int score;             // �|�������̃X�R�A

        // --- ���� ---
        // ����������
        public virtual void Initialize(int hp, float speed, int score)
        {
            this.hp = hp;
            this.speed = speed;
            this.score = score;
        }

        // ��e����
        public virtual void TakeDamage(int damage)
        {
            hp -= damage;
            if (hp <= 0)
            {
                Die();
            }
        }

        // ���S����
        protected virtual void Die()
        {
            // �X�R�A���Z�����Ȃǂ������ɋL�q
            Destroy(gameObject);
        }
    }
}
