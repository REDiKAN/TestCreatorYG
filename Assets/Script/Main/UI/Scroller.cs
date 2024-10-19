using UnityEngine.UI;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField, Tooltip("Image background")] private RawImage img;
    [Header("Setting Vector Two")]
    [SerializeField] private float x = 0.01f;
    [SerializeField] private float y = 0.01f;

    private void Update() { img.uvRect = new Rect(img.uvRect.position + new Vector2(x, y) * Time.deltaTime, img.uvRect.size); }
}
