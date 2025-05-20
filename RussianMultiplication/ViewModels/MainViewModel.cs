using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using RussianMultiplication.Commands;
using RussianMultiplication.Models;
using RussianMultiplication.Services;

namespace RussianMultiplication.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IRussianMultiplication _service;

        public MainViewModel(IRussianMultiplication service)
        {
            _service = service;
            Steps = new ObservableCollection<StepResult>();
        }

        private string _number1;

        public string Number1
        {
            get => _number1;
            set
            {
                _number1 = value;
                OnPropertyChanged();
            }
        }

        private string _number2;

        public string Number2
        {
            get => _number2;
            set
            {
                _number2 = value;
                OnPropertyChanged();
            }
        }

        private int? _result;

        public int? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<StepResult> Steps { get; set; }

        public ICommand MultiplyCommand => new RelayCommand(ExecuteMultiply);

        private void ExecuteMultiply()
        {
            if (int.TryParse(Number1, out int a) && int.TryParse(Number2, out int b))
            {
                (int res, var steps) = _service.Multiply(a, b);
                Result = res;
                Steps.Clear();
                foreach (StepResult s in steps)
                {
                    Steps.Add(s);
                }
            }
            else
            {
                Result = null;
                Steps.Clear();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}