using DataStorage.Accentuations.Api;
using Domain.Main;
using PoemTokenization.Tokenizers;

namespace FlyingBeaverIDE.UI
{
    public partial class WordAccentuationSettingForm : Form
    {
        private const string CurrentSyllablesPrefix = "Поточні наголоси:"; 
        private readonly IAccentuationsRepository _accentuationsRepository;
        private readonly string _word;
        private readonly SyllablesTokenizer _syllablesTokenizer = new();
        private readonly IReadOnlyList<int> _vowelsPositions;
        private readonly List<int> _currentAccentuations = new();
        private readonly bool _update;

        public Action OnSuccess;
        
        public WordAccentuationSettingForm(IAccentuationsRepository accentuationsRepository, 
            string word, Accentuation? current = null)
        {
            InitializeComponent();
            _accentuationsRepository = accentuationsRepository;
            _word = word;
            _vowelsPositions = _syllablesTokenizer.GetVowelsPositions(_word).ToList();
            
            if (!Validate()) 
                return;

            if (current is not null)
            {
                _currentAccentuations = current.Accentuations;
                _update = true;
            }

            UpdateUi();
        }

        private bool Validate()
        {
            if (!_vowelsPositions.Any())
            {
                MessageBox.Show("Неможливо додати слово без голосних звуків!");
                Close();
                return false;
            }

            if (_vowelsPositions.Count() == 1)
            {
                MessageBox.Show("Неможливо додати слово з одним складом!");
                Close();
                return false;
            }

            return true;
        }

        private void UpdateUi()
        {
            CurrentWord.Text = _word;
            CurrentSyllables.Text = CurrentSyllablesPrefix + GetCurrentSyllablesString();
            
            var options = GetUnaccentuatedSyllablesIndexes(_vowelsPositions.Count());
            if (!options.Any())
            {
                syllablesComboBox.Enabled = false;
                AddAccentuationButton.Enabled = false;
                return;
            }
            
            syllablesComboBox.Enabled = true;
            AddAccentuationButton.Enabled = true;
            syllablesComboBox.DataSource = options;
        }

        private int SelectedSyllable() => 
            (int)syllablesComboBox.SelectedItem;

        private string GetCurrentSyllablesString()
        {
            var result = string.Empty;
            foreach (var accentuation in _currentAccentuations)
                result += " " + accentuation;
            return result;
        }

        private IEnumerable<int> GetUnaccentuatedSyllablesIndexes(int includingRangeTop)
        {
            var result = new List<int>();
            for (var i = 0; i < includingRangeTop; i++)
                if(!_currentAccentuations.Contains(i+1))
                    result.Add(i + 1);
            return result;
        }

        private void AddAccentuation(object? sender, EventArgs e)
        {
            var accentuation = SelectedSyllable();
            _currentAccentuations.Add(accentuation);
            UpdateUi();
        }

        private void ClearAccentuations(object? sender, EventArgs e)
        {
            _currentAccentuations.Clear();
            UpdateUi();
        }

        private void SaveAccentuations(object? sender, EventArgs e)
        {
            if (!_currentAccentuations.Any())
            {
                MessageBox.Show("Потрібно вибрати склад!");
                return;
            }

            var accentuation = new Accentuation(_word, _currentAccentuations);
            if(!_update)
                _accentuationsRepository.Add(accentuation);
            else
                _accentuationsRepository.Update(accentuation);
            
            Close();
            OnSuccess?.Invoke();
        }
    }
}
