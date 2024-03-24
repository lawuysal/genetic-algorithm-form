using genetic_algorithm_form;
using System;

public class GeneticAlgorithm
{
    static Random random = new Random();

    public static List<Chromosome> InitializePopulation(int size, double minX, double maxX)
    {
        List<Chromosome> population = new List<Chromosome>();
        for (int i = 0; i < size; i++)
        {
            population.Add(new Chromosome
            {
                X = minX + (maxX - minX) * random.NextDouble(),
                Y = minX + (maxX - minX) * random.NextDouble()
            });
        }
        return population;
    }

    public static double EvaluateFitness(double x, double y)
    {
        double result = Math.Pow(1.5 - x + x * y, 2) + Math.Pow(2.25 - x + x * y * y, 2) + Math.Pow(2.625 - x + x * Math.Pow(y, 3), 2);
        return result;
    }

    public static void CalculateFitness(List<Chromosome> population)
    {
        foreach (var individual in population)
        {
            individual.Fitness = EvaluateFitness(individual.X, individual.Y);
        }
    }

    public static List<Chromosome> Selection(List<Chromosome> population)
    {
        // Tournament size (number of individuals competing in each tournament)
        int tournamentSize = 5;
        List<Chromosome> selectedParents = new List<Chromosome>();

        for (int i = 0; i < population.Count; i++)
        {
            // Randomly select individuals for the tournament
            List<Chromosome> tournamentParticipants = new List<Chromosome>();
            for (int j = 0; j < tournamentSize; j++)
            {
                int randomIndex = random.Next(population.Count);
                tournamentParticipants.Add(population[randomIndex]);
            }

            // Select the best individual from the tournament
            Chromosome winner = tournamentParticipants.OrderBy(c => c.Fitness).First();
            selectedParents.Add(winner);
        }

        return selectedParents;
    }

    public static List<Chromosome> Crossover(List<Chromosome> parents, double crossoverProbability)
    {
        List<Chromosome> offspring = new List<Chromosome>();
        for (int i = 0; i < parents.Count; i += 2)
        {
            if (random.NextDouble() < crossoverProbability)
            {
                // Perform crossover (blend crossover)
                double alpha = random.NextDouble();

                Chromosome child1 = new Chromosome();
                Chromosome child2 = new Chromosome();

                child1.X = alpha * parents[i].X + (1 - alpha) * parents[i + 1].X;
                child1.Y = alpha * parents[i].Y + (1 - alpha) * parents[i + 1].Y;

                child2.X = (1 - alpha) * parents[i].X + alpha * parents[i + 1].X;
                child2.Y = (1 - alpha) * parents[i].Y + alpha * parents[i + 1].Y;

                // Recalculate fitness for offspring
                child1.Fitness = EvaluateFitness(child1.X, child1.Y);
                child2.Fitness = EvaluateFitness(child2.X, child2.Y);

                offspring.Add(child1);
                offspring.Add(child2);
            }
            else
            {
                // If crossover doesn't occur, just add parents to offspring
                offspring.Add(parents[i]);
                offspring.Add(parents[i + 1]);
            }
        }
        return offspring;
    }

    public static void Mutation(List<Chromosome> population, double mutationProbability, double minX, double maxX)
    {
        foreach (var individual in population)
        {
            if (random.NextDouble() < mutationProbability)
            {
                individual.X = minX + (maxX - minX) * random.NextDouble();
                individual.Y = minX + (maxX - minX) * random.NextDouble();
            }
        }
    }
}
