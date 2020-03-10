using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int sumOfTemps = 0;
            //loop through all of the temps in the list
            foreach (int temp in _temperatures)
            {
                sumOfTemps += temp;
            }

            int averageTemps = sumOfTemps / _temperatures.Count;

            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            int countAboveThreshold = 0;
            // add logic to calculate temps above the threshold
            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    ++countAboveThreshold;
                }

            }

            return countAboveThreshold; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int countBelowThreshold = 0;
            // add logic to calculate and return temps below the threshold
            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    ++countBelowThreshold;
                }
            }
            return countBelowThreshold; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int countAtThreshold = 0;
            // add logic to calculate and return temps at the threshold
            foreach (int temp in _temperatures)
            {
                if(temp == threshold)
                {
                    ++countAtThreshold;
                }
            }
            return countAtThreshold; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
