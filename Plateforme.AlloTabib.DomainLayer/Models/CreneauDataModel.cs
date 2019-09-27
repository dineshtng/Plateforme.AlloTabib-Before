﻿namespace Plateforme.AlloTabib.DomainLayer.Models
{
    public class CreneauDataModel
    {
        public string Id { get; set; }
        public  string HeureDebut { get; set; }
        public  string HeureFin { get; set; }
        public  string Status { get; set; } //disponible ou pas
        public string PraticienEmail { get; set; }
        public string CurrentDate { get; set; }
        public string Commentaire { get; set; }
    }
}
