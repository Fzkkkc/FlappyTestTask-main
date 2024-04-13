using UnityEngine;
using UserInterface;
using UserInterface.LosePanelUI;

namespace Player
{
    public class PlayerScore : MonoBehaviour
    {
        public int CurrentPlayerScore;
        public int RecordPlayerScore { get; private set; }
        
        [SerializeField] private CurrentPlayerScoreTextUI _displayText;
        
        private const string RecordPlayerScorePlayerPrefsKey = "RecordPlayerScore";
        
        public void Start()
        {
            ResetCurrentPlayerScore();
            LoadPlayerScore();
            _displayText.UpdatePlayerCurrentScore();
        }

        public void IncreaseCurrentPlayerScore()
        {
            CurrentPlayerScore++;
            _displayText.UpdatePlayerCurrentScore();
            if (CurrentPlayerScore > RecordPlayerScore)
            {
                RecordPlayerScore = CurrentPlayerScore;
                SaveRecordPlayerScore();
            }
        }
        
        public void ResetCurrentPlayerScore()
        {
            CurrentPlayerScore = 0;
        }
        
        private void LoadPlayerScore()
        {
            if (PlayerPrefs.HasKey(RecordPlayerScorePlayerPrefsKey))
            {
                RecordPlayerScore = PlayerPrefs.GetInt(RecordPlayerScorePlayerPrefsKey);
            }
        }

        private void SaveRecordPlayerScore()
        {
            PlayerPrefs.SetInt(RecordPlayerScorePlayerPrefsKey, RecordPlayerScore);
            PlayerPrefs.Save(); 
        }
    }
}