using ScottPlot;
using System;

namespace genetic_algorithm_form
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        void start()
        {
            Chromosome best = new Chromosome();
            best.Fitness = double.MaxValue;
            int iterationsCount = 1;
            List<double> dataX = new List<double>();
            List<double> dataY = new List<double>();

            int populationSize = Convert.ToInt32(populationNumeric.Value);
            int maxGenerations = Convert.ToInt32(generationNumeric.Value);
            double crossoverProbability = Convert.ToDouble(crossNumeric.Value);
            double mutationProbability = Convert.ToDouble(mutationNumeric.Value);

            double minX = -4.5;
            double maxX = 4.5;

            List<Chromosome> population = GeneticAlgorithm.InitializePopulation(populationSize, minX, maxX);

            for (int generation = 0; generation < maxGenerations; generation++)
            {
                // Algoritma
                GeneticAlgorithm.CalculateFitness(population);
                List<Chromosome> parents = GeneticAlgorithm.Selection(population);
                List<Chromosome> offspring = GeneticAlgorithm.Crossover(parents, crossoverProbability);
                GeneticAlgorithm.Mutation(offspring, mutationProbability, minX, maxX);
                population = offspring;


                // Grafik
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

            }
            MessageBox.Show("Best solution found: " + best.Fitness + "\nX: " + best.X + "\nY: " + best.Y);
            MessageBox.Show("Fitness: " + GeneticAlgorithm.EvaluateFitness(best.X, best.Y));

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            start();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Refresh();
            populationNumeric.Value = 50;
            generationNumeric.Value = 50;
            crossNumeric.Value = 0.8M;
            mutationNumeric.Value = 0.05M;
            graphTypeCombo.Text = "Scatter";
            graphOptimizeCombo.Text = "10";
        }
    }
}