using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatContainer : MonoBehaviour
{
    public GameObject messageTemplate, chatWindow;

    public int messageCapacity = 10;

    [SerializeField]
    List<Message> messageContainer = new List<Message>();

    void Start()
    {

    }

    public void AddMessage(TextMeshProUGUI inputField)
    {
        string text = inputField.text;
        if (messageContainer.Count >= messageCapacity)
        {
            Destroy(messageContainer[0].textObject.gameObject);
            messageContainer.Remove(messageContainer[0]);
        }

        Message input = new Message();

        input.text = text;

        GameObject newText = Instantiate(messageTemplate, chatWindow.transform);

        input.textObject = newText.GetComponent<TextMeshProUGUI>();

        input.textObject.SetText(input.text);

        messageContainer.Add(input);
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public TextMeshProUGUI textObject;
}