using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int maxHp = 600;
    public Slider healthSlider;

    private int currentHp;

    void Start()
    {
        currentHp = maxHp;
        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        currentHp -= amount;
        currentHp = Mathf.Max(currentHp, 0);
        UpdateUI();

        if (currentHp <= 0)
            Die();
    }

    void UpdateUI()
    {
        if (healthSlider != null)
            healthSlider.value = (float)currentHp / maxHp;
    }

    void Die()
    {
        gameObject.SetActive(false);
    }
}