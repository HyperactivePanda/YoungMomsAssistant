﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YoungMomsAssistant.UI.Infrastructure.Commands {
    class RelayCommand<T> : ICommand {

        private readonly Action<T> _execute;
        private readonly Predicate<T> _canExecute;

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null) {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter) {
            if (parameter.GetType() != typeof(T)) {
                throw new ArgumentException("parameter");
            }

            return _canExecute?.Invoke((T)parameter) ?? true;
        }

        public void Execute(object parameter) {
            if (parameter.GetType() != typeof(T)) {
                throw new ArgumentException("parameter");
            }

            _execute?.Invoke((T)parameter);
        }
    }
}
