using DataStorage.Accentuations.Api;
using Domain.Main;
using PoemTokenization.Tokenizers;

namespace FlyingBeaverIDE.UI
{
    public partial class WordAccentuationSettingForm : Form
    {
        private readonly IAccentuationsRepository _accentuationsRepository;
        private readonly string _word;
        private readonly SyllablesTokenizer _syllablesTokenizer = new();

        public Action OnSuccess;
        
        public WordAccentuationSettingForm(IAccentuationsRepository accentuationsRepository, string word)
        {
            InitializeComponent();
            _accentuationsRepository = accentuationsRepository;
            _word = word;
            
            InitUI();
        }

        private void InitUI()
        {
            CurrentWord.Text = _word;
            
            var vowelsPositions = _syllablesTokenizer.GetVowelsPositions(_word);
            if (!vowelsPositions.Any())
            {
                MessageBox.Show("Неможливо додати слово без голосних звуків!");
                Close();
                return;
            }
            
            if(vowelsPositions.Count() == 1)
            {
                MessageBox.Show("Неможливо додати слово з одним складом!");
                Close();
                return;
            }

            var options = GetNumbersUpTo(vowelsPositions.Count());
            syllablesComboBox.Items.AddRange(options.ToArray());
        }

        private void SubmitAccentuation(object? sender, EventArgs e)
        {
            if (syllablesComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Потрібно вибрати склад!");
                return;
            }

            var accentuation = new Accentuation(_word, new(){syllablesComboBox.SelectedIndex});
            _accentuationsRepository.Add(accentuation);
            Close();
            OnSuccess?.Invoke();
        }

        private IEnumerable<string> GetNumbersUpTo(int includingRangeTop)
        {
            var result = new string[includingRangeTop];
            for (var i = 0; i < includingRangeTop; i++)
                result[i] = (i + 1).ToString();
            return result;
        }
    }
}
