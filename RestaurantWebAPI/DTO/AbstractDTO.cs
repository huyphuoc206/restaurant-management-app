using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebAPI.DTO
{
    public abstract class AbstractDTO
    {
        private long iD;
        private DateTime createdDate;
        private string createdBy;
        private DateTime modifiedDate;
        private string modifiedBy;

        protected long ID { get => iD; set => iD = value; }
        protected DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        protected string CreatedBy { get => createdBy; set => createdBy = value; }
        protected DateTime ModifiedDate { get => modifiedDate; set => modifiedDate = value; }
        protected string ModifiedBy { get => modifiedBy; set => modifiedBy = value; }
    }
}