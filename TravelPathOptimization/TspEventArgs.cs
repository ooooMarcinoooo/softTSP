﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPathOptimization
{
    public class TspEventArgs : EventArgs
    {
        public TspEventArgs()
        {
        }
        public TspEventArgs(Cities cityList, Tour bestTour, int generation, bool complete)
        {
            this.cityList = cityList;
            this.bestTour = bestTour;
            this.generation = generation;
            this.complete = complete;
        }
        private Cities cityList;
        public Cities CityList
        {
            get
            {
                return cityList;
            }
        }
        private Tour bestTour;
        public Tour BestTour
        {
            get
            {
                return bestTour;
            }
        }
        private int generation;
        public int Generation
        {
            get
            {
                return generation;
            }
            set
            {
                generation = value;
            }
        }
        private bool complete = false;
        public bool Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }
    }
}
