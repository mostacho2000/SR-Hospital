using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordManager : MonoBehaviour
{
    [SerializeField]public TextMeshProUGUI inputDisplay; // Referencia al Text que muestra la entrada del usuario
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
            // Aquí puedes agregar el código para lo que sucede cuando la contraseña es correcta
        }
        else
        {
            Debug.Log("Password Incorrect");
            enteredPassword = "";
            inputDisplay.text = "";
            // Aquí puedes agregar el código para lo que sucede cuando la contraseña es incorrecta
        }
    }

    public void ClearInput()
    {
        enteredPassword = "";
        inputDisplay.text = "";
    }
}
