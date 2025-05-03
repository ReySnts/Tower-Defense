using TMPro;
using UnityEngine;

namespace UI.Button
{
    [RequireComponent(requiredComponent: typeof(UnityEngine.UI.Button))]

    public abstract class AbstractButton : MonoBehaviour
    {
        [SerializeField] private string text;

        private UnityEngine.UI.Button button;

        protected void OnEnable()
        {
            button = GetComponent<UnityEngine.UI.Button>();
            button.onClick.AddListener(call: OnClick);
        }

        protected abstract void OnClick();

        protected virtual void Start() => GetComponentInChildren<TextMeshProUGUI>().text = text;

        protected void OnDisable() => button.onClick.RemoveAllListeners();
    }
}