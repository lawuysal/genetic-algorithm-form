using ScottPlot;
using System;

namespace genetic_algorithm_form
{
    public partial class Form1 : Form
    {
        static bool isBreak = false;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            formsPlot1.Plot.XLabel("Generation Count");
            formsPlot1.Plot.YLabel("Fitness");
            formsPlot1.Plot.Title("Convergence Graph");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        void start()
        {
            isBreak = false;
            Chromosome best = new Chromosome();
            best.Fitness = double.MaxValue;
            int iterationsCount = 1;
            List<double> dataX = new List<double>();
            List<double> dataY = new List<double>();

            int populationSize = Convert.ToInt32(populationNumeric.Value);
            int maxGenerations = Convert.ToInt32(generationNumeric.Value);
            double crossoverProbability = Convert.ToDouble(crossNumeric.Value);
            double mutationProbability = Convert.ToDouble(mutationNumeric.Value);
            int eliteCount = Convert.ToInt32(elitisimNumeric.Value);

            double minX = -4.5;
            double maxX = 4.5;

            List<Chromosome> population = GeneticAlgorithm.InitializePopulation(populationSize, minX, maxX);

            for (int generation = 0; generation < maxGenerations; generation++)
            {
                // Algorithm
                GeneticAlgorithm.CalculateFitness(population);
                List<Chromosome> elites = GeneticAlgorithm.ApplyElitism(population, eliteCount);
                List<Chromosome> parents = GeneticAlgorithm.Selection(population);
                List<Chromosome> children = GeneticAlgorithm.Crossover(parents, crossoverProbability);
                GeneticAlgorithm.Mutation(children, mutationProbability, minX, maxX);
                population = elites.Concat(children).ToList();


                // Graph
                Chromosome currentBestSolution = population.OrderBy(c => c.Fitness).First();
                if (currentBestSolution.Fitness < best.Fitness)
                {
                    best = currentBestSolution;
                }
                dataX.Add(iterationsCount);
                dataY.Add(currentBestSolution.Fitness);
                iterationsCount++;


                formsPlot1.Plot.Axes.SetLimits(0, 10, -0.0001, 0.0001);
                formsPlot1.Plot.Axes.AutoScaleExpand();

                if (graphTypeCombo.Text == "Signal")
                    formsPlot1.Plot.Add.Signal(dataY);
                else
                    formsPlot1.Plot.Add.Scatter(dataX, dataY);

                if (iterationsCount % Convert.ToInt32(graphOptimizeCombo.Text) == 0)
                    formsPlot1.Refresh();

                if (isBreak)
                    break;

            }
            //MessageBox.Show("Best solution found: " + best.Fitness + "\nX: " + best.X + "\nY: " + best.Y);
            //MessageBox.Show("Fitness: " + GeneticAlgorithm.EvaluateFitness(best.X, best.Y));
            if (isBreak)
            {
                reset();
            }
            else
            {
                answerBox.Items.Add("Best solution found: " + best.Fitness);
                answerBox.Items.Add("X: " + best.X);
                answerBox.Items.Add("Y: " + best.Y);
                answerBox.Items.Add(" ");
                answerBox.Items.Add(" ");
                formsPlot1.Refresh();
            }
            startButton.Enabled = true;


        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            if (runTypeCombo.Text == "Sync")
            {
                breakButton.Enabled = false;
                start();
            }

            else
            {
                breakButton.Enabled = true;
                await Task.Run(start);
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void resetGraphButton_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();
        }

        private void resetAnswerButton_Click(object sender, EventArgs e)
        {
            answerBox.Items.Clear();
        }

        private void populationNumeric_ValueChanged(object sender, EventArgs e)
        {
            elitisimNumeric.Maximum = populationNumeric.Value;
        }

        private void breakButton_Click(object sender, EventArgs e)
        {
            isBreak = true;
        }

        private void reset()
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();
            populationNumeric.Value = 50;
            generationNumeric.Value = 50;
            elitisimNumeric.Value = 1;
            crossNumeric.Value = 0.8M;
            mutationNumeric.Value = 0.05M;
            graphTypeCombo.Text = "Scatter";
            graphOptimizeCombo.Text = "10";
            answerBox.Items.Clear();
        }

        private void runTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (runTypeCombo.Text == "Sync")
                breakButton.Enabled = false;
            else
                breakButton.Enabled = true;
        }
    }
}