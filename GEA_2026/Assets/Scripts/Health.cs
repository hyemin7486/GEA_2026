using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;

    public static int killCount;

    [Header("플레이어 연결")]
    public Slider hpSlider;                //플레이어만 연결

    public float invincibleTime = 0f;
    float lastHitTime = -999f;
    public GameObject dropPrefab;    //죽었을때 떨구는 아이템
    public float dropChance = 0.3f;   //30%
    public GameObject hitEffect;

    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;
        if (Time.time < lastHitTime + invincibleTime) return;
        lastHitTime = Time.time;


        currentHp -= damage;
        Debug.Log(name + " HP: " + currentHp);
        UpdateBar();
        Vector3 hitPos = transform.position + Vector3.up;
        if (hitEffect != null)
            Instantiate(hitEffect, hitPos, Quaternion.identity);

        if (currentHp <= 0) Die();
        else Blink();
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            killCount++;
            Destroy(gameObject);
            
            if (dropPrefab != null && Random.value < dropChance)
            {
                Vector3 pos = transform.position + Vector3.up * 0.5f;
                Instantiate(dropPrefab, pos, Quaternion.identity);
            }

        }
    }
    
    void UpdateBar()
    {
        Debug.Log(name + "Current HP: " + currentHp + " / Max HP : " + maxHp);

        if (hpSlider != null)  //플레이어만 붙였으니까. 플레이어에서만 작동되는 분기
            hpSlider.value = (float)currentHp / maxHp;
    }
    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        UpdateBar();
    }

    void Blink()
    {
        SetVisible(false);
        Invoke(nameof(ShowAgain), 0.1f);
    }
    void ShowAgain()
    {
        SetVisible(true);
    }
    void SetVisible(bool on)
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
            r.enabled = on;
    }
}
