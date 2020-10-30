using System.Windows.Input;
using Assignment2_1.Helpers;
using Xamarin.Forms;

namespace Assignment2_1.ViewModels
{
    public class QuotesViewModel:BaseViewModel
    {
        public ICommand NextQuoteCommand{ get; set; }

        private string _actualQuote;
        public string ActualQuote
        {
            get => _actualQuote;
            set => SetValue(ref _actualQuote, value);
        }

        private readonly DataStorage _dataStorage;

        private int _actualQuoteNumber;
        private int actualQuoteNumber
        {
            get => _actualQuoteNumber;
            set
            {
                if (value >= _dataStorage.Quotes.Length)
                    value = 0;
                else if (value < 0)
                    value = _dataStorage.Quotes.Length-1;
                _actualQuoteNumber = value;
                ActualQuote = _dataStorage.Quotes[_actualQuoteNumber];
            }
        }

        public QuotesViewModel()
        {
            _dataStorage = new DataStorage();
            actualQuoteNumber = 0;
            NextQuoteCommand = new Command(() => actualQuoteNumber++);
        }
    }
}