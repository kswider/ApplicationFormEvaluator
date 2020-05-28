using ApplicationFormEvaluatorML.Model;
using Microsoft.ML;
using System;

namespace ApplicationFormEvaluator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            Console.WriteLine("Please provide your ECTS deficit application form");
            input.Text = Console.ReadLine();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            if (result.Prediction)
                Console.WriteLine("Your application form passed!");
            else
                Console.WriteLine("Your application form did not pass. Your ECTS deficit is too high :(");
        }
    }
}
