using DataStorage.Accentuations.Api;
using Domain.Main;
using PoemTokenization.Tokenizers;

namespace FlyingBeaverIDE.UI
{
    public partial class LocalDictionaryForm : Form
    {
        private IAccentuationsRepository _accentuationsRepository;
        private readonly SyllablesTokenizer _syllablesTokenizer = new();
        private readonly List<string> _unknownWords;

        public LocalDictionaryForm(IAccentuationsRepository accentuationsRepository, IEnumerable<string> unknownWords)
        {
            InitializeComponent();
            _accentuationsRepository = accentuationsRepository;
            _unknownWords = unknownWords.ToList();

            UpdateUi();
        }

        private void UpdateUi()
        {
            UpdateSuggestions();
            UpdateLocalRepositoryView();
            Update();
        }

        private void AddSuggestedWord(object? sender, EventArgs e)
        {
            var selectedWord = GetSelectedSuggestionWord();
            if (selectedWord is null)
            {
                MessageBox.Show("Щось пішло не так. Не вийшло додати слово.");
                return;
            }

            AddWord(selectedWord);
        }

        private void UpdateLocalRepositoryView()
        {
            var localWords = _accentuationsRepository.GetAll();
            if (!localWords.Any())
            {
                knownWords.Enabled = false;
                deleteCurrentWordButton.Enabled = false;
                return;
            }
            
            knownWords.Enabled = true;
            deleteCurrentWordButton.Enabled = true;

            knownWords.DataSource = null;
            knownWords.DataSource = _accentuationsRepository.GetAll();
        }

        private void DeleteSelectedWord(object? sender, EventArgs e)
        {
            var selectedWOrd = GetSelectedKnownWord();
            if (selectedWOrd is null)
            {
                MessageBox.Show("Щось пішло не так. Не вийшло видалити слово.");
                return;
            }
            _accentuationsRepository.Delete(selectedWOrd);
            UpdateUi();
        }

        private void UpdateSelectedWord(object? sender, EventArgs e)
        {
            var selectedAccentuation = GetSelectedKnownWordAccentuation();
            if (selectedAccentuation is null)
            {
                MessageBox.Show("Щось пішло не так. Не вийшло оновити слово.");
                return;
            }
            
            var accentuationForm = new WordAccentuationSettingForm(
                _accentuationsRepository,
                selectedAccentuation.Word, 
                selectedAccentuation);
            accentuationForm.OnSuccess += UpdateUi;
            accentuationForm.Show();
            UpdateUi();
        }

        private void UpdateSuggestions()
        {
            if (_unknownWords.Count == 0)
            {
                suggestionsComboBox.Enabled = false;
                suggestionAddButton.Enabled = false;
                return;
            }
            
            suggestionsComboBox.Enabled = true;
            suggestionAddButton.Enabled = true;
            
            suggestionsComboBox.Items.Clear();
            suggestionsComboBox.Items.AddRange(_unknownWords.ToArray());
            suggestionsComboBox.SelectedIndex = 0;
        }

        private void RemoveSelectedSuggestion() => 
            _unknownWords.Remove(suggestionsComboBox.SelectedItem as string);

        private string? GetSelectedSuggestionWord() => 
            (string)suggestionsComboBox.SelectedItem;

        private string? GetSelectedKnownWord() => 
            GetSelectedKnownWordAccentuation()?.Word;

        private Accentuation? GetSelectedKnownWordAccentuation() => 
            knownWords.SelectedRows[0].DataBoundItem as Accentuation;

        private void AddNewWord(object? sender, EventArgs e)
        {
            var input = newWordInput.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введіть слово, аби додати.");
                return;
            }
            var vowelsPositions = _syllablesTokenizer.GetVowelsPositions(input).ToList();
            
            if (!vowelsPositions.Any())
            {
                MessageBox.Show("Неможливо додати слово без голосних звуків!");
                return;
            }

            if (vowelsPositions.Count() == 1)
            {
                MessageBox.Show("Неможливо додати слово з одним складом!");
                return;
            }

            AddWord(input);
        }

        private void AddWord(string selectedWord)
        {
            var accentuationForm = new WordAccentuationSettingForm(_accentuationsRepository, selectedWord);
            accentuationForm.OnSuccess += RemoveSelectedSuggestion;
            accentuationForm.ShowDialog();
            UpdateUi();
        }
    }
}
