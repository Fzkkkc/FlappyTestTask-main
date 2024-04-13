using UnityEngine.SceneManagement;

namespace SceneManagment
{
    public class RestartLevel 
    {
        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
