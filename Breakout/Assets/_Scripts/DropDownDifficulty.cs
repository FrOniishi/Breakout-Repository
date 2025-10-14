using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownDifficulty : MonoBehaviour
{
    public Options options;
    private TMP_Dropdown difficulty;

    void Awake()
    {
        difficulty = GetComponent<TMP_Dropdown>();
    }

    void Start()
    {
        if (difficulty == null || options == null)
        {
            Debug.LogError("Dropdown o Options no asignado.");
            return;
        }

        // Opcional: asegurarse de que el dropdown tenga las opciones correctas
        difficulty.ClearOptions();
        difficulty.AddOptions(new System.Collections.Generic.List<string> { "Fácil", "Media", "Difícil" });

        // Escuchar cambios
        difficulty.onValueChanged.AddListener(OnDifficultyChanged);

        // Inicializar con el valor actual
        difficulty.value = (int)options.LevelDifficulty;
    }

    void OnDifficultyChanged(int index)
    {
        options.SetDifficulty(index);
        Debug.Log($"Dificultad cambiada a: {options.LevelDifficulty}");
    }

}
