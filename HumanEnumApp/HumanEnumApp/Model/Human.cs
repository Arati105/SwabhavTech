using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanEnumApp.Model
{
    class Human
    {
        private string _name;
        private float _height;
        private float _weight;
        private  GenderType _gender;



        public Human(string name, float height, float weight, GenderType gender)
        {
            this._name = name;
            this._height = height;
            this._weight = weight;
            this._gender = gender;
        }


        public string GetName()
        {
            return _name;
        }
       public float GetHeight()
        {
            return _height;
        }
        public float GetWeight()
        {
            return _weight;
        }
        public GenderType GetGender()
        {
            return _gender;
        }

         public void Eat()
        {
            _weight +=_weight *  20/100;
        }
        public void Workout()
        {
            _height += _height * 5/100;
            _weight -=_weight  *  10/100;

           
        }
    }
}
