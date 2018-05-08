﻿using CodeBase;
using CRFBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRFToolAppBase
{
    class LoadCRFGraphManager : GWManager<LoadCRFGraph>
    {
        protected override void OnRequest(LoadCRFGraph request)
        {
            var graph = default(IGWGraph<SGLNodeData, SGLEdgeData, SGLGraphData>);

            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Graph Files|*.crf";
                openFileDialog1.Title = "Select a CRF graph File";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    graph = JSONX.LoadFromJSON<GWGraph<SGLNodeData, SGLEdgeData, SGLGraphData>>(openFileDialog1.FileName);
                }
            }
            int nodeCounter = 0;
            foreach (var node in graph.Nodes)
            {
                node.Data.Ordinate = nodeCounter;
                nodeCounter++;
            }

            request.Graph = graph;
        }
    }

    public class LoadCRFGraph : GWRequest<LoadCRFGraph>
    {
        public IGWGraph<SGLNodeData, SGLEdgeData, SGLGraphData> Graph { get; set; }
    }
}
