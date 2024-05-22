using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI inputDisplay; // Referencia al Text que muestra la entrada del usuario
    [SerializeField] private GameObject objectToDestroy; // Referencia al GameObject que se debe destruir
    [SerializeField] private Image panelToHighlight; // Referencia al Panel que se debe iluminar de verde
    private string enteredPassword = "";
    public string correctPassword; // La contraseña correcta

    public void OnDigitButtonPressed(string digit)
    {
        if (enteredPassword.Length < 4)
        {
            enteredPassword += digit;
            inputDisplay.text = enteredPassword;
        }

        if (enteredPassword.Length == 4)
        {
            CheckPassword();
        }
    }

    private void CheckPassword()
    {
        if (enteredPassword == correctPassword)
        {
            Debug.Log("Password Correct");
            // Destruir el GameObject cuando la contraseña es correcta
            if (objectToDestroy != null)
            {
                Destroy(objectToDestroy);
            }

            // Iluminar el panel de verde cuando la contraseña es correcta
            if (panelToHighlight != null)
            {
                panelToHighlight.color = Color.green;
            }

            // Aquí puedes agregar más código para lo que sucede cuando la contraseña es correcta
        }
        else
        {
            Debug.Log("Password Incorrect");
            enteredPassword = "";
            inputDisplay.text = "";
            // Aquí puedes agregar más código para lo que sucede cuando la contraseña es incorrecta
        }
    }

    public void ClearInput()
    {
        enteredPassword = "";
        inputDisplay.text = "";
    }
}
