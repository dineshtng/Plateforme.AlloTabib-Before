﻿using Plateforme.AlloTabib.DomainLayer.Models;
using PlateformeAlloTabib.Standards.Domain;
using System.Collections.Generic;

namespace Plateforme.AlloTabib.DomainLayer.DomainServices.CreneauDomainServices
{
    public interface ICreneauDomainServices
    {
        ResultOfType<IList<CreneauResultDataModel>> PostNewCreneau(IList<CreneauDataModel> creneauToAdd);
        ResultOfType<CreneauResultModel> GetCreneauxByPraticien(string cin, int take = 0, int skip = 0);
        ResultOfType<CreneauResultDataModel> GetCreneauByHeureDebutAndDate(string heureDebut, string praticien, string dateCurrent);
        ResultOfType<Null> DeleteCreneau(string praticien, string dateCurrent, string heureDebut);
        ResultOfType<CreneauResultDataModel> UpdateCreneauPraticienByDate(string praticien, string dateCurrent,CreneauDataModel creneau);
        ResultOfType<Null> PostCreneaux(string from, string to, string cinPraticien, string dateSelected);
        ResultOfType<Null> PostCreneauxJour(string from, string to, string cinPraticien, string jour);


    }
}
