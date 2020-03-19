using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPuzzle
{
    class NumberPuzzleConsoleGame
    {
        private readonly NumberPuzzleGameModel _model;

        public NumberPuzzleConsoleGame()
        {
            _model = new NumberPuzzleGameModel();
        }
        public void Run()
        {
            while (true)
            {
                Show();
                Console.Write("Skriv inn 0-8 for ruten du vil flytte til den blanke: ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out int index)) return;
                _model.Play(index);
            }
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine($"  0 1 2   ");
            Console.WriteLine(" ┌─────┐");
            Console.WriteLine($" │{_model[0]} {_model[1]} {_model[2]}│");
            Console.WriteLine($"3│{_model[3]} {_model[4]} {_model[5]}│5");
            Console.WriteLine($" │{_model[6]} {_model[7]} {_model[8]}│");
            Console.WriteLine(" └─────┘");
            Console.WriteLine("  6 7 8");
            Console.WriteLine();
            Console.WriteLine($"Du har gjort {_model.PlayCount} flyttinger.");
            var not = _model.IsSolved ? "" : "ikke ";
            Console.WriteLine($"Du har {not}løst puslespillet.");
        }
    }
}
