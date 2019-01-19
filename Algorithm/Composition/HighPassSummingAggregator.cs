using System.Collections.Generic;

namespace Algorithm.Composition
{
    public class HighPassSummingAggregator
    {
        public HighPassSummingAggregator(IEnumerable<Measurement> measurements)
        {
            _pointsAggregator = new PointsAggregator(measurements, new HighPassFilter(), new SummingStrategy());
        }
        
        public virtual Measurement Aggregate()
        {
            return _pointsAggregator.Aggregate();
        }

        private PointsAggregator _pointsAggregator;
    }
}