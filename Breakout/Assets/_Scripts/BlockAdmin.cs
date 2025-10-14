using UnityEngine;

public class BlockAdmin : MonoBehaviour
{
    public GameObject EndLevelMenu;

    private void Update()
    {
        if (transform.childCount == 0)
        {
            Time.timeScale = 0;
            EndLevelMenu.SetActive(true);
        }
    }
}
