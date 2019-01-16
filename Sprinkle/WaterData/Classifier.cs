using System;
using Microsoft.ML.Legacy;
using Microsoft.ML.Legacy.Data;
using Microsoft.ML.Legacy.Trainers;
using Microsoft.ML.Legacy.Transforms;
using System.IO;
using Microsoft.ML.Runtime;

namespace Sprinkle.WaterData
{
    class Classifier
    {
        static readonly string dataPath = Path.Combine(Environment.CurrentDirectory, "WaterData", "water-data.csv");

        public string Classify(float ec, float ph, float ntu)
        {

            // STEP 2: Create a pipeline and load your data
            var pipeline = new LearningPipeline();

            // If working in Visual Studio, make sure the 'Copy to Output Directory' 
            // property of water-data.txt is set to 'Copy always'
            pipeline.Add(new TextLoader(dataPath).CreateFrom<WaterData>(useHeader: true, separator: ','));

            // STEP 3: Transform your data
            // Assign numeric values to text in the "Label" column, because only
            // numbers can be processed during model training
            pipeline.Add(new Dictionarizer("Label"));

            // Puts all features into a vector
            pipeline.Add(new ColumnConcatenator("Features", "Conductivity", "PH", "Turbidity"));

            // STEP 4: Add learner
            // Add a learning algorithm to the pipeline. 
            // This is a classification scenario (What type of water is this?)

            //******    **************////// 
            //This algorithm gives the highest accuracy for our water dataset
            pipeline.Add(new FastForestBinaryClassifier
            {
                NumTrees = 5,
                NumLeaves = 2,
                Calibrator = new FixedPlattCalibratorCalibratorTrainer()
            }); 

            // Convert the Label back into original text (after converting to number in step 3)
            pipeline.Add(new PredictedLabelColumnOriginalValueConverter() { PredictedLabelColumn = "PredictedLabel" });

            // STEP 5: Train your model based on the data set
            var model = pipeline.Train<WaterData, WaterPrediction>();

            // STEP 6: Use your model to make a prediction
            // You can change these numbers to test different predictions
            var prediction = model.Predict(new WaterData()
            {
                PH = ph,
                Turbidity = ntu,
                Conductivity = ec
            });
            
            //let's return the predicted string value
            return prediction.PredictedLabels;
        }
    }
}
