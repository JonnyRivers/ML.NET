using System;

using MyFirstMLAppML.Model;

namespace MyFirstMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput
            {
                SentimentText = "My name is Michael Phelps."
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"prediction: {result.Prediction}; score: {result.Score};");
        }
    }
}
