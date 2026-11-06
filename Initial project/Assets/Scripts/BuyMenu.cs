using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class BuyMenu : MonoBehaviour
{

    public GameObject canvas;
    public GameObject[] turretPrefabs;

    private int turretLvl;
    public TextMeshProUGUI buttonText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (canvas.activeSelf)
            {
                canvas.SetActive(false);
                Time.timeScale = 1.0f;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            else
            {
                canvas.SetActive(true);
                Time.timeScale = 0;

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

            }
        }
    }

    public void BuyTurret()
    {
        for (int i = 0; i < turretPrefabs.Length; i++)
        {
            if (i == turretLvl)
            {
                turretPrefabs[i].SetActive(true);
            }
            else
            {
                turretPrefabs[i].SetActive(false);
            }
        }
        
        

        
    }
}
