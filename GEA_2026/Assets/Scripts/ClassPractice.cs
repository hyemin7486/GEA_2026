using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    [ContextMenu("클래스 실습")]
    void ShowWeapon()
    {
        Weapon sword = new Weapon("낡은 검", 2);
        for (int i = 0; i < 3; i++)
        {
            if (sword.Use())
            {
                Debug.Log(sword.name + " 사용, 남은 내구도 " + sword.durability);
            }
            else
            {
                Debug.Log(sword.name + " 부서짐");
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
