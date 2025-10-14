using UnityEngine;
using UnityEngine.UI;

public class DropDownDifficulty : MonoBehaviour
{
    public Options options;
    private Dropdown difficulty;

    private void Start()
    {
        difficulty = GetComponent<Dropdown>();
        difficulty.onValueChanged.AddListener(delegate { options.SetDifficulty(difficulty.value); });
    }
}
