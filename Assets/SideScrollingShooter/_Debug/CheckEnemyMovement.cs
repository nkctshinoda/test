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
            // 定義されているクラスを格納するリスト
            List<Type> definedClasses = new List<Type>();

            // E01 から E40 までのクラス名
            string[] classNames = Enumerable.Range(1, 40)
                .Select(i => $"SSShooter.E{i:D2}")
                .ToArray();

            // 各クラス名について、定義されているか確認
            foreach (string className in classNames)
            {
                Type type = Type.GetType(className);

                // クラスが定義されていて、EnemyMovementBase を継承している場合
                if (type != null && type.IsSubclassOf(typeof(EnemyMovementBase)))
                {
                    definedClasses.Add(type);
                }
            }

            // 定義されているクラスの配列を作成
            Type[] definedClassesArray = definedClasses.ToArray();

            // 結果を表示 (または他の処理を行う)
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