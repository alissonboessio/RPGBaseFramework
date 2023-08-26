using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGBaseFramework.Base
{
    internal class World
    {
        public int Lines;
        public int Columns;
        public char[,] Map;
        public List<char> rightGuesses = new List<char>();
        public List<char> wrongGuesses = new List<char>();
        public int letrasCorretas = 0;
        public string word;

        public World(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;

            Map = new char[lines, columns];
        }

        public void Fill()
        {
            for (int l = 0; l < Lines; l++)
            {

                for (int c = 0; c < Columns; c++)
                {
                    if (l == 0)
                    {
                        if (c == 0)
                        {
                            Map[l, c] = '╔';

                        }
                        else if (c == Columns - 1)
                        {
                            Map[l, c] = '╗';

                        }
                        else
                        {
                            Map[l, c] = '═';
                        }
                    }
                    else if (l == Lines - 1)
                    {
                        if (c == 0)
                        {
                            Map[l, c] = '╚';

                        }
                        else if (c == Columns - 1)
                        {
                            Map[l, c] = '╝';

                        }
                        else
                        {
                            Map[l, c] = '═';
                        }
                    }
                    if ((l > 0 && l < Lines - 1) && (c == 0 || c == Columns - 1))
                    {
                        Map[l, c] = '║';
                    }
                    else if (!((l > 0 || l < Lines - 1) && (c == 0 || c == Columns - 1)) && l != 0 && l != Lines - 1)
                    {
                        Map[l, c] = ' ';
                    }
                }
            }
        }
        public void addOptions(List<string> options)
        {
            int qtyOptions = options.Count + 1;

            foreach (var option in options)
            {
                int posic = 3;
             
                for (int i = 0; i < option.Length; i++)
                {
                    //Map[Lines - qtyOptions - (int)(option.Length / Lines), posic++] = option[i];
                    Map[Lines - qtyOptions, posic++] = option[i];

                }

                qtyOptions--;

            }

        }
      
        public void addPlace(List<string> options)
        {
            int qtyOptions = 0;

            foreach (var option in options)
            {
                int posic = 1;

                for (int i = 0; i < option.Length; i++)
                {
                    //Map[Lines - qtyOptions - (int)(option.Length / Lines), posic++] = option[i];
                    Map[3 + qtyOptions, posic++] = option[i];

                }

                qtyOptions++;

            }

        }
      


    }

}
