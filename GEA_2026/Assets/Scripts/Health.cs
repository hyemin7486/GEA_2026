using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;

    [Header("플레이어 연결")]
    public Slider hpSlider;                //플레이어만 연결

    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;
        currentHp -= damage;

        Debug.Log(name + " HP: " + currentHp);
        UpdateBar();

        if (currentHp <= 0) Die();
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            Debug.Log("게임 오버");
            Time.timeScale = 0f; 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void UpdateBar()
    {
        Debug.Log(name + "Current HP: " + currentHp + " / Max HP : " + maxHp);

        if (hpSlider != null)  //플레이어만 붙였으니까. 플레이어에서만 작동되는 분기
            hpSlider.value = (float)currentHp / maxHp;
    }
    void Update()
    {
        
    }
}
