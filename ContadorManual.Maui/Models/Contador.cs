using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ContadorManual.Maui.Models
{
    public class Contador : INotifyPropertyChanged
    {
        private int _conteo;
        private int _incremento;



        public event PropertyChangedEventHandler? PropertyChanged;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if (_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }

        public int Incremento
        {
            get => _incremento;
            set
            {
                if (_incremento != value)
                {
                    _incremento = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }
       
        public Contador(int valorIniciar = 0, int incremento = 1)
        {
            Conteo = valorIniciar;
            Incremento = incremento;    
        }
        public void Contar()
        {
            Conteo = Conteo + Incremento;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }

        private void OnPropertyChanged(string propertyName)
        {
            //PropertyChanged?

            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
