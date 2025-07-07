﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Job
    {
        private string _description;
        private float _hoursToComplete;
        private float _hourlyFee;
        private float _totalFee;

        public float TRIP_FEE = 35;
        public Job(string description, float hoursToComplete, float hourlyFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;

        }
        public string Description { get { return _description; } set { _description = value; } }
        public float HoursToComplete { get { return _hoursToComplete; } set { _hoursToComplete = value; } }
        public float HourlyFee { get { return _hourlyFee; } set { _hourlyFee = value; } }
        public float TotalFee { get { return _totalFee; } }

    
     public void CalculateTotalFee()
        {
            _totalFee = (_hoursToComplete * _hourlyFee) + TRIP_FEE;
        }
    }
}
