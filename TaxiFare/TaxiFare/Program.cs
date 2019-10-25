using System;

using TaxiFareML.Model;

namespace TaxiFare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput
            {
                Vendor_id = "CMT",
                Rate_code = 1,
                Passenger_count = 1,
                Trip_time_in_secs = 20 * 60,
                Trip_distance = 12,
                Payment_type = "CRD"
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"prediction: {result.Score};");
        }
    }
}
