using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using OpenAI;
using TMPro;

public class OpenAIChat : MonoBehaviour
{
    private OpenAIApi OpenAIApi = new();
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    private List<ChatMessage> messages = new();

    public void OnButtonPress()
    {
        string userMessage = inputField.text;
        AskChatGPT(userMessage);
    }

    public async void AskChatGPT(string message)
    {
        ChatMessage newMessage = new();
        newMessage.Content = "Responde a lo siguiente como si fueras el coach personal de un astronauta o cosmonauta que se encuentra en una estación espacial " +
             message + ", responde con datos relevante";
        newMessage.Role = "user";

        messages.Add(newMessage);

        CreateChatCompletionRequest request = new();
        request.Messages = messages;
        request.Model = "gpt-3.5-turbo";

        var response = await OpenAIApi.CreateChatCompletion(request);

        if (response.Choices != null && response.Choices.Count > 0)
        {
            var chatResponse = response.Choices[0].Message;
            messages.Add(chatResponse);
            textMeshProUGUI.text = chatResponse.Content;
        }
    }
}
