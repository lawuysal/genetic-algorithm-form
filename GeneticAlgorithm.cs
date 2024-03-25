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
            Chromosome tempChromosome = new Chromosome();
            tempChromosome.X = minX + (maxX - minX) * random.NextDouble();
            tempChromosome.Y = minX + (maxX - minX) * random.NextDouble();
            population.Add(tempChromosome);
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
        foreach (var ch in population)
        {
            ch.Fitness = EvaluateFitness(ch.X, ch.Y);
        }
    }

    public static List<Chromosome> Selection(List<Chromosome> population)
    {
        int size = 5;
        List<Chromosome> selectedParents = new List<Chromosome>();

        for (int i = 0; i < population.Count; i++)
        {
            List<Chromosome> players = new List<Chromosome>();
            for (int j = 0; j < size; j++)
            {
                int randomIndex = random.Next(population.Count);
                players.Add(population[randomIndex]);
            }

            Chromosome winner = players.OrderBy(c => c.Fitness).First();
            selectedParents.Add(winner);
        }

        return selectedParents;
    }

    public static List<Chromosome> Crossover(List<Chromosome> parents, double crossoverProbability)
    {
        List<Chromosome> children = new List<Chromosome>();
        int lastIndex = parents.Count - 1;

        for (int i = 0; i < lastIndex; i += 2)
        {
            if (random.NextDouble() < crossoverProbability)
            {
                double alpha = random.NextDouble();

                Chromosome child1 = new Chromosome();
                Chromosome child2 = new Chromosome();

                child1.X = alpha * parents[i].X + (1 - alpha) * parents[i + 1].X;
                child1.Y = alpha * parents[i].Y + (1 - alpha) * parents[i + 1].Y;
                child2.X = (1 - alpha) * parents[i].X + alpha * parents[i + 1].X;
                child2.Y = (1 - alpha) * parents[i].Y + alpha * parents[i + 1].Y;
                child1.Fitness = EvaluateFitness(child1.X, child1.Y);
                child2.Fitness = EvaluateFitness(child2.X, child2.Y);

                children.Add(child1);
                children.Add(child2);
            }
            else
            {
                children.Add(parents[i]);
                children.Add(parents[i + 1]);
            }
        }

        if (parents.Count % 2 != 0)
        {
            children.Add(parents[lastIndex]);
        }

        return children;
    }


    public static void Mutation(List<Chromosome> population, double mutationProbability, double minX, double maxX)
    {
        foreach (var ch in population)
        {
            if (random.NextDouble() < mutationProbability)
            {
                ch.X = minX + (maxX - minX) * random.NextDouble();
                ch.Y = minX + (maxX - minX) * random.NextDouble();
            }
        }
    }

    public static List<Chromosome> ApplyElitism(List<Chromosome> population, int eliteCount)
    {
        population.Sort((x, y) => x.Fitness.CompareTo(y.Fitness));
        List<Chromosome> elites = population.GetRange(0, eliteCount);

        return elites;
    }

}
