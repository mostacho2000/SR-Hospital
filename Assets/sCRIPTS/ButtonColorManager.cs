using UnityEngine;
using UnityEngine.UI;

public class ButtonColorManager : MonoBehaviour
{
    public Button[] buttons; // Referencia a los botones
    public Color[] correctColors; // Colores correctos
    public Color[] availableColors; // Lista de colores disponibles
    private Color[] currentColors; // Colores actuales de los botones
    private int[] currentColorIndices; // Índices actuales de colores para cada botón

    [SerializeField] private GameObject objectToDestroy; // Referencia al GameObject que se debe destruir
    [SerializeField] private Image panelToHighlight; // Referencia al Panel que se debe iluminar de verde

    private void Start()
    {
        currentColors = new Color[buttons.Length];
        currentColorIndices = new int[buttons.Length];

        // Inicializa los botones con el primer color disponible
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; // Necesario para evitar problemas de captura de variable en la lambda
            buttons[i].onClick.AddListener(() => OnButtonClicked(index));
            ChangeColor(index);
        }
    }

    private void ChangeColor(int index)
    {
        // Cambia al siguiente color disponible en la lista
        currentColorIndices[index] = (currentColorIndices[index] + 1) % availableColors.Length;
        currentColors[index] = availableColors[currentColorIndices[index]];

        currentColors[index].a = 1f;
        buttons[index].GetComponent<Image>().color = currentColors[index];
    }

    public void OnButtonClicked(int index)
    {
        ChangeColor(index);
        CheckColors();
    }

    private void CheckColors()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (!ColorsAreEqual(currentColors[i], correctColors[i]))
            {
                return;
            }
        }
        Debug.Log("All buttons are in the correct order and color!");

        // Destruir el GameObject cuando el patrón de colores es correcto
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }

        // Iluminar el panel de verde cuando el patrón de colores es correcto
        if (panelToHighlight != null)
        {
            panelToHighlight.color = Color.green;
        }
    }

    private bool ColorsAreEqual(Color a, Color b, float tolerance = 0.01f)
    {
        return Mathf.Abs(a.r - b.r) < tolerance &&
               Mathf.Abs(a.g - b.g) < tolerance &&
               Mathf.Abs(a.b - b.b) < tolerance &&
               Mathf.Abs(a.a - b.a) < tolerance;
    }
}
