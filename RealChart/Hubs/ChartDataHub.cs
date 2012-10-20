using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace TechBrij.RealChart
{
    [HubName("chartData")]
    public class ChartDataHub : Hub
    {
        private readonly ChartData _pointer;

        public ChartDataHub() : this(ChartData.Instance) { }

        public ChartDataHub(ChartData pointer)
        {
            _pointer = pointer;
        }

        public IEnumerable<int> initData()
        {
            return _pointer.initData();
        }       
    }
}