using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace SSShooter
{
    public class CheckEnemyMovement : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // ��`����Ă���N���X���i�[���郊�X�g
            List<Type> definedClasses = new List<Type>();

            // E01 ���� E40 �܂ł̃N���X��
            string[] classNames = Enumerable.Range(1, 40)
                .Select(i => $"SSShooter.E{i:D2}")
                .ToArray();

            // �e�N���X���ɂ��āA��`����Ă��邩�m�F
            foreach (string className in classNames)
            {
                Type type = Type.GetType(className);

                // �N���X����`����Ă��āAEnemyMovementBase ���p�����Ă���ꍇ
                if (type != null && type.IsSubclassOf(typeof(EnemyMovementBase)))
                {
                    definedClasses.Add(type);
                }
            }

            // ��`����Ă���N���X�̔z����쐬
            Type[] definedClassesArray = definedClasses.ToArray();

            // ���ʂ�\�� (�܂��͑��̏������s��)
            foreach (Type type in definedClassesArray)
            {
                Debug.Log($"Defined class: {type.Name}");
            }

            gameObject.AddComponent(definedClassesArray[0]);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}