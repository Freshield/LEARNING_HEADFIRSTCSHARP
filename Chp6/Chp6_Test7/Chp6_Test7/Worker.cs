using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chp6_Test7
{
    class Worker : Bee
    {
        private string[] jobsICanDo;
        private string currentJob = "";
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo,double weight)
            :base(weight)
        {
            this.jobsICanDo = jobsICanDo;
        }

        //getter and setter
        public override int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }

        }

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            for (int i = 0; i < jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
        }

        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
