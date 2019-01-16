using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Runtime.Api;

namespace Sprinkle.WaterData
{
    class WaterPrediction
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels { get; set; }
    }
}
