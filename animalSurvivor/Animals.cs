using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace animalSurvivor
{
    internal class Animals
    {
        List<Animal> _animals;
        int _list = 3;
        Form _frm;
        public List<Animal> AnimalList { get { return _animals; } }

        public Animals(Form frm, AnimalEnum animal) 
        {
            _frm = frm;
            _animals = new List<Animal>();
            for(int i =0; i< _list; i++)
            {
                switch (animal)
                {
                    case AnimalEnum.Cat:
                        _animals.Add(new Cat(_frm));
                        break;
                    case AnimalEnum.Cow:
                        _animals.Add(new Cow(_frm));
                        break;
                    case AnimalEnum.Horse:
                        _animals.Add(new Horse(_frm));
                        break;
                    case AnimalEnum.Pigeon:
                        _animals.Add(new Pigeon(_frm));
                        break;
                    case AnimalEnum.Rabbit:
                        _animals.Add(new Rabbit(_frm));
                        break;
                    case AnimalEnum.Tiger:
                        _animals.Add(new Tiger(_frm));
                        break;
                    case AnimalEnum.Goat:
                        _animals.Add(new Goat(_frm));
                        break;
                }
            }
        }
    }
}
