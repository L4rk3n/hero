using ConsoleApp1.Chapitres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DonjonBuilder
{
    public class Piece
    {
        private delegate void PieceDelegate();
        private PieceDelegate[] pieces;

        public Piece()
        {
            pieces = new PieceDelegate[]
            {
            Piece1,
            Piece2,
            Piece3,
            Piece4,
            Piece5,
            Piece6,
            Piece7,
            Piece8,
            Piece9,
            Piece10,
            };
        }

        public void Piece1()
    {
        Case[,] piece1 = new Case[8, 6] 
        {
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
        };
    }
        public void Piece2()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(5, "-") }
            };
        }
        public void Piece3()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
            };
        }
        public void Piece4()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "-"), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
            };
        }
        public void Piece5()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
            };
        }
        public void Piece6()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
            };
        }
        public void Piece7()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
            };
        }
        public void Piece8()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " ") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-") }
            };
        }
        public void Piece9()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
            };
        }
        public void Piece10()
        {
            Case[,] piece1 = new Case[8, 6]
            {
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(0, " ") },
        { new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(0, " "), new Case(0, " "), new Case(5, "|"), new Case(0, " "), new Case(0, " "), new Case(5, "|") },
        { new Case(5, "-"), new Case(5, "-"), new Case(5, "-"), new Case(0, " "), new Case(5, "-"), new Case(5, "-") }
            };
        }

    }





}
