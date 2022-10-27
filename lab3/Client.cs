using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    public abstract class Client {
        public string Username { get; set; }
        public string Description { get; set; } = "No Description";
        public string Email { get; set; }
        public int Reputation { get; set; }

        public virtual void GetBadges(Client client) {

        }

        public virtual string GetDescription() {
            return Description;
        }
    }
}
