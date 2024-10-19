using UnityEngine;
using TestEditor;
using UniRx;

public class TestStarter : MonoBehaviour
{
    [SerializeField, Tooltip("Test file")] private NPCConversation myConversation;

    public void StartTestGame()
    {
        ConversationManager.Instance.StartConversation(myConversation);
        Debug.Log("���� ��� �����");
    }

    private void Start() { StartTestGame(); }
}
