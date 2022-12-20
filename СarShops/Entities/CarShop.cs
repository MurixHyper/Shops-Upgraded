using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace СarShops.Entities
{
    public class CarShop : BaseEntity, IComparable
    {
        private Dictionary<string, Worker> _workerDictionary { get; set; } = new();
        public List<Car> Cars { get; set; } = new();
        public Dictionary<string, Worker> WorkerDictionaty => _workerDictionary;
        public List<Worker> Workers => _workerDictionary.Values.ToList();
        public string? Address { get; set; }
        public int WorkersAmount=>_workerDictionary.Count;
        public int CarsAmount=>Cars.Count;

        public void AddWorker(Worker person)
        {
            if (person is null)
                throw new ArgumentNullException(nameof(person));

            _workerDictionary.Add(person.Code, person);
        }

        public void RemoveWorker(string code)
        {
            _workerDictionary.Remove(code);
        }

        public void RemoveAllWorkers()
        { 
            _workerDictionary.Clear(); 
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Workers Amount: {WorkersAmount}, Cars Amount: {CarsAmount}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is null) return 1;

            var carShop = obj as CarShop;
            if (carShop is not null)
                return WorkersAmount.CompareTo(carShop.WorkersAmount);

            throw new ArgumentException("object is not CarShop");
        }
    }
}