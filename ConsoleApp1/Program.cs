

public class Adventurer
{
    static void Main(string[] args)
    {
        // Path to the instructions file\
       // string filePath = "C:\\Users\\MSI EVO\\source\\repos\\saipriya-tripuraneni-adventurer-journey-be\Adventurer Path.md";
        string filePath = @"C:\Users\MSI EVO\source\repos\saipriya-tripuraneni-adventurer-journey-be\Adventurer Path.md";

        // Read the instructions from the file
        string[] instructions = File.ReadAllLines(filePath);

        // Initialize starting position
        double x = 0, y = 0;

        // Process each instruction
        foreach (var instruction in instructions)
        {
            ParseInstruction(instruction, ref x, ref y);
        }

        // Calculate Euclidean distance
        double distance = Math.Sqrt(x * x + y * y);

        // Output the distance
        Console.WriteLine($"The Euclidean distance to the destination is: {distance}");
    }

    static void ParseInstruction(string instructions, ref double x, ref double y)
    {
        for (int i = 0; i < instructions.Length; i++)
        {
            // Extract the number of steps
            int steps = 0;
            while (i < instructions.Length && char.IsDigit(instructions[i]))
            {
                steps = steps * 10 + (instructions[i] - '0');
                i++;
            }

            // If we've reached the end of the string, break
            if (i >= instructions.Length)
                break;

            // Get the direction
            char direction = instructions[i];

            // Update position based on direction
            switch (direction)
            {
                case 'F':
                    y += steps; // Move forward (North)
                    break;
                case 'B':
                    y -= steps; // Move backward (South)
                    break;
                case 'R':
                    x += steps; // Move right (East)
                    break;
                case 'L':
                    x -= steps; // Move left (West)
                    break;
                default:
                    Console.WriteLine($"Unknown direction: {direction}");
                    break;
            }
        }

    }
}
