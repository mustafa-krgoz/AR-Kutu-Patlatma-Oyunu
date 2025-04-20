using UnityEngine;
using TMPro; // <-- Text yerine TMP

public class FoodStepController : MonoBehaviour
{
    public string[] correctOrder = { "Toast", "Egg", "Tomato", "Drink_01" };
    private int currentStep = 0;

    public AudioClip correctSound;
    public AudioClip wrongSound;
    public AudioSource audioSource;

    public TextMeshProUGUI feedbackText;// TMP ile uyumlu hale getirildi
    public GameObject winPanel;

    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
#else
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
#endif
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObj = hit.collider.gameObject;
                string objName = clickedObj.name;

                if (objName == correctOrder[currentStep])
                {
                    Debug.Log("✅ Doğru: " + objName);
                    feedbackText.text = "✅ Doğru! " + objName;
                    audioSource.PlayOneShot(correctSound);
                    Highlight(clickedObj);

                    currentStep++;

                    if (currentStep == correctOrder.Length)
                    {
                        Debug.Log("🎉 Tüm adımlar tamamlandı!");
                        feedbackText.text = "🎉 Tebrikler! Kahvaltı hazır!";
                        winPanel.SetActive(true);
                    }
                }
                else
                {
                    Debug.Log("❌ Yanlış: " + objName);
                    feedbackText.text = "❌ Bu sırada " + correctOrder[currentStep] + " olmalıydı.";
                    audioSource.PlayOneShot(wrongSound);
                    Shake(clickedObj);
                }
            }
        }
    }

    void Highlight(GameObject obj)
    {
        obj.transform.localScale *= 1.1f;
    }

    void Shake(GameObject obj)
    {
        obj.transform.Rotate(Vector3.up * 15f);
    }
}