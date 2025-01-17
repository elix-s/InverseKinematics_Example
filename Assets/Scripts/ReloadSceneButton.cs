using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadSceneButton : MonoBehaviour
{
   [SerializeField] private Button _reloadButton;

   private void Awake()
   {
      _reloadButton.onClick.AddListener(() => SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex));
   }
}
