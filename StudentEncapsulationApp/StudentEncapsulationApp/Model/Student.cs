using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapsulationApp.Model
{
    class Student
    {
        public int id;
        public String name,grade;
        public double percentage,cgpa;

        public void SetId(int studId)
        {
            id = studId;
        }
        public int GetId()
        {
            return id;
        }
       public void SetName(String studName)
        {
            name = studName;
        }
        public String GetName()
        {
            return name;

        }
        public void SetCgpa(double studCgpa)
        {
            cgpa = studCgpa;
        }
        public double GetCgpa()
        {
            return cgpa;
        }
        public double CalculatePercentage()
        {
            percentage = (float)(9.5 * (cgpa));
            SetGrade(percentage);
            return percentage;
        }
        public void SetGrade(double studPercentage)
        {
            if(studPercentage >= 60)
            {
                grade = "A";
            }
            else if(studPercentage<60 && studPercentage>=48)
            {
                grade = "B";
            }
            else if(studPercentage<48 && studPercentage>=36)
            {
                grade = "C";
            }
            else
            {
                grade = "D";
            }
        }
        public string GetGrade()
        {
            return grade;
        }
    }
}
