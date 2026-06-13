using UnityEngine;
using TMPro;
public class Cash_manager : MonoBehaviour
{

    public float cash = 100f;
    public TextMeshProUGUI cash_text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cash_text.text = "cash: " + cash.ToString();
        
    }
}
