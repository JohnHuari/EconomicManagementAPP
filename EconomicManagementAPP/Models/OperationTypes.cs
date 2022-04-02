using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EconomicManagementAPP.Models
{
    public class OperationTypes
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Remote(action: "VerificaryOperationTypes", controller: "OperationTypes")]
        public string Description { get; set; }
    }
}
