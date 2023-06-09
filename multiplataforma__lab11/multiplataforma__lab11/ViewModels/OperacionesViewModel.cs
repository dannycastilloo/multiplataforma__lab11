using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace multiplataforma__lab11.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {
        //public int ValorA { get; set; }

        int valorA;
        public int ValorA
        {
            get { return valorA; }
            set
            {
                if (valorA != value)
                {
                    valorA = value;
                    OnPropertyChanged();
                }
            }
        }



        int valorB;
        public int ValorB
        {
            get { return valorB; }
            set
            {
                if (valorB != value)
                {
                    valorB = value;
                    OnPropertyChanged();
                }
            }
        }


        int resultadoSuma;
        public int ResultadoSuma
        {
            get { return resultadoSuma; }
            set
            {
                if (resultadoSuma != value)
                {
                    resultadoSuma = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoResta;
        public int ResultadoResta
        {
            get { return resultadoResta; }
            set
            {
                if (resultadoResta != value)
                {
                    resultadoResta = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoMultiplicacion;
        public int ResultadoMultiplicacion
        {
            get { return resultadoMultiplicacion; }
            set
            {
                if (resultadoMultiplicacion != value)
                {
                    resultadoMultiplicacion = value;
                    OnPropertyChanged();
                }
            }
        }

        int resultadoDivision;
        public int ResultadoDivision
        {
            get { return resultadoDivision; }
            set
            {
                if (resultadoDivision != value)
                {
                    resultadoDivision = value;
                    OnPropertyChanged();
                }
            }
        }



        public ICommand Sumar { get; set; }
        public ICommand Restar { get; set; }
        public ICommand Multiplicar { get; set; }
        public ICommand Dividir { get; set; }

        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                resultadoSuma = ValorA + ValorB;
            });


            Restar = new Command(() =>
            {
                resultadoResta = ValorA - ValorB;
            });

            Multiplicar = new Command(() =>
            {
                resultadoMultiplicacion = ValorA * ValorB;
            });

            Dividir = new Command(() =>
            {
                resultadoDivision = ValorA / ValorB;
            });
        }

    }
}
