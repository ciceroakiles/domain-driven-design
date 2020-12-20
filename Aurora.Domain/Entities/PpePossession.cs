using System;
using System.Collections.Generic;
using System.Text;

namespace Aurora.Domain.Entities
{
    // Posse do EPI pela pessoa
    public class PpePossession : BaseEntity<int>
    {
        public PpePossession(DateTime deliveryDate, DateTime returnDate, bool confirmation)
        {
            DeliveryDate = deliveryDate;
            ReturnDate = returnDate;
            Confirmation = confirmation;
        }

        protected PpePossession() { }

        public DateTime DeliveryDate { get; }

        public DateTime? ReturnDate { get; }

        public bool Confirmation { get; }

        // Chaves estrangeiras
        #region Foreign Keys

        public int WorkerId { get; set; }

        public virtual Worker Worker { get; set; }

        public int PersonalProtectiveEquipmentId { get; set; }

        public virtual PersonalProtectiveEquipment PersonalProtectiveEquipment { get; set; }

        #endregion
    }
}
