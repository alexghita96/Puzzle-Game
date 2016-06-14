using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[,] solved_pattern = new int[5, 5], current_pattern = new int[5, 5];
        int[] move_x = {-1, 0, 1, 0}, move_y = {0, 1, 0, -1};
        int pattern_matches, games_played = 0, games_won = 0, moves_made = 0;
        bool Clicked = true, first_move = true, shuffled = false;

        Bitmap original_image = new Bitmap("Picture.jpg");
        Bitmap[,] solved_puzzle = new Bitmap[5, 5], current_puzzle = new Bitmap[5, 5];
        PictureBox[,] puzzle_frame = new PictureBox[5, 5];

        Size puzzle_cell_size = new Size(100, 100);
        Point Clicked_Cell = new Point(-1, -1);


        private void Initialize_Solved_Pattern()
        {
            int count = -1;

            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    solved_pattern[i, j] = ++count;
        }

        private void Initialize_Solved_Puzzle()
        {
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    solved_puzzle[i, j] = new Bitmap(original_image.Clone(new Rectangle(j * 100, i * 100, 100, 100), original_image.PixelFormat));
            
            Bitmap original_image2 = new Bitmap("Picture2.jpg");
            Solved_PictureBox.Image = original_image2;
        }

        private void Initialize_Current_Puzzle()
        {
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                    current_puzzle[i, j] = new Bitmap(original_image.Clone(new Rectangle(j * 100, i * 100, 100, 100), original_image.PixelFormat));
        }

        private void Initialize_Puzzle_Frame()
        {
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                {
                    int x = i, y = j;

                    puzzle_frame[i, j] = new PictureBox();
                    puzzle_frame[i, j].Size = puzzle_cell_size;
                    puzzle_frame[i, j].Location = new Point(j * 100 + 10, i * 100 + 10);
                    puzzle_frame[i, j].BorderStyle = BorderStyle.FixedSingle;
                    puzzle_frame[i, j].Click += (sender1, event1) => this.Highlight_Clicked_Cell(x, y);
                    this.Controls.Add(puzzle_frame[i, j]);
                }
        }

        private void Initialize_Statistics()
        {
            Games_Played_TextBox.Text = "0";
            Games_Won_TextBox.Text = "0";
            Moves_Made_TextBox.Text = "0";
        }

        private void Draw_Solved_Puzzle()
        {
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                {
                    puzzle_frame[i, j].Image = (Image)solved_puzzle[i, j].Clone();
                    puzzle_frame[i, j].Refresh();
                }
        }

        private void Generate_New_Current_Pattern()
        {
            int[] Used = new int[25];
            int numbers_left = 25, random_number, i = 0, j = 0;
            Random rand = new Random();

            Clicked = false;
            Clicked_Cell.X = Clicked_Cell.Y = -1;
            pattern_matches = 0;
            moves_made = 0;
            first_move = shuffled = true;
            Update_Statistics();

            while (numbers_left > 0)
            {
                random_number = rand.Next(0, 25);

                if (Used[random_number] == 0)
                {
                    Used[random_number] = 1;
                    numbers_left--;
                    current_pattern[i, j] = random_number;
                    if (j < 4)
                        j++;
                    else if (j == 4)
                    {
                        j = 0;
                        i++;
                    }
                }
            }

            for (i = 0; i < 5; ++i)
                for (j = 0; j < 5; ++j)
                    if (current_pattern[i, j] == solved_pattern[i, j])
                        pattern_matches++;
        }

        private void Update_Current_Puzzle()
        {
            int x, y;

            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                {
                    x = current_pattern[i, j] / 5;
                    y = current_pattern[i, j] % 5;
                    current_puzzle[i, j] = (Bitmap)solved_puzzle[x, y].Clone();
                }
        }

        private void Update_Statistics()
        {
            Games_Played_TextBox.Text = games_played.ToString();
            Games_Won_TextBox.Text = games_won.ToString();
            Moves_Made_TextBox.Text = moves_made.ToString();
        }

        private void Draw_Current_Puzzle()
        {
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                {
                    puzzle_frame[i, j].Image = (Image)current_puzzle[i, j].Clone();
                    puzzle_frame[i, j].Refresh();
                }
        }

        private bool Clicked_Nearby_Cell(int x, int y)
        {
            int test_x, test_y;

            for (int k = 0; k < 4; ++k)
            {
                test_x = Clicked_Cell.X + move_x[k];
                test_y = Clicked_Cell.Y + move_y[k];

                if (x == test_x && y == test_y)
                    return true;
            }

            return false;
        }

        private void Deselect_Cell(int x, int y)
        {
            int test_x, test_y, solved_x, solved_y;

            solved_x = current_pattern[x, y] / 5;
            solved_y = current_pattern[x, y] % 5;
            current_puzzle[x, y] = (Bitmap)solved_puzzle[solved_x, solved_y].Clone();
            Clicked = false;
            Clicked_Cell.X = Clicked_Cell.Y = -1;

            for (int k = 0; k < 4; ++k)
            {
                test_x = x + move_x[k];
                test_y = y + move_y[k];

                if (test_x >= 0 && test_x <= 4 && test_y >= 0 && test_y <= 4)
                {
                    solved_x = current_pattern[test_x, test_y] / 5;
                    solved_y = current_pattern[test_x, test_y] % 5;
                    current_puzzle[test_x, test_y] = (Bitmap)solved_puzzle[solved_x, solved_y].Clone();
                }
            }
        }

        private void Select_Cell(int x, int y)
        {
            Graphics G = Graphics.FromImage(current_puzzle[x, y]);
            int test_x, test_y;

            G.DrawRectangle(new Pen(Color.Red, 3), 0, 0, 97, 97);

            Clicked = true;
            Clicked_Cell.X = x;
            Clicked_Cell.Y = y;

            for (int k = 0; k < 4; ++k)
            {
                test_x = x + move_x[k];
                test_y = y + move_y[k];

                if (test_x >= 0 && test_x <= 4 && test_y >= 0 && test_y <= 4)
                {
                    G = Graphics.FromImage(current_puzzle[test_x, test_y]);
                    G.DrawRectangle(new Pen(Color.Yellow, 3), 0, 0, 97, 97);
                }
            }
        }

        private void Compute_Pattern_Matches(int x1, int y1, int x2, int y2)
        {
            if (current_pattern[x1, y1] == solved_pattern[x1, y1])
                pattern_matches++;
            else if (current_pattern[x1, y1] == solved_pattern[x2, y2])
                pattern_matches--;
            if (current_pattern[x2, y2] == solved_pattern[x2, y2])
                pattern_matches++;
            else if (current_pattern[x2, y2] == solved_pattern[x1, y1])
                pattern_matches--;
        }

        private void Check_If_Done()
        {
            if (pattern_matches == 25)
            {
                Clicked = true;
                Clicked_Cell.X = Clicked_Cell.Y = -1;
                games_won++;
                Update_Statistics();
                MessageBox.Show("Congratulations! You have solved the puzzle!");
            }
        }

        private void Swap_Cells(int x1, int y1, int x2, int y2)
        {
            Bitmap aux_image;
            int aux_number, solved_x1, solved_y1, solved_x2, solved_y2;

            solved_x1 = current_pattern[x1, y1] / 5;
            solved_y1 = current_pattern[x1, y1] % 5;
            solved_x2 = current_pattern[x2, y2] / 5;
            solved_y2 = current_pattern[x2, y2] % 5;

            aux_number = current_pattern[x1, y1];
            current_pattern[x1, y1] = current_pattern[x2, y2];
            current_pattern[x2, y2] = aux_number;

            aux_image = (Bitmap)solved_puzzle[solved_x1, solved_y1].Clone();
            current_puzzle[x1, y1] = (Bitmap)current_puzzle[x2, y2].Clone();
            current_puzzle[x2, y2] = (Bitmap)aux_image.Clone();

            moves_made++;
            Update_Statistics();
        }

        private void Highlight_Clicked_Cell(int x, int y)
        {
            if (first_move == true && shuffled == true)
            {
                first_move = false;
                games_played++;
                Update_Statistics();
            }

            if (Clicked_Cell.X == x && Clicked_Cell.Y == y && Clicked == true)
            {
                Deselect_Cell(x, y);
                Draw_Current_Puzzle();
            }

            else if (Clicked == true && Clicked_Nearby_Cell(x, y) == true)
            {
                Swap_Cells(Clicked_Cell.X, Clicked_Cell.Y, x, y);
                Compute_Pattern_Matches(Clicked_Cell.X, Clicked_Cell.Y, x, y);
                Deselect_Cell(Clicked_Cell.X, Clicked_Cell.Y);
                Draw_Current_Puzzle();
                Check_If_Done();
            }

            else if (Clicked == true && Clicked_Cell.X != -1 && Clicked_Cell.Y != -1)
            {
                Deselect_Cell(Clicked_Cell.X, Clicked_Cell.Y);
                Select_Cell(x, y);
                Draw_Current_Puzzle();
            }

            else if (Clicked == false)
            {
                Select_Cell(x, y);
                Draw_Current_Puzzle();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize_Solved_Pattern();
            Initialize_Solved_Puzzle();
            Initialize_Current_Puzzle();
            Initialize_Puzzle_Frame();
            Initialize_Statistics();
            Draw_Solved_Puzzle();
        }

        private void shuffle_image_button_Click(object sender, EventArgs e)
        {
            Generate_New_Current_Pattern();
            Update_Current_Puzzle();
            Draw_Current_Puzzle();
        }
    }
}
