﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Threading;
using NiceHashMarket.Core.Helpers;
using NiceHashMarket.Model.Interfaces;

namespace NiceHashMarket.Core
{
    public delegate void AlgoChangedDelegate<T>(DataStorage<T> sender, IAlgo oldAlgo, IAlgo newAlgo) 
        where T : IHaveId, INotifyPropertyChanged;

    public class DataStorage<T> : IEnumerable<T>
        where T : IHaveId, INotifyPropertyChanged
    {
        private Timer _timer;
        private readonly int _frequencyQueryMilliseconds;
        protected readonly Dispatcher _currentDispatcher;

        public event AlgoChangedDelegate<T> AlgoChanging;
        public event AlgoChangedDelegate<T> AlgoChanged;

        public IAlgo Algo { get; set; }
        public ApiClient ApiClient { get; set; }
        public NiceBindingList<T> Entities { get; set; }

        public DataStorage(IAlgo algo, int frequencyQueryMilliseconds, Dispatcher currentDispatcher = null)
        {
            _currentDispatcher = currentDispatcher;
            _frequencyQueryMilliseconds = frequencyQueryMilliseconds;

            Algo = algo;

            Entities = new NiceBindingList<T>();

            ApiClient = new ApiClient();

            _timer = new Timer(TimerOnElapsed, null, 0, _frequencyQueryMilliseconds);
        }

        private void TimerOnElapsed(object state)
        {
            JsonQueryExecute();
        }

        public virtual void SelectAnotherAlgo(IAlgo newAlgo)
        {
            var oldAlgo = Algo;
            AlgoChanging?.Invoke(this, oldAlgo, newAlgo);

            Entities = new NiceBindingList<T>();
            Algo = newAlgo;

            AlgoChanged?.Invoke(this, oldAlgo, newAlgo);
        }

        public virtual void JsonQueryExecute()
        {
        }

        public void UpdateBindingList(IEnumerable<T> entities)
        {
            if (entities.Any())
            {
                var entitiesIds = entities.Select(e => e.Id).ToList();
                var closedEntities = Entities.Where(e => !entitiesIds.Contains(e.Id)).Select(e => e.Id).ToList();

                closedEntities.ForEach(eid => Entities.Remove(Entities.First(e => e.Id == eid)));
            }

            foreach (var entity in entities)
            {
                var knownEntity = Entities.FirstOrDefault(x => x.Id == entity.Id);

                if (knownEntity == null)
                {
                    Entities.Add(entity);
                    continue;
                }

                entity.CopyProperties(knownEntity);
            }
        }

        public T this[int index]
        {
            get => Entities[index];
            set => Entities[index] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
