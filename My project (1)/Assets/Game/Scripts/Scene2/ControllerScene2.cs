using UnityEngine;

public class ControllerScene2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowGlobalTime();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowGlobalTime()
    {
        Debug.Log("Tiempo total: " + GameManager.Instance.GlobalTime);
    }
}
