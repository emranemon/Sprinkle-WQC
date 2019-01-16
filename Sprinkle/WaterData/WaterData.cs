using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Runtime.Api;


namespace Sprinkle.WaterData
{
    class WaterData
    {

        [Column("4")]
        public float Conductivity;

        [Column("5")]
        public float PH;

        [Column("6")]
        public float Turbidity;


        [Column("7")]
        [ColumnName("Label")]
        public string Label { get; set; }
    }
}
