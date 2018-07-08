using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaUIPlayground.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _textBoxText = "Type in the box";

        public MainWindowViewModel()
        {
            MyCommand = new DelegateCommand(Change);
        }

        public ICommand MyCommand { get; }

        public string TextBoxText
        {
            get { return _textBoxText; }
            set { this.RaiseAndSetIfChanged(ref _textBoxText, value); }
        }

        public void Change()
        {
            TextBoxText = "Changed text with button.";
        }

    }
}
