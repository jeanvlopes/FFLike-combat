﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FFLike_combat
{
    class Queue
    {
        public List<Unit> Units { get; set; } = new List<Unit>();

        public void Add(Unit unit)
        {
            Units.Insert(0, unit);
        }

        public Unit Pop()
        {
            var unit = Units.Last();
            Units.Remove(unit);
            Add(unit);
            return unit;
        }

        public void Reset()
        {
            Units = new List<Unit>();
        }

        public void Kill(Team team, Unit unit)
        {
            Units.Remove(unit);
            if (team.Ally.Contains(unit))
            {
                team.Ally.Remove(unit);
            }
            else if (team.Enemy.Contains(unit))
            {
                team.Enemy.Remove(unit);
            }
        }
    }
}
