using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Occupation
    {
        private int occupationId;
        private string title;
        
        public Occupation() { }

        public int OccupationId { get => occupationId; set => occupationId = value; }
        public string Title { get => title; set => title = value; }
    }
}
