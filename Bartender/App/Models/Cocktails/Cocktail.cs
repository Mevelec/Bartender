using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Cocktail
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return string.Format("Id={0}    name={1}    description={2}", this.Id, this.name, this.description);
        }

    }
}
