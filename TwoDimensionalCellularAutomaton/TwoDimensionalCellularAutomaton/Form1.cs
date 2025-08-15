using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TwoDimensionalCellularAutomaton
{
    public partial class Form1 : Form
    {
        private int[,] currentState;
        private int[,] previousState;
        private Stopwatch stopwatch = new Stopwatch();

        private static readonly Dictionary<(int, int), string> state_colors = new Dictionary<(int, int), string>
        {
            { (int.MinValue, -40), "#0000FF" },  // Очень холодный (синий)
            { (-40, -35), "#0E0EF0" },
            { (-35, -30), "#1C1CE2" },
            { (-30, -25), "#2A2AD4" },
            { (-25, -20), "#3838C6" },
            { (-20, -15), "#4747B8" },
            { (-15, -10), "#5555AA" },
            { (-10, -5), "#63639C" },
            { (-5, 0), "#71718E" },
            { (1, 5), "#808080" },  // Нейтральный (серый)
            { (5, 10), "#96906E" },
            { (10, 20), "#AD9A5C" },
            { (20, 30), "#C3964A" },
            { (30, 40), "#DA8C38" },
            { (40, 50), "#EA7A26" },
            { (50, 60), "#EB6614" },
            { (60, 70), "#EB5200" },
            { (70, 80), "#EB3E00" },
            { (80, 90), "#EB2A00" },
            { (90, int.MaxValue), "#FF0000" }  // Очень горячий (красный)
        };


        static string GetColorForTemperature(int temp, Dictionary<(int, int), string> dict)
        {
            foreach (var entry in dict)
            {
                if (temp >= entry.Key.Item1 && temp < entry.Key.Item2)
                    return entry.Value;
            }
            Console.WriteLine($"Неизвестная температура: {temp}"); // Отладка
            return "#000000";
        }

        public Form1()
        {
            InitializeComponent();

            this.Shown += RemoveSelection;

            cell_count = textBox_Size.Text;
            if (!int.TryParse(cell_count, out cell_count_value) || cell_count_value < 1 || cell_count_value > 100)
            {
                MessageBox.Show("Введите корректное значение для размера поля (от 1 до 100)!");
                return;
            }
            InitializeModelingSpace();

        }

        private void RemoveSelection(object sender, EventArgs e)
        {
            if (dataGridView_Space.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dataGridView_Space.SelectedCells)
                    cell.Selected = false;
            }
        }

        int flagButtonFirstClick = 0; // 0 - первого нажатия не было, 1 - нажатие произошло (блокируем поле ввода)
        int cell_count_value;
        string cell_count;
        double coeff_density = 0.75; // default
        int live_cells_count = 0;
        int frozen_cells_count = 0;

        private void InitializeModelingSpace()
        {
            SetupDataGridView();
            GenerateStartState();
            DrawCurrentState();
        }

        private void SetupDataGridView()
        {
            dataGridView_Space.ColumnCount = cell_count_value;
            dataGridView_Space.RowCount = cell_count_value;

            int cellSize = dataGridView_Space.Width / cell_count_value;

            foreach (DataGridViewColumn column in dataGridView_Space.Columns)
            {
                column.Width = cellSize;
            }
            foreach (DataGridViewRow row in dataGridView_Space.Rows)
            {
                row.Height = cellSize;
            }

            dataGridView_Space.ClearSelection();
        }

        private void GenerateStartState()
        {
            Random rnd = new Random();
            previousState = new int[cell_count_value, cell_count_value];

            int count_start_live_cells = (int)(coeff_density * cell_count_value * cell_count_value);

            for (int k = 0; k < count_start_live_cells; k++)
            {
                int i, j;
                do
                {
                    i = rnd.Next(0, cell_count_value); 
                    j = rnd.Next(0, cell_count_value);
                } while (previousState[i, j] == 1);

                previousState[i, j] = 1;
            }

            currentState = new int[cell_count_value, cell_count_value];
            Array.Copy(previousState, currentState, previousState.Length);
        }

        private void CalculateCurrentState()
        {
            Random random = new Random();

            int rows = previousState.GetLength(0);
            int cols = previousState.GetLength(1);

            live_cells_count = 0;
            frozen_cells_count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = previousState[i, j];

                    if (value != 0) // Если клетка не пустая
                    {
                        live_cells_count++;

                        int tempChange = 0;
                        List<(int, int)> possibleMoves = new List<(int, int)>(); // Свободные клетки для шага

                        // Окрестность Мура (8 направлений)
                        for (int di = -1; di <= 1; di++)
                        {
                            for (int dj = -1; dj <= 1; dj++)
                            {
                                if (di == 0 && dj == 0) continue; // Пропустить саму клетку

                                int ni = i + di;
                                int nj = j + dj;

                                if (ni >= 0 && ni < rows && nj >= 0 && nj < cols)
                                {
                                    if (previousState[ni, nj] != 0)
                                    {
                                        tempChange += 35; // Сосед есть, нагрев
                                    }
                                    else
                                    {
                                        tempChange -= 4; // Соседа нет, охлаждение
                                        possibleMoves.Add((ni, nj)); // Запоминаем свободную клетку (для возможного шага)
                                    }
                                }
                                else
                                {
                                    tempChange -= 4; // нет соседа (по границам карты)
                                }
                            }
                        }

                        if (possibleMoves.Count > 0)
                        {
                            tempChange += random.Next(20, 40);
                        }
                        else
                        {
                            tempChange -= 4;
                        }

                        // update temp
                        currentState[i, j] = value + tempChange;
                        if (currentState[i, j] == 0)
                        {
                            currentState[i, j] = 1;
                        }

                        // check state
                        if (currentState[i, j] < -119)
                        {
                            frozen_cells_count++;
                            currentState[i, j] = -119; // frozen -> stop moving
                        }
                        else if (currentState[i, j] > 299)
                        {
                            currentState[i, j] = 0; // overheated -> burst
                        }
                        else if (possibleMoves.Count > 0)
                        {
                            // cell move
                            var (newI, newJ) = possibleMoves[random.Next(possibleMoves.Count)];
                            currentState[newI, newJ] = currentState[i, j];
                            currentState[i, j] = 0;
                        }
                    }
                }
            }

            // currentState -> previousState
            Array.Copy(currentState, previousState, currentState.Length);
        }


        private void DrawCurrentState()
        {
            ClearGrid();
            for (int i = 0; i < currentState.GetLength(0); i++)
            {
                for (int j = 0; j < currentState.GetLength(1); j++)
                {
                    int value = currentState[i, j];

                    if (value != 0) // Если клетка не пустая
                    {
                        string colorHex = GetColorForTemperature(value, state_colors);
                        dataGridView_Space.Rows[i].Cells[j].Style.BackColor = ColorTranslator.FromHtml(colorHex);
                        // dataGridView_Space.Rows[i].Cells[j].Value = value;
                    }
                }
            }
        }

        private void ClearGrid()
        {
            foreach (DataGridViewRow row in dataGridView_Space.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White; // Белый фон
                }
            }
        }


        int flagButtonClick = 0; // 0 - stop, 1 - start

        private void button_StartStop_Click(object sender, EventArgs e)
        {
            if (flagButtonFirstClick == 0)
            {
                flagButtonFirstClick = 1;
                textBox_Size.ReadOnly = true;
                textBox_Size.Enabled = false;
                trackBar_Density.Enabled = false;
            }

            if (flagButtonClick == 0)
            {
                stopwatch.Start();
                timer.Start();
                flagButtonClick = 1;
            }
            else
            {
                stopwatch.Stop();
                timer.Stop();
                flagButtonClick = 0;
            }

        }

        int num_population = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            num_population++;
            label_NumberPopulationValue.Text = num_population.ToString();

            TimeSpan elapsed = stopwatch.Elapsed;
            label_TimeSimulationValue.Text = $"{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";

            currentState = new int[cell_count_value, cell_count_value]; // Очистка состояния
            CalculateCurrentState();
            DrawCurrentState();

            if (frozen_cells_count == live_cells_count)
            {
                timer.Stop();
                flagButtonClick = 0;
                button_StartStop.Enabled = false;
            }
        }

        private void textBox_Size_TextChanged(object sender, EventArgs e)
        {
            if (flagButtonFirstClick == 0)
            {
                cell_count = textBox_Size.Text;
                if (!int.TryParse(cell_count, out cell_count_value) || cell_count_value < 1 || cell_count_value > 100)
                {
                    MessageBox.Show("Введите корректное значение для размера поля (от 1 до 100)!");
                    return;
                }
                InitializeModelingSpace();
            }
        }

        private void trackBar_Density_Scroll(object sender, EventArgs e)
        {
            coeff_density = trackBar_Density.Value / 100.0;
            GenerateStartState();
            DrawCurrentState();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            stopwatch.Reset();
            timer.Stop();
            button_StartStop.Enabled = true;
            textBox_Size.ReadOnly = false;
            textBox_Size.Enabled = true;
            trackBar_Density.Enabled = true;
            textBox_Size.Text = "10";
            cell_count = textBox_Size.Text;
            if (!int.TryParse(cell_count, out cell_count_value) || cell_count_value < 1 || cell_count_value > 100)
            {
                MessageBox.Show("Введите корректное значение для размера поля (от 1 до 100)!");
                return;
            }
            trackBar_Density.Value = 0;

            InitializeModelingSpace();

            flagButtonClick = 0;
            flagButtonFirstClick = 0;
            num_population = 0;
            label_NumberPopulationValue.Text = "0";
            label_TimeSimulationValue.Text = "0";
            coeff_density = 0.75; // default
            live_cells_count = 0;
            frozen_cells_count = 0;
        }
    }
}
