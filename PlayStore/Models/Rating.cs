using Microsoft.ML;
using PlayStoreML.Model.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStore.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string TrackName { get; set; }
        public string Genre { get; set; }

        public decimal UserRating { get; set; }


        public float TestIt()
        {

            MLContext mlContext = new MLContext();

            ITransformer mlModel = mlContext.Model.Load(@"..\PlayStoreML.Model\MLModel.zip", out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
            // Use the code below to add input data
            var input = new ModelInput();
            Console.WriteLine("Enter The Track Name :");
            input.Track_name = TrackName;
            input.Prime_genre = Genre;
            //Console.WriteLine("Enter The Description :");
            //input.Description = Console.ReadLine();
            // Try model on sample data
            ModelOutput result = predEngine.Predict(input);
            Console.WriteLine("Result Rating=" + result.Prediction);
            //Console.WriteLine("Result=" + result.Score);

            // Console.ReadKey();
            return result.Prediction;
        }

    }
}
