using UnityEngine;
using UnityEngine.UI;

namespace RhythmGameStarter
{
    public class MainMenu : MonoBehaviour
    {

        public void Exit()
        {
            Application.Quit();
            Debug.Log("quit");
        }
    }
}
