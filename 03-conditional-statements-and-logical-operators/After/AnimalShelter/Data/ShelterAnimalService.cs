using System;
using System.Collections.Generic;

namespace AnimalShelter.Data
{
    public class ShelterAnimalService
    {
        public readonly int AnimalCapacity = 20;
        private readonly ShelterCalendarService _calendarService;
        private List<string> _animals = new List<string>();
        public ShelterAnimalService(ShelterCalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        public string GetAnimalCountText()
    {
        if (_animals.Count == 0)
        {
            return "no";
        }
        else if (_animals.Count == AnimalCapacity)
        {
            return _animals.Count + " (full capacity)";
        }
        else
        {
            return _animals.Count.ToString();
        }
    }

        public void AddAnimal(string name)
        {
        if (!_calendarService.IsShelterOpen())
        return;
        if (_animals.Count == AnimalCapacity)
        return;
        if (_animals.Contains(name))
        return;
          _animals.Add(name);
        }
    }
}