using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CityController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] public float maxHealth = 100f;
    [SerializeField] public float currentHealth;
    

    [Header("References")]
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] Slider healthSlider;

    private void Start()
    {
        currentHealth = maxHealth;
        healthText.text = currentHealth.ToString();
        healthSlider.maxValue = maxHealth;
    }

    void Update()
    {
        healthText.text = currentHealth.ToString();
        healthSlider.value = currentHealth;
        if(currentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        LevelManager.instance.GameOver();
    }

    public void DamageCity()
    {
        currentHealth -= 5f;
    }

    public void DamageCity(float num)
    {
        currentHealth -= num;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            Destroy(collision.gameObject);
            DamageCity();
        }
    }
}
