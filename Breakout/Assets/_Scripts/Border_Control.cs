using UnityEngine;

public class Border_Control : MonoBehaviour
{
    [Header("Configurar en el editor")]
    public float ratio = 1f;
    public bool keepOnScreen = false;

    [Header("Configuraciones dinámicas")]
    public bool isOnScreen = true;
    public float camWidth;
    public float camHeight;
    public bool leftBorder, rightBorder, topBorder, bottomBorder;

    public void Awake()
    {
        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Camera.main.aspect;
    }  

    void LateUpdate()
    {
        Vector3 pos = transform.position;
        isOnScreen = true;
        leftBorder = rightBorder = topBorder = bottomBorder = false;

        if (pos.x > camWidth - ratio)
        {
            pos.x = camWidth - ratio;
            rightBorder = true;
        }
        if (pos.x < -camWidth + ratio)
        {
            pos.x = -camWidth - ratio;
            leftBorder = true;
        }
        if (pos.y > camHeight - ratio)
        {
            pos.y = camHeight - ratio;
            topBorder = true;
        }
        if (pos.y < -camHeight + ratio)
        {
            pos.y = -camHeight + ratio;
            bottomBorder = true;
        }

        isOnScreen = !(leftBorder || rightBorder || topBorder || bottomBorder);
        if (keepOnScreen && !isOnScreen)
        {
            transform.position = pos;
            isOnScreen = true;
        }
    }

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;
        Vector3 boundSize = new Vector3(camWidth * 2, camHeight * 2, 0.1f);
        Gizmos.DrawWireCube(Vector3.zero, boundSize);
    }
}
