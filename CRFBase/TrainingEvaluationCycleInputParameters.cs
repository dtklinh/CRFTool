﻿using CodeBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRFBase
{
    public class TrainingEvaluationCycleInputParameters
    {
        public TrainingEvaluationCycleInputParameters() {

        }
        public TrainingEvaluationCycleInputParameters(GWGraph<CRFNodeData, CRFEdgeData, CRFGraphData> graph,
            int numberOfGraphInstances, int numberOfSeedsForPatchCreation, int maximumTotalPatchSize,
            List<OLMVariant> trainingVariantsToTest, double isingConformityParameter, double isingCorrelationParameter,
            double[,] transitionProbabilities, int numberOfLabels, int bufferSizeViterbi) {
            Graph = graph;
            NumberOfGraphInstances = numberOfGraphInstances;
            NumberOfSeedsForPatchCreation = numberOfSeedsForPatchCreation;
            MaximumTotalPatchSize = maximumTotalPatchSize;
            TrainingVariantsToTest = trainingVariantsToTest;
            IsingConformityParameter = isingConformityParameter;
            IsingCorrelationParameter = isingCorrelationParameter;
            TransitionProbabilities = transitionProbabilities;
            NumberOfLabels = numberOfLabels;
            BufferSizeViterbi = bufferSizeViterbi;
        }
        public GWGraph<CRFNodeData, CRFEdgeData, CRFGraphData> Graph { get; set; }
        public int NumberOfGraphInstances { get; set; }
        public int NumberOfSeedsForPatchCreation { get; set; }
        public int MaximumTotalPatchSize { get; set; }
        public List<OLMVariant> TrainingVariantsToTest { get; set; }
        public double IsingConformityParameter { get; set; }
        public double IsingCorrelationParameter { get; set; }
        // Dieses Feld gibt an wie wahrscheinlich es ist bei welchem Labeling welche Beobachtung entsteht.
        public double[,] TransitionProbabilities { get; set; }
        public int NumberOfLabels { get; set; }
        public int BufferSizeViterbi { get; set; }
    }
}
