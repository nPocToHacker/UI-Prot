using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatContainer : MonoBehaviour
{
    public GameObject messageTemplate, chatWindow;

    public TextMeshProUGUI getNameFrom;

    private string playerName;

    public int messageCapacity = 10;

    [SerializeField]
    List<Message> messageContainer = new List<Message>();

    void Start()
    {
        playerName = "Player";
    }

    public void updatePlayerName()
    {
        playerName = getNameFrom.text;
    }

    public void AddMessage(TextMeshProUGUI inputField)
    {
        string text = inputField.text;

        if (messageContainer.Count >= messageCapacity)
        {
            Destroy(messageContainer[0].textObject.gameObject);
            messageContainer.Remove(messageContainer[0]);
        }

        Message newMessage = new Message();

        newMessage.senderName = playerName;
        newMessage.text = text;

        GameObject newText = Instantiate(messageTemplate, chatWindow.transform);

        newMessage.textObject = newText.GetComponent<TextMeshProUGUI>();

        newMessage.textObject.SetText(newMessage.senderName + ": " + newMessage.text);

        messageContainer.Add(newMessage);
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public TextMeshProUGUI textObject;
    public string senderName;
}