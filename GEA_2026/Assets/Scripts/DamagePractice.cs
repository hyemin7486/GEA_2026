using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack = 12;
    public int defense = 5;
    public bool isCritical = true;
    public bool targetIsBoos = true;

    [ContextMenu("데미지")]
    void Calc()
    {
        int damage = attack - defense;

        if (damage < 1)
            damage = 1;

        if (isCritical)
        {
            damage = damage * 2;
        }
        if (targetIsBoos)
        {
            damage = damage / 2;
        }
        Debug.Log(damage);

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
