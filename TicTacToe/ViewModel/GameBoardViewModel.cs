using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TicTacToeBL.Command;

namespace TicTacToeBL.ViewModel
{
    public class GameBoardViewModel
    {
        private RelayCommand<object>? _PressTestCmd;
        public RelayCommand<object> PressTestCmd => _PressTestCmd ??= new RelayCommand<object>(PressTest1);
        public GameBoardViewModel()
        {

        }
        public void PressTest1(object parameter)
        {
            MessageBox.Show("Pressed The Button");
        }
    }
}
