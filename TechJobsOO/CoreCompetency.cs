using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        public int id;
        private static int nextId = 1;
        public string Value;

        // Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

        public CoreCompetency(string value) : this()
        {
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
