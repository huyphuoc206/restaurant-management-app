using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class AbstractModel
    {
        protected long iD;
        protected DateTime createdDate;
        protected string createdBy;
        protected DateTime modifiedDate;
        protected string modifiedBy;

        public long ID { get => iD; set => iD = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime ModifiedDate { get => modifiedDate; set => modifiedDate = value; }
        public string ModifiedBy { get => modifiedBy; set => modifiedBy = value; }
    }
}
