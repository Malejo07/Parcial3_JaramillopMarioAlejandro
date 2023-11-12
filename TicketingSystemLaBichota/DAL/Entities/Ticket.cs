using System.ComponentModel.DataAnnotations;

namespace TicketingSystemLaBichota.DAL.Entities
{
    public class Ticket : Entity
    {
        #region
        [Display(Name = "Ingrese su Ticket")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int TicketId { get; set; }

        [Display(Name = "Fecha de Uso")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Ticket usado?")]
        public bool IsUsed { get; set; }

        [Display(Name = "Porteria de Entrada")]
        public Entrance? EntranceGate { get; set; }

        public enum Entrance
        {
            Oriental,
            Occidental,
            Norte,
            Sur,
        }
        #endregion
    }
}
