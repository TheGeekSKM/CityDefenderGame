using TMPro;
using UnityEngine;

public class CityController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] public float maxHealth = 100f;
    [SerializeField] public float currentHealth;

    [Header("References")]
    [SerializeField] TextMeshProUGUI healthText;

    private void Start()
    {
        currentHealth = maxHealth;
        healthText.text = currentHealth.ToString();
    }

    void Update()
    {
        healthText.text = currentHealth.ToString();
    }
}
